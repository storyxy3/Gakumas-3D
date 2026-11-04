using System;
using System.Collections.Concurrent;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriWareErrorHandler (TypeDefIndex 31874), added by CP.CRI.CriCore.Setup next to the initializer.
    [AddComponentMenu("CRIWARE/Error Handler")]
    public class CriWareErrorHandler : CriMonoBehaviour
    {
        public delegate void Callback(string message);

        public bool enableDebugPrintOnTerminal;
        public bool enableForceCrashOnError;
        public bool dontDestroyOnLoad = true;
        public static readonly string logPrefix = "[CRIWARE]";
        private static Callback _onCallback = null;
        [Obsolete("CriWareErrorHandler.callback is deprecated. Use CriWareErrorHandler.OnCallback event", false)]
        public static Callback callback = null;
        public uint messageBufferCounts = 8;
        private ConcurrentQueue<string> unThreadSafeMessages = new ConcurrentQueue<string>();
        private static int initializationCount = 0;

        public static string errorMessage { get; set; }

        private void Awake()
        {
            if (initializationCount++ != 0)
            {
                Destroy(this);
                return;
            }
            if (!CriErrorNotifier.IsRegistered(HandleMessage))
                CriErrorNotifier.OnCallbackThreadUnsafe += HandleMessage;
            // Haruki: on a child (CriCore.Setup's CRIWARE object) Unity ignores it with a warning; the root persists.
            if (dontDestroyOnLoad && transform.parent == null)
                DontDestroyOnLoad(transform.gameObject);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            RegisterErrorCallback();
            if (!CriErrorNotifier.IsRegistered(HandleMessage))
                CriErrorNotifier.OnCallbackThreadUnsafe += HandleMessage;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            if (CriErrorNotifier.IsRegistered(HandleMessage))
                CriErrorNotifier.OnCallbackThreadUnsafe -= HandleMessage;
        }

        public override void CriInternalUpdate()
        {
            DequeueErrorMessages();
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void OnDestroy()
        {
            if (--initializationCount != 0)
                return;
            if (IsEnableNativePrintMessageFunc())
            {
                CriErrorNotifier.SetCallbackNative(IntPtr.Zero);
                CriErrorNotifier.SetCallbackNative(CriErrorNotifier.GetManagedPluginFunc());
            }
            if (CriErrorNotifier.IsRegistered(HandleMessage))
                CriErrorNotifier.OnCallbackThreadUnsafe -= HandleMessage;
        }

#pragma warning disable 618
        private static bool IsEnableNativePrintMessageFunc()
        {
            if (Application.isEditor)
                return false;
            return _onCallback == null && callback == null;
        }

        private static void RegisterErrorCallback()
        {
            var enableNativePrint = IsEnableNativePrintMessageFunc();
            CriErrorNotifier.SetCallbackNative(IntPtr.Zero);
            if (enableNativePrint)
                CriErrorNotifier.SetCallbackNative(NativeMethod.CRIWAREC0ED7C62());
            else
                CriErrorNotifier.SetCallbackNative(CriErrorNotifier.GetManagedPluginFunc());
        }

        private void DequeueErrorMessages()
        {
            while (unThreadSafeMessages.Count != 0)
            {
                if (unThreadSafeMessages.TryDequeue(out var message))
                {
                    if (_onCallback != null)
                        _onCallback(message);
                    if (callback != null)
                        callback(message);
                }
            }
        }

        private void HandleMessage(string errmsg)
        {
            if (errmsg == null)
                return;
            if (_onCallback == null && callback == null)
                OutputDefaultLog(errmsg);
            else
                unThreadSafeMessages.Enqueue(errmsg);
            if (enableForceCrashOnError)
                UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.Abort);
        }
#pragma warning restore 618

        private static void OutputDefaultLog(string errmsg)
        {
            if (errmsg.StartsWith("E"))
                Debug.LogError(logPrefix + " Error:" + errmsg);
            else if (errmsg.StartsWith("W"))
                Debug.LogWarning(logPrefix + " Warning:" + errmsg);
            else
                Debug.Log(logPrefix + errmsg);
        }

        private static class NativeMethod
        {
            public static IntPtr CRIWAREC0ED7C62() => CriWareNative.Native.CRIWAREC0ED7C62();
        }
    }
}
