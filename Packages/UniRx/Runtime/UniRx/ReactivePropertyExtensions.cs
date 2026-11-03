namespace UniRx
{
    using global::System;
    using global::UniRx;

    public static class ReactivePropertyExtensions
    {
        private static readonly Action<object> Callback;
        public static IReadOnlyReactiveProperty<T> ToReactiveProperty<T>(this IObservable<T> source)
        {
            return null;
        }

        public static ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(this IObservable<T> source)
        {
            return null;
        }

        private static void CancelCallback(object state)
        {
        }

        public static ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(this IObservable<T> source)
        {
            return null;
        }

        public static ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(this IObservable<T> source, T initialValue)
        {
            return null;
        }

        public static IObservable<T> SkipLatestValueOnSubscribe<T>(this IReadOnlyReactiveProperty<T> source)
        {
            return null;
        }
    }
}
