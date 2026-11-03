namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableDeselectTrigger : ObservableTriggerBase, IEventSystemHandler, IDeselectHandler
    {
        private Subject<BaseEventData> onDeselect;
        void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnDeselectAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableDeselectTrigger()
        {
        }
    }
}
