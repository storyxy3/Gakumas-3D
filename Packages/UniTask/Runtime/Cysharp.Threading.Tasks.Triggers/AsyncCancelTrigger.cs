namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncCancelTrigger : AsyncTriggerBase<BaseEventData>, ICancelHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData)
        {
        }

        public IAsyncOnCancelHandler GetOnCancelAsyncHandler()
        {
            return null;
        }

        public IAsyncOnCancelHandler GetOnCancelAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<BaseEventData> OnCancelAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<BaseEventData>);
        }

        public AsyncCancelTrigger()
        {
        }
    }
}
