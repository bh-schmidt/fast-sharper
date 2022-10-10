using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastSharper
{
    public static partial class FS
    {
        public static async IAsyncEnumerable<TResult> ParallelSelectAsync<TEnumerable, TResult>(this IEnumerable<TEnumerable> src, Func<TEnumerable, Task<TResult>> select, ParallelOptions? options = null)
        {
            options ??= new ParallelOptions();
            var semaphore = new SmartSemaphore(options.MaxDegreeOfParallelism);
            List<Task<TResult>> tasks = new List<Task<TResult>>();

            foreach (var item in src)
            {
                await semaphore.WaitAsync();
                var task = Release(semaphore, select(item));
                tasks.Add(task);

                if (options.CancellationToken.IsCancellationRequested)
                    break;

                var completed = GetAndRemoveCompletedTask(tasks);
                if (completed.HasValue())
                    yield return await completed;
            }

            while (tasks.Count > 0)
            {
                await Task.WhenAny(tasks);

                var completed = GetAndRemoveCompletedTask(tasks);
                if (completed.HasValue())
                    yield return await completed;
            }
        }

        private static Task<TResult>? GetAndRemoveCompletedTask<TResult>(List<Task<TResult>> tasks)
        {
            var completed = tasks.FirstOrDefault(e => e.IsCompleted);
            if (completed.HasValue())
                tasks.Remove(completed);

            return completed;
        }

        private static async Task<TResult> Release<TResult>(SmartSemaphore semaphore, Task<TResult> task)
        {
            try { return await task; }
            catch { throw; }
            finally { semaphore.Release(); }
        }
    }
}
