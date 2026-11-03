namespace UniRx.Operators
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;
    using global::UniRx.Operators;

    public abstract class OperatorObservableBase<T> : IObservable<T>, IOptimizedObservable<T>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public SingleAssignmentDisposable subscription;
            public OperatorObservableBase<T> _003C_003E4__this;
            public IObserver<T> observer;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal void _003CSubscribe_003Eb__0()
            {
            }
        }

        private readonly bool isRequiredSubscribeOnCurrentThread;
        public OperatorObservableBase(bool isRequiredSubscribeOnCurrentThread)
        {
        }

        public bool IsRequiredSubscribeOnCurrentThread()
        {
            return default(bool);
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return null;
        }

        protected abstract IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel);
    }
}
