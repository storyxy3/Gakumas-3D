namespace Campus.Common.Extensions
{
    using global::System;
    using global::UniRx;

    public static class ReactiveCollectionExtensions
    {
        public static IObservable<IReadOnlyReactiveCollection<T>> ObserveCollectionChanged<T>(this IReadOnlyReactiveCollection<T> self, bool notifyCurrentCollection = false)
        {
            return null;
        }
    }
}
