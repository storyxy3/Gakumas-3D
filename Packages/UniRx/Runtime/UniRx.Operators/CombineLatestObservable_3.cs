namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class CombineLatestObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult>
    {
        private class CombineLatest : OperatorObserverBase<TResult, TResult>
        {
            private class LeftObserver : IObserver<TLeft>
            {
                private readonly CombineLatest parent;
                public LeftObserver(CombineLatest parent)
                {
                }

                public void OnNext(TLeft value)
                {
                }

                public void OnError(Exception error)
                {
                }

                public void OnCompleted()
                {
                }
            }

            private class RightObserver : IObserver<TRight>
            {
                private readonly CombineLatest parent;
                public RightObserver(CombineLatest parent)
                {
                }

                public void OnNext(TRight value)
                {
                }

                public void OnError(Exception error)
                {
                }

                public void OnCompleted()
                {
                }
            }

            private readonly CombineLatestObservable<TLeft, TRight, TResult> parent;
            private readonly object gate;
            private TLeft leftValue;
            private bool leftStarted;
            private bool leftCompleted;
            private TRight rightValue;
            private bool rightStarted;
            private bool rightCompleted;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public CombineLatest(CombineLatestObservable<TLeft, TRight, TResult> parent, IObserver<TResult> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            public void Publish()
            {
            }

            public override void OnNext(TResult value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private readonly IObservable<TLeft> left;
        private readonly IObservable<TRight> right;
        private readonly Func<TLeft, TRight, TResult> selector;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public CombineLatestObservable(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
