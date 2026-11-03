namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public class ObservableRectTransformTrigger : ObservableTriggerBase
    {
        private Subject<Unit> onRectTransformDimensionsChange;
        private Subject<Unit> onRectTransformRemoved;
        private void OnRectTransformDimensionsChange()
        {
        }

        public IObservable<Unit> OnRectTransformDimensionsChangeAsObservable()
        {
            return null;
        }

        private void OnRectTransformRemoved()
        {
        }

        public IObservable<Unit> OnRectTransformRemovedAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableRectTransformTrigger()
        {
        }
    }
}
