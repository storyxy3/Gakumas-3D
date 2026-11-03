namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncDrawGizmosSelectedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnDrawGizmosSelected()
        {
        }

        public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnDrawGizmosSelectedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnDrawGizmosSelectedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncDrawGizmosSelectedTrigger()
        {
        }
    }
}
