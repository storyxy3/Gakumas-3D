namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableEndDragTrigger : ObservableTriggerBase, IEventSystemHandler, IEndDragHandler
    {
        private Subject<PointerEventData> onEndDrag;
        void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnEndDragAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableEndDragTrigger()
        {
        }
    }
}
