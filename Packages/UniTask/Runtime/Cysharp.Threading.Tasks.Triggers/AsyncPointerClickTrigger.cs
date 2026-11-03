namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncPointerClickTrigger : AsyncTriggerBase<PointerEventData>, IPointerClickHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData)
        {
        }

        public IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnPointerClickAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncPointerClickTrigger()
        {
        }
    }
}
