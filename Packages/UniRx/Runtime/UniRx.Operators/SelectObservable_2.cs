namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class SelectObservable<T, TR> : OperatorObservableBase<TR>, ISelect<TR>
    {
        private class Select : OperatorObserverBase<T, TR>
        {
            private readonly SelectObservable<T, TR> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Select(SelectObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) : base(default, default)
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

        private class Select_ : OperatorObserverBase<T, TR>
        {
            private readonly SelectObservable<T, TR> parent;
            private int index;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Select_(SelectObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) : base(default, default)
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
        private readonly Func<T, TR> selector;
        private readonly Func<T, int, TR> selectorWithIndex;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public SelectObservable(IObservable<T> source, Func<T, TR> selector) : base(default)
        {
        }

        public IObservable<TR> CombinePredicate(Func<TR, bool> predicate)
        {
            return null;
        }

        protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
