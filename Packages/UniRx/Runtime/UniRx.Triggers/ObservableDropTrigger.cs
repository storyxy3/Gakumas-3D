namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableDropTrigger : ObservableTriggerBase, IEventSystemHandler, IDropHandler
    {
        private Subject<PointerEventData> onDrop;
        void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnDropAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableDropTrigger()
        {
        }
    }
}
