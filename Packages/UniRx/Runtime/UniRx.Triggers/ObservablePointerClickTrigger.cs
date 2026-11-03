namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservablePointerClickTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerClickHandler
    {
        private Subject<PointerEventData> onPointerClick;
        void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerClickAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservablePointerClickTrigger()
        {
        }
    }
}
