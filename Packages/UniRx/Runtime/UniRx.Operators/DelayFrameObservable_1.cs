namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class DelayFrameObservable<T> : OperatorObservableBase<T>
    {
        private class DelayFrame : OperatorObserverBase<T, T>
        {
            [CompilerGenerated]
            private sealed class _003CDrainQueue_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public DelayFrame _003C_003E4__this;
                public int frameCount;
                public Queue<T> q;
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
                public _003CDrainQueue_003Ed__14(int _003C_003E1__state)
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

            private readonly DelayFrameObservable<T> parent;
            private readonly object gate;
            private readonly QueuePool pool;
            private int runningEnumeratorCount;
            private bool readyDrainEnumerator;
            private bool running;
            private IDisposable sourceSubscription;
            private Queue<T> currentQueueReference;
            private bool calledCompleted;
            private bool hasError;
            private Exception error;
            private BooleanDisposable cancelationToken;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public DelayFrame(DelayFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            [IteratorStateMachine(typeof(DelayFrameObservable<>.DelayFrame._003CDrainQueue_003Ed__14))]
            private IEnumerator DrainQueue(Queue<T> q, int frameCount)
            {
                return null;
            }

            public override void OnNext(T value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private class QueuePool
        {
            private readonly object gate;
            private readonly Queue<Queue<T>> pool;
            public Queue<T> Get()
            {
                return null;
            }

            public void Return(Queue<T> q)
            {
            }

            public QueuePool()
            {
            }
        }

        private readonly IObservable<T> source;
        private readonly int frameCount;
        private readonly FrameCountType frameCountType;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public DelayFrameObservable(IObservable<T> source, int frameCount, FrameCountType frameCountType) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
