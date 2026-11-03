namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class RefCountObservable<T> : OperatorObservableBase<T>
    {
        private class RefCount : OperatorObserverBase<T, T>
        {
            private readonly RefCountObservable<T> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public RefCount(RefCountObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private readonly IConnectableObservable<T> source;
        private readonly object gate;
        private int refCount;
        private IDisposable connection;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public RefCountObservable(IConnectableObservable<T> source) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
