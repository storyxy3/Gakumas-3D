namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncPointerDownTrigger : AsyncTriggerBase<PointerEventData>, IPointerDownHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
        }

        public IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnPointerDownAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncPointerDownTrigger()
        {
        }
    }
}
