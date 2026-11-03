namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableDragTrigger : ObservableTriggerBase, IEventSystemHandler, IDragHandler
    {
        private Subject<PointerEventData> onDrag;
        void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnDragAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableDragTrigger()
        {
        }
    }
}
