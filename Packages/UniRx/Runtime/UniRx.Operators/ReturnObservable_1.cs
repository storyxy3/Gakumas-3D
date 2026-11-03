namespace UniRx.Operators
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class ReturnObservable<T> : OperatorObservableBase<T>
    {
        private class Return : OperatorObserverBase<T, T>
        {
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Return(IObserver<T> observer, IDisposable cancel) : base(default, default)
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

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public IObserver<T> observer;
            public ReturnObservable<T> _003C_003E4__this;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal void _003CSubscribeCore_003Eb__0()
            {
            }
        }

        private readonly T value;
        private readonly IScheduler scheduler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public ReturnObservable(T value, IScheduler scheduler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
