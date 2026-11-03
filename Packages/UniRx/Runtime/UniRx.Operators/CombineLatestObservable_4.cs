namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class CombineLatestObservable<T1, T2, T3, TR> : OperatorObservableBase<TR>
    {
        private class CombineLatest : NthCombineLatestObserverBase<TR>
        {
            private readonly CombineLatestObservable<T1, T2, T3, TR> parent;
            private readonly object gate;
            private CombineLatestObserver<T1> c1;
            private CombineLatestObserver<T2> c2;
            private CombineLatestObserver<T3> c3;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public CombineLatest(int length, CombineLatestObservable<T1, T2, T3, TR> parent, IObserver<TR> observer, IDisposable cancel) : base(default, default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            public override TR GetResult()
            {
                return default(TR);
            }

            public override void OnNext(TR value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private IObservable<T1> source1;
        private IObservable<T2> source2;
        private IObservable<T3> source3;
        private CombineLatestFunc<T1, T2, T3, TR> resultSelector;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public CombineLatestObservable(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, CombineLatestFunc<T1, T2, T3, TR> resultSelector) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
