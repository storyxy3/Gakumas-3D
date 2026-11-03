namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncPreCullTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnPreCull()
        {
        }

        public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnPreCullAsync()
        {
            return default(UniTask);
        }

        public UniTask OnPreCullAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncPreCullTrigger()
        {
        }
    }
}
