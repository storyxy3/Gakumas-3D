namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class ConcatObservable<T> : OperatorObservableBase<T>
    {
        private class Concat : OperatorObserverBase<T, T>
        {
            private readonly ConcatObservable<T> parent;
            private readonly object gate;
            private bool isDisposed;
            private IEnumerator<IObservable<T>> e;
            private SerialDisposable subscription;
            private Action nextSelf;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Concat(ConcatObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
            {
            }

            public IDisposable Run()
            {
                return null;
            }

            private void RecursiveRun(Action self)
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

        private readonly IEnumerable<IObservable<T>> sources;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public ConcatObservable(IEnumerable<IObservable<T>> sources) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
