namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncFixedUpdateTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void FixedUpdate()
        {
        }

        public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler()
        {
            return null;
        }

        public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask FixedUpdateAsync()
        {
            return default(UniTask);
        }

        public UniTask FixedUpdateAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncFixedUpdateTrigger()
        {
        }
    }
}
