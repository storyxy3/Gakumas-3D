namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncDisableTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnDisable()
        {
        }

        public IAsyncOnDisableHandler GetOnDisableAsyncHandler()
        {
            return null;
        }

        public IAsyncOnDisableHandler GetOnDisableAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnDisableAsync()
        {
            return default(UniTask);
        }

        public UniTask OnDisableAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncDisableTrigger()
        {
        }
    }
}
