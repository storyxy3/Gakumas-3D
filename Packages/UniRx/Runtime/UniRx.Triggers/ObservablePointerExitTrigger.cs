namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservablePointerExitTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerExitHandler
    {
        private Subject<PointerEventData> onPointerExit;
        void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerExitAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservablePointerExitTrigger()
        {
        }
    }
}
