namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class FromEventObservable<TDelegate> : OperatorObservableBase<Unit>
    {
        private class FromEvent : IDisposable
        {
            private readonly FromEventObservable<TDelegate> parent;
            private readonly IObserver<Unit> observer;
            private TDelegate handler;
            public FromEvent(FromEventObservable<TDelegate> parent, IObserver<Unit> observer)
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

        private readonly Func<Action, TDelegate> conversion;
        private readonly Action<TDelegate> addHandler;
        private readonly Action<TDelegate> removeHandler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public FromEventObservable(Func<Action, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
