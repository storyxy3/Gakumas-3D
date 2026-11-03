namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservablePointerUpTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerUpHandler
    {
        private Subject<PointerEventData> onPointerUp;
        void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerUpAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservablePointerUpTrigger()
        {
        }
    }
}
