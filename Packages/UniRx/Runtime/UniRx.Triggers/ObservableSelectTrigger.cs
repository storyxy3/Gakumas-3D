namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableSelectTrigger : ObservableTriggerBase, IEventSystemHandler, ISelectHandler
    {
        private Subject<BaseEventData> onSelect;
        void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnSelectAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableSelectTrigger()
        {
        }
    }
}
