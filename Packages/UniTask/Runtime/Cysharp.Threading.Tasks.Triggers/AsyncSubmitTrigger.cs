namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncSubmitTrigger : AsyncTriggerBase<BaseEventData>, ISubmitHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData)
        {
        }

        public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler()
        {
            return null;
        }

        public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<BaseEventData> OnSubmitAsync()
        {
            return default(UniTask<BaseEventData>);
        }

        public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<BaseEventData>);
        }

        public AsyncSubmitTrigger()
        {
        }
    }
}
