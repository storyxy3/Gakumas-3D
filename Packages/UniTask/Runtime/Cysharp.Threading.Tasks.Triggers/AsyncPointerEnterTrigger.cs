namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncPointerEnterTrigger : AsyncTriggerBase<PointerEventData>, IPointerEnterHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
        {
        }

        public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnPointerEnterAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncPointerEnterTrigger()
        {
        }
    }
}
