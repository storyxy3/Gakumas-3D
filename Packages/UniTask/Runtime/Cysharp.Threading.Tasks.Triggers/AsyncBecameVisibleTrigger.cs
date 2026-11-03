namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncBecameVisibleTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnBecameVisible()
        {
        }

        public IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler()
        {
            return null;
        }

        public IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnBecameVisibleAsync()
        {
            return default(UniTask);
        }

        public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncBecameVisibleTrigger()
        {
        }
    }
}
