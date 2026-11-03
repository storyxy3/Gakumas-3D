namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableBeginDragTrigger : ObservableTriggerBase, IEventSystemHandler, IBeginDragHandler
    {
        private Subject<PointerEventData> onBeginDrag;
        void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnBeginDragAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableBeginDragTrigger()
        {
        }
    }
}
