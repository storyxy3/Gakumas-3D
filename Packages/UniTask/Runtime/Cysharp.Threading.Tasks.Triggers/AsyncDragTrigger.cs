namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncDragTrigger : AsyncTriggerBase<PointerEventData>, IDragHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData)
        {
        }

        public IAsyncOnDragHandler GetOnDragAsyncHandler()
        {
            return null;
        }

        public IAsyncOnDragHandler GetOnDragAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncDragTrigger()
        {
        }
    }
}
