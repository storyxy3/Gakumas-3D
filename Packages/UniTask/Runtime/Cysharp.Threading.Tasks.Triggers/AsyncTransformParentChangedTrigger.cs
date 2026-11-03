namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnTransformParentChanged()
        {
        }

        public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnTransformParentChangedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncTransformParentChangedTrigger()
        {
        }
    }
}
