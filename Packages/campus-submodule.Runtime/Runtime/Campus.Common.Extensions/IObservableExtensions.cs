namespace Campus.Common.Extensions
{
    using global::System;

    public static class IObservableExtensions
    {
        public static IObservable<(T1, T2)> CombineLatest<T1, T2>(this IObservable<T1> source1, IObservable<T2> source2)
        {
            return null;
        }

        public static IObservable<(T1, T2, T3)> CombineLatest<T1, T2, T3>(this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3)
        {
            return null;
        }
    }
}
