namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableInitializePotentialDragTrigger : ObservableTriggerBase, IEventSystemHandler, IInitializePotentialDragHandler
    {
        private Subject<PointerEventData> onInitializePotentialDrag;
        void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnInitializePotentialDragAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableInitializePotentialDragTrigger()
        {
        }
    }
}
