namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class BufferObservable<T> : OperatorObservableBase<IList<T>>
    {
        private class Buffer : OperatorObserverBase<T, IList<T>>
        {
            private readonly BufferObservable<T> parent;
            private List<T> list;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Buffer(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
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

        private class Buffer_ : OperatorObserverBase<T, IList<T>>
        {
            private readonly BufferObservable<T> parent;
            private Queue<List<T>> q;
            private int index;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Buffer_(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
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

        private class BufferT : OperatorObserverBase<T, IList<T>>
        {
            private class Buffer : IObserver<long>
            {
                private BufferT parent;
                public Buffer(BufferT parent)
                {
                }

                public void OnNext(long value)
                {
                }

                public void OnError(Exception error)
                {
                }

                public void OnCompleted()
                {
                }
            }

            private static readonly T[] EmptyArray;
            private readonly BufferObservable<T> parent;
            private readonly object gate;
            private List<T> list;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public BufferT(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
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

        private class BufferTS : OperatorObserverBase<T, IList<T>>
        {
            private readonly BufferObservable<T> parent;
            private readonly object gate;
            private Queue<IList<T>> q;
            private TimeSpan totalTime;
            private TimeSpan nextShift;
            private TimeSpan nextSpan;
            private SerialDisposable timerD;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public BufferTS(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            private void CreateTimer()
            {
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

        private class BufferTC : OperatorObserverBase<T, IList<T>>
        {
            private static readonly T[] EmptyArray;
            private readonly BufferObservable<T> parent;
            private readonly object gate;
            private List<T> list;
            private long timerId;
            private SerialDisposable timerD;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public BufferTC(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            private void CreateTimer()
            {
            }

            private void OnNextTick(long currentTimerId)
            {
            }

            private void OnNextRecursive(long currentTimerId, Action<TimeSpan> self)
            {
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

        private readonly IObservable<T> source;
        private readonly int count;
        private readonly int skip;
        private readonly TimeSpan timeSpan;
        private readonly TimeSpan timeShift;
        private readonly IScheduler scheduler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public BufferObservable(IObservable<T> source, int count, int skip) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<IList<T>> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
