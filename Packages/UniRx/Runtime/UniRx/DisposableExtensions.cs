namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    public static class DisposableExtensions
    {
        [CompilerGenerated]
        private sealed class _003CMonitorTriggerHealth_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public ObservableDestroyTrigger trigger;
            public GameObject targetGameObject;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CMonitorTriggerHealth_003Ed__2(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        public static T AddTo<T>(this T disposable, ICollection<IDisposable> container)
            where T : IDisposable
        {
            return default(T);
        }

        public static T AddTo<T>(this T disposable, GameObject gameObject)
            where T : IDisposable
        {
            return default(T);
        }

        [IteratorStateMachine(typeof(_003CMonitorTriggerHealth_003Ed__2))]
        private static IEnumerator MonitorTriggerHealth(ObservableDestroyTrigger trigger, GameObject targetGameObject)
        {
            return null;
        }

        public static T AddTo<T>(this T disposable, Component gameObjectComponent)
            where T : IDisposable
        {
            return default(T);
        }
    }
}
