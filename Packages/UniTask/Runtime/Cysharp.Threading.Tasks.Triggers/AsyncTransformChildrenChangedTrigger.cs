namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncTransformChildrenChangedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnTransformChildrenChanged()
        {
        }

        public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnTransformChildrenChangedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncTransformChildrenChangedTrigger()
        {
        }
    }
}
