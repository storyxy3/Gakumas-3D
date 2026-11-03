namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class WhereObservable<T> : OperatorObservableBase<T>
    {
        private class Where : OperatorObserverBase<T, T>
        {
            private readonly WhereObservable<T> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Where(WhereObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private class Where_ : OperatorObserverBase<T, T>
        {
            private readonly WhereObservable<T> parent;
            private int index;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Where_(WhereObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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
        private readonly Func<T, bool> predicate;
        private readonly Func<T, int, bool> predicateWithIndex;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public WhereObservable(IObservable<T> source, Func<T, bool> predicate) : base(default)
        {
        }

        public IObservable<T> CombinePredicate(Func<T, bool> combinePredicate)
        {
            return null;
        }

        public IObservable<TR> CombineSelector<TR>(Func<T, TR> selector)
        {
            return null;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
