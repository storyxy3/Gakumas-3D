namespace CriWare
{
    using global::System;
    using global::System.Collections.Concurrent;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;
    using global::UnityEngine;

    [AddComponentMenu("CRIWARE/Error Handler")]
    public class CriWareErrorHandler : CriMonoBehaviour
    {
        public delegate void Callback(string message);
        private static class NativeMethod
        {
            [PreserveSig]
            internal static extern IntPtr CRIWARE91D8765C();
        }

        public bool enableDebugPrintOnTerminal;
        public bool enableForceCrashOnError;
        public bool dontDestroyOnLoad;
        [CompilerGenerated]
        private static string _003CerrorMessage_003Ek__BackingField;
        public static readonly string logPrefix;
        [CompilerGenerated]
        private static Callback m__onCallback;
        [Obsolete("CriWareErrorHandler.callback is deprecated. Use CriWareErrorHandler.OnCallback event", false)]
        public static Callback callback;
        public uint messageBufferCounts;
        private ConcurrentQueue<string> unThreadSafeMessages;
        private static bool _enableDebugPrintOnTerminal;
        private static int initializationCount;
        public static string errorMessage
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        private static event Callback _onCallback
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

        public static event Callback OnCallback
        {
            add
            {
            }

            remove
            {
            }
        }

        private void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void OnDestroy()
        {
        }

        private static bool IsEnableNativePrintMessageFunc()
        {
            return default(bool);
        }

        private static void RegisterErrorCallback()
        {
        }

        private void DequeueErrorMessages()
        {
        }

        private void HandleMessage(string errmsg)
        {
        }

        private static void OutputDefaultLog(string errmsg)
        {
        }

        public CriWareErrorHandler()
        {
        }
    }
}
