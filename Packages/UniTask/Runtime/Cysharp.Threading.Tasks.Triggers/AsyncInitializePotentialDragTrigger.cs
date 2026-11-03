namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncInitializePotentialDragTrigger : AsyncTriggerBase<PointerEventData>, IInitializePotentialDragHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
        {
        }

        public IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler()
        {
            return null;
        }

        public IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnInitializePotentialDragAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncInitializePotentialDragTrigger()
        {
        }
    }
}
