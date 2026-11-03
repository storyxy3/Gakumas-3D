namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncBecameInvisibleTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnBecameInvisible()
        {
        }

        public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler()
        {
            return null;
        }

        public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnBecameInvisibleAsync()
        {
            return default(UniTask);
        }

        public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncBecameInvisibleTrigger()
        {
        }
    }
}
