namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncEndDragTrigger : AsyncTriggerBase<PointerEventData>, IEndDragHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData)
        {
        }

        public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler()
        {
            return null;
        }

        public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnEndDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncEndDragTrigger()
        {
        }
    }
}
