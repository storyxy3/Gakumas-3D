namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx.Operators;

    internal class DistinctUntilChangedObservable<T, TKey> : OperatorObservableBase<T>
    {
        private class DistinctUntilChanged : OperatorObserverBase<T, T>
        {
            private readonly DistinctUntilChangedObservable<T, TKey> parent;
            private bool isFirst;
            private TKey prevKey;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public DistinctUntilChanged(DistinctUntilChangedObservable<T, TKey> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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
        private readonly IEqualityComparer<TKey> comparer;
        private readonly Func<T, TKey> keySelector;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public DistinctUntilChangedObservable(IObservable<T> source, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
