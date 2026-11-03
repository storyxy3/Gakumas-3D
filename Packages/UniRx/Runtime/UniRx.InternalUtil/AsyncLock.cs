namespace UniRx.InternalUtil
{
    using global::System;
    using global::System.Collections.Generic;

    internal sealed class AsyncLock : IDisposable
    {
        private readonly Queue<Action> queue;
        private bool isAcquired;
        private bool hasFaulted;
        public void Wait(Action action)
        {
        }

        public void Dispose()
        {
        }

        public AsyncLock()
        {
        }
    }
}
