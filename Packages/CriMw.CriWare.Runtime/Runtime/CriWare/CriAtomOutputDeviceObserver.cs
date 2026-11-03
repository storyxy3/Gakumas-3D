namespace CriWare
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    public class CriAtomOutputDeviceObserver : CriMonoBehaviour
    {
        public enum OutputDeviceType
        {
            BuiltinSpeaker,
            WiredDevice,
            WirelessDevice
        }

        public delegate void DeviceConnectionChangeCallback(bool isConnected, OutputDeviceType deviceType);
        private static class UnsafeNativeMethods
        {
        }

        [CompilerGenerated]
        private sealed class _003CCoroutineForCheck_ANDROID_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CriAtomOutputDeviceObserver _003C_003E4__this;
            private float _003Ctime_003E5__2;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CCoroutineForCheck_ANDROID_003Ed__25(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        [SerializeField]
        private bool dontDestroyOnLoad;
        private bool lastIsConnected;
        private bool isConnected;
        private OutputDeviceType lastDeviceType;
        private OutputDeviceType deviceType;
        private static CriAtomOutputDeviceObserver instance;
        [CompilerGenerated]
        private static DeviceConnectionChangeCallback m__onDeviceConnectionChanged;
        private static AndroidJavaObject checker;
        public static bool IsDeviceConnected
        {
            get
            {
                return default(bool);
            }
        }

        public static OutputDeviceType DeviceType
        {
            get
            {
                return default(OutputDeviceType);
            }
        }

        public static event DeviceConnectionChangeCallback OnDeviceConnectionChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        private static event DeviceConnectionChangeCallback _onDeviceConnectionChanged
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

        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        private void CallbackFromObserver_ANDROID(string message)
        {
        }

        private void CheckOutputDevice_ANDROID()
        {
        }

        [IteratorStateMachine(typeof(_003CCoroutineForCheck_ANDROID_003Ed__25))]
        private IEnumerator CoroutineForCheck_ANDROID()
        {
            return null;
        }

        public CriAtomOutputDeviceObserver()
        {
        }
    }
}
