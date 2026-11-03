namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableSubmitTrigger : ObservableTriggerBase, IEventSystemHandler, ISubmitHandler
    {
        private Subject<BaseEventData> onSubmit;
        void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnSubmitAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableSubmitTrigger()
        {
        }
    }
}
