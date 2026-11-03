namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class StartWithObservable<T> : OperatorObservableBase<T>
    {
        private class StartWith : OperatorObserverBase<T, T>
        {
            private readonly StartWithObservable<T> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public StartWith(StartWithObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private readonly IObservable<T> source;
        private readonly T value;
        private readonly Func<T> valueFactory;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public StartWithObservable(IObservable<T> source, T value) : base(default)
        {
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public StartWithObservable(IObservable<T> source, Func<T> valueFactory) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
