namespace Campus.Common.Extensions
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.Extensions;

    public static class EnumerableExtensions
    {
        private class CompareSelector<T, TKey> : IEqualityComparer<T>
        {
            private readonly Func<T, TKey> _selector;
            public CompareSelector(Func<T, TKey> selector)
            {
            }

            public bool Equals(T x, T y)
            {
                return default(bool);
            }

            public int GetHashCode(T obj)
            {
                return default(int);
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__7<T>
        {
            public static readonly _003C_003Ec__7<T> _003C_003E9;
            public static Func<T, string> _003C_003E9__7_0;
            public _003C_003Ec__7()
            {
            }

            internal string _003CRandom_003Eb__7_0(T _)
            {
                return null;
            }
        }

        private static Random _rand;
        public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selector)
        {
            return null;
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T, int> action)
        {
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable) action?.Invoke(item);
        }

        public static int FindIndex<T>(this IEnumerable<T> items, Predicate<T> match)
        {
            return default(int);
        }

        public static IEnumerable<T> Random<T>(this IEnumerable<T> items, int count)
        {
            return null;
        }

        public static T MinBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return default(T);
        }

        public static T MaxBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return default(T);
        }
    }
}
