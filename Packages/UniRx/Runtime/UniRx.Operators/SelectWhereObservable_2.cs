namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class SelectWhereObservable<T, TR> : OperatorObservableBase<TR>
    {
        private class SelectWhere : OperatorObserverBase<T, TR>
        {
            private readonly SelectWhereObservable<T, TR> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public SelectWhere(SelectWhereObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) : base(default, default)
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
        private readonly Func<TR, bool> predicate;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public SelectWhereObservable(IObservable<T> source, Func<T, TR> selector, Func<TR, bool> predicate) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
