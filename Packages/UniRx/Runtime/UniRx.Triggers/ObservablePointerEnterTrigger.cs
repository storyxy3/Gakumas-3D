namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservablePointerEnterTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerEnterHandler
    {
        private Subject<PointerEventData> onPointerEnter;
        void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerEnterAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservablePointerEnterTrigger()
        {
        }
    }
}
