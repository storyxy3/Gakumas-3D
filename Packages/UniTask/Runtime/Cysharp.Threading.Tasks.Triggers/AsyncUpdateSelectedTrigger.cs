namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncUpdateSelectedTrigger : AsyncTriggerBase<BaseEventData>, IUpdateSelectedHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
        {
        }

        public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<BaseEventData> OnUpdateSelectedAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<BaseEventData>);
        }

        public AsyncUpdateSelectedTrigger()
        {
        }
    }
}
