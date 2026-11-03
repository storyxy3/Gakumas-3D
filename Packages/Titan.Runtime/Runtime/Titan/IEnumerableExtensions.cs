namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;

    internal static class IEnumerableExtensions
    {
        private static class IdentityFunction<TElement>
        {
            public static Func<TElement, TElement> Instance
            {
                get
                {
                    return null;
                }
            }
        }

        public static Dictionary<TKey, TValue> ToDictionarySafe<T, TKey, TValue>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector, Func<T, TValue> valueSelector)
        {
            return null;
        }

        public static Dictionary<TKey, T> ToDictionarySafe<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return null;
        }
    }
}
