namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx.Operators;

    internal class DistinctUntilChangedObservable<T> : OperatorObservableBase<T>
    {
        private class DistinctUntilChanged : OperatorObserverBase<T, T>
        {
            private readonly DistinctUntilChangedObservable<T> parent;
            private bool isFirst;
            private T prevKey;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public DistinctUntilChanged(DistinctUntilChangedObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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
        private readonly IEqualityComparer<T> comparer;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public DistinctUntilChangedObservable(IObservable<T> source, IEqualityComparer<T> comparer) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
