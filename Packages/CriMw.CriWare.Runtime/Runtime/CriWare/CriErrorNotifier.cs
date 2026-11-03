namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::AOT;
    using global::CriWare;

    public static class CriErrorNotifier
    {
        public delegate void Callback(string message);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray);
        private static class NativeMethod
        {
            [PreserveSig]
            internal static extern void criErr_SetCallback(ErrorCallbackFunc callback);
            [PreserveSig]
            internal static extern void criErr_SetCallback(IntPtr callback);
            [PreserveSig]
            internal static extern IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2);
        }

        [CompilerGenerated]
        private static Callback m__onCallbackThreadUnsafe;
        private static object objectLock;
        private static event Callback _onCallbackThreadUnsafe
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public static event Callback OnCallbackThreadUnsafe
        {
            add
            {
            }

            remove
            {
            }
        }

        public static bool IsRegistered(Callback target)
        {
            return default(bool);
        }

        public static void CallEvent(string message)
        {
        }

        public static void SetCallbackNative(IntPtr errorCallback)
        {
        }

        internal static void SetCallbackNative(ErrorCallbackFunc errorCallback)
        {
        }

        internal static ErrorCallbackFunc GetManagedPluginFunc()
        {
            return null;
        }

        [MonoPInvokeCallback(typeof(ErrorCallbackFunc))]
        private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray)
        {
        }
    }
}
