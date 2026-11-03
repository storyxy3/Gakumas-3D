namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncPointerExitTrigger : AsyncTriggerBase<PointerEventData>, IPointerExitHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData)
        {
        }

        public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnPointerExitAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncPointerExitTrigger()
        {
        }
    }
}
