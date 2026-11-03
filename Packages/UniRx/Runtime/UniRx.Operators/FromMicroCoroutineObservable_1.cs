namespace UniRx.Operators
{
    using global::System;
    using global::System.Collections;
    using global::System.Threading;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class FromMicroCoroutineObservable<T> : OperatorObservableBase<T>
    {
        private class FromMicroCoroutine : OperatorObserverBase<T, T>
        {
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public FromMicroCoroutine(IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private readonly Func<IObserver<T>, CancellationToken, IEnumerator> coroutine;
        private readonly FrameCountType frameCountType;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public FromMicroCoroutineObservable(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine, FrameCountType frameCountType) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
