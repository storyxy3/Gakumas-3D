namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public class ObservableFixedUpdateTrigger : ObservableTriggerBase
    {
        private Subject<Unit> fixedUpdate;
        private void FixedUpdate()
        {
        }

        public IObservable<Unit> FixedUpdateAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableFixedUpdateTrigger()
        {
        }
    }
}
