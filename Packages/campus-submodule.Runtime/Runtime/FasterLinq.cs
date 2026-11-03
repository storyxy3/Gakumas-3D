using global::System;
using global::System.Collections;
using global::System.Collections.Generic;

public static class FasterLinq
{
    public class SelectArray<TSource, TResult> : IEnumerable<TResult>, IEnumerable
    {
        private readonly TSource[] _source;
        private readonly Func<TSource, TResult> _selector;
        public SelectArray(TSource[] source, Func<TSource, TResult> selector)
        {
        }

        public TResult[] ToArray()
        {
            return null;
        }

        public List<TResult> ToList()
        {
            return null;
        }

        public SelectArray<TSource, TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
        {
            return null;
        }

        public IEnumerator<TResult> GetEnumerator()
        {
            return null;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }

    public class SelectList<TSource, TResult> : IEnumerable<TResult>, IEnumerable
    {
        private readonly List<TSource> _source;
        private readonly Func<TSource, TResult> _selector;
        public SelectList(List<TSource> source, Func<TSource, TResult> selector)
        {
        }

        public TResult[] ToArray()
        {
            return null;
        }

        public List<TResult> ToList()
        {
            return null;
        }

        public SelectList<TSource, TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
        {
            return null;
        }

        public IEnumerator<TResult> GetEnumerator()
        {
            return null;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }

    public static SelectArray<TSource, TResult> Select<TSource, TResult>(this TSource[] source, Func<TSource, TResult> selector)
    {
        return null;
    }

    public static SelectList<TSource, TResult> Select<TSource, TResult>(this List<TSource> source, Func<TSource, TResult> selector)
    {
        return null;
    }

    public static int Count<TSource>(this TSource[] source)
    {
        return default(int);
    }

    public static int Count<TSource>(this List<TSource> source)
    {
        return default(int);
    }

    private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
    {
        return null;
    }
}
