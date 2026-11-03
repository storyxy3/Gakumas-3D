namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncDeselectTrigger : AsyncTriggerBase<BaseEventData>, IDeselectHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData)
        {
        }

        public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler()
        {
            return null;
        }

        public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<BaseEventData> OnDeselectAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<BaseEventData>);
        }

        public AsyncDeselectTrigger()
        {
        }
    }
}
