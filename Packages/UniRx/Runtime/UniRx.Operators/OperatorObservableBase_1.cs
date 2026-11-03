namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;

    public abstract class OperatorObservableBase<T> : IObservable<T>, IOptimizedObservable<T>
    {
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
