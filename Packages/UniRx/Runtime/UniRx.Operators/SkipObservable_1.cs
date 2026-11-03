namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class SkipObservable<T> : OperatorObservableBase<T>
    {
        private class Skip : OperatorObserverBase<T, T>
        {
            private int remaining;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Skip(SkipObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private class Skip_ : OperatorObserverBase<T, T>
        {
            private readonly SkipObservable<T> parent;
            private bool open;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Skip_(SkipObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            private void Tick()
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
        private readonly TimeSpan duration;
        internal readonly IScheduler scheduler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public SkipObservable(IObservable<T> source, int count) : base(default)
        {
        }

        public IObservable<T> Combine(int count)
        {
            return null;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
