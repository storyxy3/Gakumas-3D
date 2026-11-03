namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncRectTransformRemovedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnRectTransformRemoved()
        {
        }

        public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnRectTransformRemovedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncRectTransformRemovedTrigger()
        {
        }
    }
}
