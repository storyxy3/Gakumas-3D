namespace UniRx
{
    using global::System;

    public static class OptimizedObservableExtensions
    {
        public static bool IsRequiredSubscribeOnCurrentThread<T>(this IObservable<T> source)
        {
            return default(bool);
        }
    }
}
