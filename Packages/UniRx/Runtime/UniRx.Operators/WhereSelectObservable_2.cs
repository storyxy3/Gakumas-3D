namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class WhereSelectObservable<T, TR> : OperatorObservableBase<TR>
    {
        private class WhereSelect : OperatorObserverBase<T, TR>
        {
            private readonly WhereSelectObservable<T, TR> parent;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public WhereSelect(WhereSelectObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) : base(default, default)
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
        private readonly Func<T, TR> selector;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public WhereSelectObservable(IObservable<T> source, Func<T, bool> predicate, Func<T, TR> selector) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
