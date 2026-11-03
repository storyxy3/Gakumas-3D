namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;

    public static class ObserveExtensions
    {
        [CompilerGenerated]
        private sealed class _003CEmptyEnumerator_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
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
            public _003CEmptyEnumerator_003Ed__3(int _003C_003E1__state)
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

        [CompilerGenerated]
        private sealed class _003CPublishPocoValueChanged_003Ed__4<TSource, TProperty> : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public TProperty firstValue;
            public WeakReference sourceReference;
            public Func<TSource, TProperty> propertySelector;
            public IObserver<TProperty> observer;
            public IEqualityComparer<TProperty> comparer;
            public CancellationToken cancellationToken;
            private TProperty _003CprevValue_003E5__2;
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
            public _003CPublishPocoValueChanged_003Ed__4(int _003C_003E1__state)
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

        [CompilerGenerated]
        private sealed class _003CPublishUnityObjectValueChanged_003Ed__5<TSource, TProperty> : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public TProperty firstValue;
            public UnityEngine.Object unityObject;
            public bool fastDestroyCheck;
            public Func<TSource, TProperty> propertySelector;
            public IObserver<TProperty> observer;
            public IEqualityComparer<TProperty> comparer;
            public CancellationToken cancellationToken;
            private TProperty _003CprevValue_003E5__2;
            private TSource _003Csource_003E5__3;
            private ObservableDestroyTrigger _003CdestroyTrigger_003E5__4;
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
            public _003CPublishUnityObjectValueChanged_003Ed__5(int _003C_003E1__state)
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

        public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType = FrameCountType.Update, bool fastDestroyCheck = false)
            where TSource : class
        {
            return null;
        }

        public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType, IEqualityComparer<TProperty> comparer, bool fastDestroyCheck)
            where TSource : class
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CEmptyEnumerator_003Ed__3))]
        private static IEnumerator EmptyEnumerator()
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CPublishPocoValueChanged_003Ed__4<, >))]
        private static IEnumerator PublishPocoValueChanged<TSource, TProperty>(WeakReference sourceReference, TProperty firstValue, Func<TSource, TProperty> propertySelector, IEqualityComparer<TProperty> comparer, IObserver<TProperty> observer, CancellationToken cancellationToken)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CPublishUnityObjectValueChanged_003Ed__5<, >))]
        private static IEnumerator PublishUnityObjectValueChanged<TSource, TProperty>(UnityEngine.Object unityObject, TProperty firstValue, Func<TSource, TProperty> propertySelector, IEqualityComparer<TProperty> comparer, IObserver<TProperty> observer, CancellationToken cancellationToken, bool fastDestroyCheck)
        {
            return null;
        }

        private static ObservableDestroyTrigger GetOrAddDestroyTrigger(GameObject go)
        {
            return null;
        }
    }
}
