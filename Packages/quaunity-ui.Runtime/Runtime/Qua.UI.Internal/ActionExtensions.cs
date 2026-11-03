namespace Qua.UI.Internal
{
    using global::System;
    using global::UnityEngine.Events;

    internal static class ActionExtensions
    {
        public static void Call(this Action action)
        {
        }

        public static void Call<T1>(this Action<T1> action, T1 param1)
        {
        }

        public static void Call<T1>(this UnityEvent<T1> action, T1 param1)
        {
        }
    }
}
