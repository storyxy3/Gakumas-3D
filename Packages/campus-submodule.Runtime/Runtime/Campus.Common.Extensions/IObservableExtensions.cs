namespace Campus.Common.Extensions
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.Extensions;
    using global::UniRx.Operators;

    public static class IObservableExtensions
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__0<T1, T2>
        {
            public static readonly _003C_003Ec__0<T1, T2> _003C_003E9;
            public static Func<T1, T2, (T1 a, T2 b)> _003C_003E9__0_0;
            public _003C_003Ec__0()
            {
            }

            internal (T1, T2) _003CCombineLatest_003Eb__0_0(T1 a, T2 b)
            {
                return default((T1, T2));
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__1<T1, T2, T3>
        {
            public static readonly _003C_003Ec__1<T1, T2, T3> _003C_003E9;
            public static CombineLatestFunc<T1, T2, T3, (T1 a, T2 b, T3 c)> _003C_003E9__1_0;
            public _003C_003Ec__1()
            {
            }

            internal (T1, T2, T3) _003CCombineLatest_003Eb__1_0(T1 a, T2 b, T3 c)
            {
                return default((T1, T2, T3));
            }
        }

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
