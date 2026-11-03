namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncDropTrigger : AsyncTriggerBase<PointerEventData>, IDropHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData)
        {
        }

        public IAsyncOnDropHandler GetOnDropAsyncHandler()
        {
            return null;
        }

        public IAsyncOnDropHandler GetOnDropAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<PointerEventData> OnDropAsync()
        {
            return default(UniTask<PointerEventData>);
        }

        public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<PointerEventData>);
        }

        public AsyncDropTrigger()
        {
        }
    }
}
