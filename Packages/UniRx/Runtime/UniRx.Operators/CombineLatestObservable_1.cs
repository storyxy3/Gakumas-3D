namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx.Operators;

    internal class CombineLatestObservable<T> : OperatorObservableBase<IList<T>>
    {
        private class CombineLatest : OperatorObserverBase<IList<T>, IList<T>>
        {
            private class CombineLatestObserver : IObserver<T>
            {
                private readonly CombineLatest parent;
                private readonly int index;
                public CombineLatestObserver(CombineLatest parent, int index)
                {
                }

                public void OnNext(T value)
                {
                }

                public void OnError(Exception ex)
                {
                }

                public void OnCompleted()
                {
                }
            }

            private readonly CombineLatestObservable<T> parent;
            private readonly object gate;
            private int length;
            private T[] values;
            private bool[] isStarted;
            private bool[] isCompleted;
            private bool isAllValueStarted;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public CombineLatest(CombineLatestObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            private void Publish(int index)
            {
            }

            public override void OnNext(IList<T> value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private readonly IObservable<T>[] sources;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public CombineLatestObservable(IObservable<T>[] sources) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<IList<T>> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
