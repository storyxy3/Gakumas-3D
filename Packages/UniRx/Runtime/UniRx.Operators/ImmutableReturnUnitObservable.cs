namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class ImmutableReturnUnitObservable : IObservable<Unit>, IOptimizedObservable<Unit>
    {
        internal static ImmutableReturnUnitObservable Instance;
        private ImmutableReturnUnitObservable()
        {
        }

        public bool IsRequiredSubscribeOnCurrentThread()
        {
            return default(bool);
        }

        public IDisposable Subscribe(IObserver<Unit> observer)
        {
            return null;
        }
    }
}
