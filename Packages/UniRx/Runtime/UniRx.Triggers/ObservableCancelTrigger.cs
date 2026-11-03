namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableCancelTrigger : ObservableTriggerBase, IEventSystemHandler, ICancelHandler
    {
        private Subject<BaseEventData> onCancel;
        void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnCancelAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableCancelTrigger()
        {
        }
    }
}
