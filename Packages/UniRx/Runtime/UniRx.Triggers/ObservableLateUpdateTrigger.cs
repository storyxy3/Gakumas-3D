namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public class ObservableLateUpdateTrigger : ObservableTriggerBase
    {
        private Subject<Unit> lateUpdate;
        private void LateUpdate()
        {
        }

        public IObservable<Unit> LateUpdateAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableLateUpdateTrigger()
        {
        }
    }
}
