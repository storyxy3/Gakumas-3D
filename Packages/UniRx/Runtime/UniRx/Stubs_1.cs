namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    internal static class Stubs<T>
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public _003C_003Ec()
            {
            }

            internal void _003C_002Ecctor_003Eb__3_0(T t)
            {
            }

            internal T _003C_002Ecctor_003Eb__3_1(T t)
            {
                return default(T);
            }

            internal void _003C_002Ecctor_003Eb__3_2(Exception ex, T _)
            {
            }
        }

        public static readonly Action<T> Ignore;
        public static readonly Func<T, T> Identity;
        public static readonly Action<Exception, T> Throw;
    }
}
