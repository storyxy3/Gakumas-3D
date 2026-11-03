namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;

    internal class ImmediateReturnObservable<T> : IObservable<T>, IOptimizedObservable<T>
    {
        private readonly T value;
        public ImmediateReturnObservable(T value)
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
    }
}
