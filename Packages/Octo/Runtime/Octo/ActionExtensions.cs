namespace Octo
{
    using global::System;
    using global::UnityEngine.Events;

    internal static class ActionExtensions
    {
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
