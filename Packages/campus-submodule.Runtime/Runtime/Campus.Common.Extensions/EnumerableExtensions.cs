namespace Campus.Common.Extensions
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.Extensions;

    public static class EnumerableExtensions
    {
        private class CompareSelector<T, TKey> : IEqualityComparer<T>
        {
            private readonly Func<T, TKey> _selector;
            public CompareSelector(Func<T, TKey> selector)
            {
                _selector = selector;
            }

            public bool Equals(T x, T y)
            {
                return _selector(x).Equals(_selector(y));
            }

            public int GetHashCode(T obj)
            {
                return _selector(obj).GetHashCode();
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__7<T>
        {
            public static readonly _003C_003Ec__7<T> _003C_003E9 = new _003C_003Ec__7<T>();
            public static Func<T, string> _003C_003E9__7_0;
            public _003C_003Ec__7()
            {
            }

            internal string _003CRandom_003Eb__7_0(T _)
            {
                return Guid.NewGuid().ToString();
            }
        }

        private static Random _rand = new Random();
        public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selector)
        {
            return Enumerable.Distinct(source, new CompareSelector<T, TKey>(selector));
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T, int> action)
        {
            int index = 0;
            foreach (var item in enumerable)
            {
                action?.Invoke(item, index);
                index++;
            }
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable) action?.Invoke(item);
        }

        public static int FindIndex<T>(this IEnumerable<T> items, Predicate<T> match)
        {
            int index = 0;
            foreach (var item in items)
            {
                if (match(item))
                    return index;
                index++;
            }
            return -1;
        }

        public static IEnumerable<T> Random<T>(this IEnumerable<T> items, int count)
        {
            return Enumerable.Take(Enumerable.OrderBy(items, _003C_003Ec__7<T>._003C_003E9__7_0 ??= _003C_003Ec__7<T>._003C_003E9._003CRandom_003Eb__7_0), count);
        }

        public static T MinBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return Enumerable.FirstOrDefault(Enumerable.OrderBy(enumerable, keySelector));
        }

        public static T MaxBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return Enumerable.FirstOrDefault(Enumerable.OrderByDescending(enumerable, keySelector));
        }
    }
}
