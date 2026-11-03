namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    public abstract class AsyncTriggerBase<T> : MonoBehaviour, IUniTaskAsyncEnumerable<T>
    {
        private sealed class AsyncTriggerEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, ITriggerHandler<T>
        {
            private static Action<object> cancellationCallback;
            private readonly AsyncTriggerBase<T> parent;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration registration;
            private bool called;
            private bool isDisposed;
            [CompilerGenerated]
            private T _003CCurrent_003Ek__BackingField;
            [CompilerGenerated]
            private ITriggerHandler<T> _003CCysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EPrev_003Ek__BackingField;
            [CompilerGenerated]
            private ITriggerHandler<T> _003CCysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002ENext_003Ek__BackingField;
            public T Current
            {
                [CompilerGenerated]
                get
                {
                    return default(T);
                }

                [CompilerGenerated]
                private set
                {
                }
            }

            ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                set
                {
                }
            }

            ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
            {
                [CompilerGenerated]
                get
                {
                    return null;
                }

                [CompilerGenerated]
                set
                {
                }
            }

            public AsyncTriggerEnumerator(AsyncTriggerBase<T> parent, CancellationToken cancellationToken)
            {
            }

            public void OnNext(T value)
            {
            }

            public void OnCompleted()
            {
            }

            private static void CancellationCallback(object state)
            {
            }

            public UniTask<bool> MoveNextAsync()
            {
                return default(UniTask<bool>);
            }

            public UniTask DisposeAsync()
            {
                return default(UniTask);
            }
        }

        private class AwakeMonitor : IPlayerLoopItem
        {
            private readonly AsyncTriggerBase<T> trigger;
            public AwakeMonitor(AsyncTriggerBase<T> trigger)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }
        }

        private TriggerEvent<T> triggerEvent;
        protected internal bool calledAwake;
        protected internal bool calledDestroy;
        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        internal void AddHandler(ITriggerHandler<T> handler)
        {
        }

        internal void RemoveHandler(ITriggerHandler<T> handler)
        {
        }

        protected void RaiseEvent(T value)
        {
        }

        public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator([Optional] CancellationToken cancellationToken)
        {
            return null;
        }

        protected AsyncTriggerBase()
        {
        }
    }
}
