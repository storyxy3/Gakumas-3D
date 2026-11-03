namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncPointerUpTrigger : AsyncTriggerBase<PointerEventData>, IPointerUpHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
        }

        public IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnPointerUpAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncPointerUpTrigger()
        {
        }
    }
}
