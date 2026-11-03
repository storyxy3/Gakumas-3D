namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableScrollTrigger : ObservableTriggerBase, IEventSystemHandler, IScrollHandler
    {
        private Subject<PointerEventData> onScroll;
        void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnScrollAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableScrollTrigger()
        {
        }
    }
}
