using System;
using System.Runtime.InteropServices;
using AOT;

namespace CriWare
{
    // CriWare.CriErrorNotifier (TypeDefIndex 31878): the native error callback and its managed listeners.
    public static class CriErrorNotifier
    {
        public delegate void Callback(string message);

        // Public here (internal in the game) because ICriWareNativeBackend.criErr_SetCallback takes it.
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray);

        private static Callback _onCallbackThreadUnsafe = null;
        private static object objectLock = new object();

        // 官方 7.0.0 iOS add_OnCallbackThreadUnsafe 0x44D34B0：加锁后，若当前没有任何订阅者（委托为 null 或调用列表为空），
        // 先 criErr_SetCallback(null) 再 criErr_SetCallback(new ErrorCallbackFunc(ErrorCallbackFromNative))（即内联的
        // GetManagedPluginFunc，两次都走委托重载 0x44D4D30），然后才把 value 加入委托。
        // remove_OnCallbackThreadUnsafe 0x44D3BC8：移除后若已没有订阅者，criErr_SetCallback(null) 注销原生回调。
        // 原生回调是单槽位（后设覆盖先设），CriWareErrorHandler.Awake 先 add、OnEnable 再 RegisterErrorCallback 覆盖成
        // 原生打印或托管回调，与官方调用顺序一致，不会重复注册。
        public static event Callback OnCallbackThreadUnsafe
        {
            add
            {
                lock (objectLock)
                {
                    if (_onCallbackThreadUnsafe == null || _onCallbackThreadUnsafe.GetInvocationList().Length == 0)
                    {
                        NativeMethod.criErr_SetCallback((ErrorCallbackFunc)null);
                        NativeMethod.criErr_SetCallback(GetManagedPluginFunc());
                    }
                    _onCallbackThreadUnsafe += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    _onCallbackThreadUnsafe -= value;
                    if (_onCallbackThreadUnsafe == null || _onCallbackThreadUnsafe.GetInvocationList().Length == 0)
                        NativeMethod.criErr_SetCallback((ErrorCallbackFunc)null);
                }
            }
        }

        public static bool IsRegistered(Callback target)
        {
            if (_onCallbackThreadUnsafe == null)
                return false;
            foreach (var registered in _onCallbackThreadUnsafe.GetInvocationList())
            {
                if ((Callback)registered == target)
                    return true;
            }
            return false;
        }

        public static void CallEvent(string message)
        {
            if (_onCallbackThreadUnsafe != null)
                _onCallbackThreadUnsafe(message);
        }

        public static void SetCallbackNative(IntPtr errorCallback)
        {
            NativeMethod.criErr_SetCallback(errorCallback);
        }

        internal static void SetCallbackNative(ErrorCallbackFunc errorCallback)
        {
            NativeMethod.criErr_SetCallback(errorCallback);
        }

        internal static ErrorCallbackFunc GetManagedPluginFunc()
        {
            return new ErrorCallbackFunc(ErrorCallbackFromNative);
        }

        [MonoPInvokeCallback(typeof(ErrorCallbackFunc))]
        private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray)
        {
            var message = Marshal.PtrToStringAnsi(NativeMethod.criErr_ConvertIdToMessage(errmsgPtr, p1, p2));
            CallEvent(message);
        }

        private static class NativeMethod
        {
            public static void criErr_SetCallback(IntPtr callback) => CriWareNative.Native.criErr_SetCallback(callback);
            public static void criErr_SetCallback(ErrorCallbackFunc callback) =>
                CriWareNative.Native.criErr_SetCallback(callback);
            public static IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2) =>
                CriWareNative.Native.criErr_ConvertIdToMessage(errmsgPtr, p1, p2);
        }
    }
}
