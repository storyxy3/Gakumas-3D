namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncDrawGizmosTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnDrawGizmos()
        {
        }

        public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler()
        {
            return null;
        }

        public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnDrawGizmosAsync()
        {
            return default(UniTask);
        }

        public UniTask OnDrawGizmosAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncDrawGizmosTrigger()
        {
        }
    }
}
