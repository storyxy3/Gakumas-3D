namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class FromEventObservable<TDelegate, TEventArgs> : OperatorObservableBase<TEventArgs>
    {
        private class FromEvent : IDisposable
        {
            private readonly FromEventObservable<TDelegate, TEventArgs> parent;
            private readonly IObserver<TEventArgs> observer;
            private TDelegate handler;
            public FromEvent(FromEventObservable<TDelegate, TEventArgs> parent, IObserver<TEventArgs> observer)
            {
            }

            public bool Register()
            {
                return default(bool);
            }

            private void OnNext(TEventArgs args)
            {
            }

            public void Dispose()
            {
            }
        }

        private readonly Func<Action<TEventArgs>, TDelegate> conversion;
        private readonly Action<TDelegate> addHandler;
        private readonly Action<TDelegate> removeHandler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public FromEventObservable(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<TEventArgs> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
