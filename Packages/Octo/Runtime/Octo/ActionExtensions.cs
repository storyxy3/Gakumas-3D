namespace Octo
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Events;

    internal static class ActionExtensions
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass11_0<T1>
        {
            public Action<T1> action;
            public _003C_003Ec__DisplayClass11_0()
            {
            }

            internal void _003CTrySafeWrap_003Eb__0(T1 param1)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0<T1, T2>
        {
            public Action<T1, T2> action;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal void _003CTrySafeWrap_003Eb__0(T1 param1, T2 param2)
            {
            }
        }

        public static void Call<T1>(this Action<T1> action, T1 param1)
        {
        }

        public static void Call<T1, T2>(this Action<T1, T2> action, T1 param1, T2 param2)
        {
        }

        public static void Call<T1, T2>(this UnityEvent<T1, T2> action, T1 param1, T2 param2)
        {
        }

        public static void TrySafeInvoke<T1>(this Action<T1> action, T1 param1)
        {
        }

        public static void TrySafeInvoke<T1, T2>(this Action<T1, T2> action, T1 param1, T2 param2)
        {
        }

        public static void TrySafeInvoke<T1, T2, T3>(this Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3)
        {
        }

        public static Action<T1> TrySafeWrap<T1>(this Action<T1> action)
        {
            return null;
        }

        public static Action<T1, T2> TrySafeWrap<T1, T2>(this Action<T1, T2> action)
        {
            return null;
        }
    }
}
