namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncBeginDragTrigger : AsyncTriggerBase<PointerEventData>, IBeginDragHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
        {
        }

        public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler()
        {
            return null;
        }

        public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnBeginDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncBeginDragTrigger()
        {
        }
    }
}
