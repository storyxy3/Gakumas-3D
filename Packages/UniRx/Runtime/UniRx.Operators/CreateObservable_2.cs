namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class CreateObservable<T, TState> : OperatorObservableBase<T>
    {
        private class Create : OperatorObserverBase<T, T>
        {
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Create(IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private readonly TState state;
        private readonly Func<TState, IObserver<T>, IDisposable> subscribe;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public CreateObservable(TState state, Func<TState, IObserver<T>, IDisposable> subscribe) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
