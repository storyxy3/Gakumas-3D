namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class FromEventObservable : OperatorObservableBase<Unit>
    {
        private class FromEvent : IDisposable
        {
            private readonly FromEventObservable parent;
            private readonly IObserver<Unit> observer;
            private Action handler;
            public FromEvent(FromEventObservable parent, IObserver<Unit> observer)
            {
            }

            public bool Register()
            {
                return default(bool);
            }

            private void OnNext()
            {
            }

            public void Dispose()
            {
            }
        }

        private readonly Action<Action> addHandler;
        private readonly Action<Action> removeHandler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public FromEventObservable(Action<Action> addHandler, Action<Action> removeHandler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
