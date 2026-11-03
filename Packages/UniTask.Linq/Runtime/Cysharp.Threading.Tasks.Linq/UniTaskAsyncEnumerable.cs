namespace Cysharp.Threading.Tasks.Linq
{
    using global::System;
    using global::Cysharp.Threading.Tasks;

    public static class UniTaskAsyncEnumerable
    {
        public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext)
        {
            return null;
        }

        public static IUniTaskAsyncEnumerable<TSource> ToUniTaskAsyncEnumerable<TSource>(this IObservable<TSource> source)
        {
            return null;
        }
    }
}
