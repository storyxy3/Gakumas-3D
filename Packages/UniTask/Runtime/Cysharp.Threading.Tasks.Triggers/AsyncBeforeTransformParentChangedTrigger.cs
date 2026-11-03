namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncBeforeTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnBeforeTransformParentChanged()
        {
        }

        public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnBeforeTransformParentChangedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncBeforeTransformParentChangedTrigger()
        {
        }
    }
}
