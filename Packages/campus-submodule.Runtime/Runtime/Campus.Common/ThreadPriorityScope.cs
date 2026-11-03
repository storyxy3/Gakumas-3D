namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    public class ThreadPriorityScope : IDisposable
    {
        private bool _isDisposed;
        private ThreadPriorityManager.PriorityLayer _layer;
        public ThreadPriorityScope(ThreadPriorityManager.PriorityLayer layer, ThreadPriority priority)
        {
        }

        public void Dispose()
        {
        }
    }
}
