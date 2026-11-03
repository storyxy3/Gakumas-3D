namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class OfTypeObservable<TSource, TResult> : OperatorObservableBase<TResult>
    {
        private class OfType : OperatorObserverBase<TSource, TResult>
        {
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public OfType(IObserver<TResult> observer, IDisposable cancel) : base(default, default)
            {
            }

            public override void OnNext(TSource value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private readonly IObservable<TSource> source;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public OfTypeObservable(IObservable<TSource> source) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
