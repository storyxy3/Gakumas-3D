namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncSelectTrigger : AsyncTriggerBase<BaseEventData>, ISelectHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData)
        {
        }

        public IAsyncOnSelectHandler GetOnSelectAsyncHandler()
        {
            return null;
        }

        public IAsyncOnSelectHandler GetOnSelectAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<BaseEventData> OnSelectAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<BaseEventData>);
        }

        public AsyncSelectTrigger()
        {
        }
    }
}
