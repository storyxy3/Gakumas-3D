namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableMoveTrigger : ObservableTriggerBase, IEventSystemHandler, IMoveHandler
    {
        private Subject<AxisEventData> onMove;
        void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData)
        {
        }

        public IObservable<AxisEventData> OnMoveAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableMoveTrigger()
        {
        }
    }
}
