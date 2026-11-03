namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class ImmutableEmptyObservable<T> : IObservable<T>, IOptimizedObservable<T>
    {
        internal static ImmutableEmptyObservable<T> Instance;
        private ImmutableEmptyObservable()
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
