namespace UniRx.Operators
{
    using global::System;
    using global::UniRx.Operators;

    internal class FirstObservable<T> : OperatorObservableBase<T>
    {
        private class First : OperatorObserverBase<T, T>
        {
            private readonly FirstObservable<T> parent;
            private bool notPublished;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public First(FirstObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private class First_ : OperatorObserverBase<T, T>
        {
            private readonly FirstObservable<T> parent;
            private bool notPublished;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public First_(FirstObservable<T> parent, IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        private readonly IObservable<T> source;
        private readonly bool useDefault;
        private readonly Func<T, bool> predicate;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public FirstObservable(IObservable<T> source, bool useDefault) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
