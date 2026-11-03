namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class FromEventObservable_<T> : OperatorObservableBase<T>
    {
        private class FromEvent : IDisposable
        {
            private readonly FromEventObservable_<T> parent;
            private readonly IObserver<T> observer;
            private Action<T> handler;
            public FromEvent(FromEventObservable_<T> parent, IObserver<T> observer)
            {
            }

            public bool Register()
            {
                return default(bool);
            }

            private void OnNext(T value)
            {
            }

            public void Dispose()
            {
            }
        }

        private readonly Action<Action<T>> addHandler;
        private readonly Action<Action<T>> removeHandler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public FromEventObservable_(Action<Action<T>> addHandler, Action<Action<T>> removeHandler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
