namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncScrollTrigger : AsyncTriggerBase<PointerEventData>, IScrollHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData)
        {
        }

        public IAsyncOnScrollHandler GetOnScrollAsyncHandler()
        {
            return null;
        }

        public IAsyncOnScrollHandler GetOnScrollAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnScrollAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncScrollTrigger()
        {
        }
    }
}
