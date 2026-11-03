namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class AsObservableObservable<T> : OperatorObservableBase<T>
    {
        private class AsObservable : OperatorObserverBase<T, T>
        {
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public AsObservable(IObserver<T> observer, IDisposable cancel) : base(default, default)
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
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public AsObservableObservable(IObservable<T> source) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
