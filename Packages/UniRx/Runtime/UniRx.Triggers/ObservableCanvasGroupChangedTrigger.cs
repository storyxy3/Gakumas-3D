namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public class ObservableCanvasGroupChangedTrigger : ObservableTriggerBase
    {
        private Subject<Unit> onCanvasGroupChanged;
        private void OnCanvasGroupChanged()
        {
        }

        public IObservable<Unit> OnCanvasGroupChangedAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableCanvasGroupChangedTrigger()
        {
        }
    }
}
