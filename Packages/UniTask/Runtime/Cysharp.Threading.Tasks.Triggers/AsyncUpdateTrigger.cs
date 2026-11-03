namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncUpdateTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void Update()
        {
        }

        public IAsyncUpdateHandler GetUpdateAsyncHandler()
        {
            return null;
        }

        public IAsyncUpdateHandler GetUpdateAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask UpdateAsync()
        {
            return default(UniTask);
        }

        public UniTask UpdateAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncUpdateTrigger()
        {
        }
    }
}
