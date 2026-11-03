namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class PairwiseObservable<T> : OperatorObservableBase<Pair<T>>
    {
        private class Pairwise : OperatorObserverBase<T, Pair<T>>
        {
            private T prev;
            private bool isFirst;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Pairwise(IObserver<Pair<T>> observer, IDisposable cancel) : base(default, default)
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
        public PairwiseObservable(IObservable<T> source) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<Pair<T>> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
