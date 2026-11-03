namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservablePointerDownTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerDownHandler
    {
        private Subject<PointerEventData> onPointerDown;
        void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerDownAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservablePointerDownTrigger()
        {
        }
    }
}
