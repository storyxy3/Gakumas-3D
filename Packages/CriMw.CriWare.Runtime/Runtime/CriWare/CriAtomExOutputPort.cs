namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExOutputPort : CriDisposable
    {
        public enum Type
        {
            Audio,
            Vibration
        }

        public struct Config
        {
            public string name;
            public Type type;
            public uint maxIgnoredCategories;
            public static Config Default()
            {
                return default(Config);
            }
        }

        private class NativeMethods
        {
            [PreserveSig]
            internal static extern int criAtomExOutputPort_CalculateWorkSize([In] Config config);
            [PreserveSig]
            internal static extern IntPtr criAtomExOutputPort_Create(ref Config config, IntPtr work, int workSize);
            [PreserveSig]
            internal static extern void criAtomExOutputPort_Destroy(IntPtr outputPort);
            [PreserveSig]
            internal static extern void criAtomExOutputPort_SetAsrRackId(IntPtr outputPort, int rackId);
            [PreserveSig]
            internal static extern void criAtomExOutputPort_SetVibrationChannelLevel(IntPtr outputPort, int channel, float level);
            [PreserveSig]
            internal static extern void criAtomExOutputPort_SetMonauralMix(IntPtr outputPort, bool monauralMix);
            [PreserveSig]
            internal static extern bool criAtomExOutputPort_IsDestroyable(IntPtr outputPort);
            public NativeMethods()
            {
            }
        }

        public const uint MaxNameLength = 64u;
        [CompilerGenerated]
        private IntPtr _003CNativeHandle_003Ek__BackingField;
        private bool hasExistingNativeHandle;
        public bool isAvailable
        {
            get
            {
                return default(bool);
            }
        }

        internal IntPtr NativeHandle
        {
            [CompilerGenerated]
            get
            {
                return default(IntPtr);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int CalculateWorkSize(Config config)
        {
            return default(int);
        }

        public CriAtomExOutputPort(Config config)
        {
        }

        internal CriAtomExOutputPort(IntPtr existingNativeHandle)
        {
        }

        ~CriAtomExOutputPort()
        {
        }

        public override void Dispose()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void SetAsrRackId(int rackId)
        {
        }

        public void SetVibrationChannelLevel(int channel, float level)
        {
        }

        public void SetMonauralMix(bool monauralMix)
        {
        }

        public bool IsDestroyable()
        {
            return default(bool);
        }
    }
}
