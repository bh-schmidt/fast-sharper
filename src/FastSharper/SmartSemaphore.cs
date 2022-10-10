using System;
using System.Threading;
using System.Threading.Tasks;

namespace FastSharper
{
    public class SmartSemaphore : IDisposable
    {
        private bool isDisposed;
        private SemaphoreSlim? semaphoreSlim;

        public SmartSemaphore(int maxCount) : this(maxCount, maxCount) { }

        public SmartSemaphore(int initialCount, int maxCount)
        {
            if (maxCount < 1)
                return;

            if (initialCount < 1)
                initialCount = 0;

            semaphoreSlim = new SemaphoreSlim(initialCount, maxCount);
        }

        public void Wait()
        {
            if (isDisposed)
                throw new ObjectDisposedException(nameof(SmartSemaphore));

            if (semaphoreSlim.IsNull())
                return;
            
            semaphoreSlim.Wait();
        }

        public async Task WaitAsync()
        {
            if (isDisposed)
                throw new ObjectDisposedException(nameof(SmartSemaphore));

            if (semaphoreSlim.IsNull())
                return;

            await semaphoreSlim.WaitAsync();
        }

        public void Release()
        {
            if (isDisposed)
                throw new ObjectDisposedException(nameof(SmartSemaphore));

            if (semaphoreSlim.IsNull())
                return;

            semaphoreSlim.Release();
        }

        public void Release(int releaseCount)
        {
            if (isDisposed)
                throw new ObjectDisposedException(nameof(SmartSemaphore));

            if (semaphoreSlim.IsNull())
                return;

            semaphoreSlim.Release(releaseCount);
        }

        public void Dispose()
        {
            semaphoreSlim?.Dispose();
            isDisposed = true;
        }

        ~SmartSemaphore()
        {
            Dispose();
            semaphoreSlim = null;
        }
    }
}
