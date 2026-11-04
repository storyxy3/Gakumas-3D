using global::System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Runtime.CompilerServices;

public static class FasterLinq
{
    public class SelectArray<TSource, TResult> : IEnumerable<TResult>, IEnumerable
    {
        private readonly TSource[] _source;
        private readonly Func<TSource, TResult> _selector;
        public SelectArray(TSource[] source, Func<TSource, TResult> selector)
        {
            _source = source;
            _selector = selector;
        }

        public TResult[] ToArray()
        {
            var result = new TResult[_source.Length];
            for (int i = 0; i < _source.Length; i++) result[i] = _selector(_source[i]);
            return result;
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
            return System.Linq.Enumerable.Select(System.Linq.Enumerable.AsEnumerable(_source), _selector).GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class SelectList<TSource, TResult> : IEnumerable<TResult>, IEnumerable
    {
        private readonly List<TSource> _source;
        private readonly Func<TSource, TResult> _selector;
        public SelectList(List<TSource> source, Func<TSource, TResult> selector)
        {
            _source = source;
            _selector = selector;
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

    [CompilerGenerated]
    private sealed class _003C_003Ec__DisplayClass4_0<TSource, TMiddle, TResult>
    {
        public Func<TMiddle, TResult> selector2;
        public Func<TSource, TMiddle> selector1;
        public _003C_003Ec__DisplayClass4_0()
        {
        }

        internal TResult _003CCombineSelectors_003Eb__0(TSource x)
        {
            return default(TResult);
        }
    }

    public static SelectArray<TSource, TResult> Select<TSource, TResult>(this TSource[] source, Func<TSource, TResult> selector)
    {
        return new SelectArray<TSource, TResult>(source, selector);
    }

    public static SelectList<TSource, TResult> Select<TSource, TResult>(this List<TSource> source, Func<TSource, TResult> selector)
    {
        return new SelectList<TSource, TResult>(source, selector);
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
