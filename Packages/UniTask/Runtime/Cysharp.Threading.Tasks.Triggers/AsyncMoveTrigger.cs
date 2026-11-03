namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public sealed class AsyncMoveTrigger : AsyncTriggerBase<AxisEventData>, IMoveHandler, IEventSystemHandler
    {
        void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData)
        {
        }

        public IAsyncOnMoveHandler GetOnMoveAsyncHandler()
        {
            return null;
        }

        public IAsyncOnMoveHandler GetOnMoveAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<AxisEventData> OnMoveAsync()
        {
            return default(UniTask<AxisEventData>);
        }

        public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<AxisEventData>);
        }

        public AsyncMoveTrigger()
        {
        }
    }
}
