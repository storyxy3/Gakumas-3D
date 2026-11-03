namespace UniRx.Triggers
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public class ObservableDestroyTrigger : MonoBehaviour
    {
        private bool calledDestroy;
        private Subject<Unit> onDestroy;
        private CompositeDisposable disposablesOnDestroy;
        [CompilerGenerated]
        private bool _003CIsMonitoredActivate_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsActivated_003Ek__BackingField;
        [Obsolete("Internal Use.")]
        internal bool IsMonitoredActivate
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool IsActivated
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsCalledOnDestroy
        {
            get
            {
                return default(bool);
            }
        }

        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public IObservable<Unit> OnDestroyAsObservable()
        {
            return null;
        }

        public void ForceRaiseOnDestroy()
        {
        }

        public void AddDisposableOnDestroy(IDisposable disposable)
        {
        }

        public ObservableDestroyTrigger()
        {
        }
    }
}
