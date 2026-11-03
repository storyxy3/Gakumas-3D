namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Titan;

    internal static class IEnumerableExtensions
    {
        private static class IdentityFunction<TElement>
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Func<TElement, TElement> _003C_003E9__1_0;
                public _003C_003Ec()
                {
                }

                internal TElement _003Cget_Instance_003Eb__1_0(TElement x)
                {
                    return default(TElement);
                }
            }

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
