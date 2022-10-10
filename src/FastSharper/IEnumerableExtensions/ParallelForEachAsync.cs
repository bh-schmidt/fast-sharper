using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Executes a foreach operation on an System.Collections.IEnumerable in which iterations may run in parallel and async.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="src"></param>
        /// <param name="action"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static async Task ParallelForEachAsync<TEnumerable>(this IEnumerable<TEnumerable> src, Func<TEnumerable, Task> action, ParallelOptions? options = null)
        {
            options ??= new ParallelOptions();
            var semaphore = new SmartSemaphore(options.MaxDegreeOfParallelism);
            List<Task> tasks = new List<Task>();

            foreach (var item in src)
            {
                await semaphore.WaitAsync();
                var task = Release(semaphore, action(item));
                tasks.Add(task);

                if (options.CancellationToken.IsCancellationRequested)
                    break;
            }

            foreach (var task in tasks)
                await task;
        }

        private static async Task Release(SmartSemaphore semaphore, Task task)
        {
            try { await task; }
            catch { throw; }
            finally { semaphore.Release(); }
        }
    }
}
