namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncEnableTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnEnable()
        {
        }

        public IAsyncOnEnableHandler GetOnEnableAsyncHandler()
        {
            return null;
        }

        public IAsyncOnEnableHandler GetOnEnableAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnEnableAsync()
        {
            return default(UniTask);
        }

        public UniTask OnEnableAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncEnableTrigger()
        {
        }
    }
}
