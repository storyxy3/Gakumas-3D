namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExMic : CriDisposable
    {
        public struct DeviceInfo
        {
            public string deviceId;
            public string deviceName;
            public uint deviceFlags;
            public int maxChannels;
            public int maxSamplingRate;
        }

        public struct Config
        {
            public string deviceId;
            public uint flags;
            public int numChannels;
            public int samplingRate;
            public uint frameSize;
            public uint bufferingTime;
            public IntPtr context;
            public static Config Default
            {
                get
                {
                    return default(Config);
                }
            }
        }

        public class Effect
        {
            [CompilerGenerated]
            private IntPtr _003Chandle_003Ek__BackingField;
            [CompilerGenerated]
            private IntPtr _003CafxInstance_003Ek__BackingField;
            public IntPtr handle
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

            public IntPtr afxInstance
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

            public Effect(IntPtr handle, IntPtr afxInstance)
            {
            }
        }

        private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic.";
        private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData.";
        private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic.";
        private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized.";
        private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized.";
        [CompilerGenerated]
        private static bool _003CisInitialized_003Ek__BackingField;
        private IntPtr handle;
        private IntPtr[] bufferPointers;
        private GCHandle[] gcHandles;
        private CriAudioWriteStream outputWriteStream;
        private static int _initializationCount;
        public static bool isInitialized
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public static void InitializeModule()
        {
        }

        public static void FinalizeModule()
        {
        }

        public static void SetupOutputCategoryForMic_IOS(bool enable)
        {
        }

        public static DeviceInfo[] GetDevices()
        {
            return null;
        }

        public static int GetNumDevices()
        {
            return default(int);
        }

        public static DeviceInfo? GetDefaultDevice()
        {
            return null;
        }

        public static bool IsFormatSupported(Config config)
        {
            return default(bool);
        }

        public static CriAtomExMic Create([Optional] Config? config)
        {
            return null;
        }

        private CriAtomExMic(IntPtr handle)
        {
        }

        ~CriAtomExMic()
        {
        }

        public override void Dispose()
        {
        }

        private void Dispose(bool disposing)
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public int GetNumChannels()
        {
            return default(int);
        }

        public int GetSamplingRate()
        {
            return default(int);
        }

        public uint GetNumBufferedSamples()
        {
            return default(uint);
        }

        [Obsolete("Use CriWare.CriAtomExMic.GetNumBufferedSamples")]
        public uint GetNumBufferredSamples()
        {
            return default(uint);
        }

        public bool IsAvailable()
        {
            return default(bool);
        }

        public uint ReadData(float[] bufferMono)
        {
            return default(uint);
        }

        public uint ReadData(float[] bufferMono, uint numToRead)
        {
            return default(uint);
        }

        public uint ReadData(float[] bufferL, float[] bufferR)
        {
            return default(uint);
        }

        public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead)
        {
            return default(uint);
        }

        public uint ReadData(float[][] buffers)
        {
            return default(uint);
        }

        public uint ReadData(float[][] buffers, uint numToRead)
        {
            return default(uint);
        }

        public void SetOutputWriteStream(CriAudioWriteStream stream)
        {
        }

        public CriAudioReadStream GetOutputReadStream()
        {
            return null;
        }

        public Effect AttachEffect(IntPtr afxInterface, float[] configParameters)
        {
            return null;
        }

        public void DetachEffect(Effect effect)
        {
        }

        public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue)
        {
        }

        public float GetEffectParameter(Effect effect, int parameterIndex)
        {
            return default(float);
        }

        public void SetEffectBypass(Effect effect, bool bypass)
        {
        }

        public void UpdateEffectParameters(Effect effect)
        {
        }

        private uint InternalReadDataFromBufferPointers(uint numToRead)
        {
            return default(uint);
        }

        private void InternalClearBuffers()
        {
        }

        [PreserveSig]
        private static extern void criAtomMicUnity_Initialize();
        [PreserveSig]
        private static extern void criAtomMicUnity_Finalize();
        [PreserveSig]
        private static extern int criAtomMic_GetNumDevices();
        [PreserveSig]
        private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info);
        [PreserveSig]
        private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info);
        [PreserveSig]
        private static extern bool criAtomMic_IsFormatSupported([In] ref Config config);
        [PreserveSig]
        private static extern IntPtr criAtomMic_Create([In] ref Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomMic_Destroy(IntPtr mic);
        [PreserveSig]
        private static extern void criAtomMic_Start(IntPtr mic);
        [PreserveSig]
        private static extern void criAtomMic_Stop(IntPtr mic);
        [PreserveSig]
        private static extern int criAtomMic_GetNumChannels(IntPtr mic);
        [PreserveSig]
        private static extern int criAtomMic_GetSamplingRate(IntPtr mic);
        [PreserveSig]
        private static extern uint criAtomMic_GetNumBufferedSamples(IntPtr mic);
        [PreserveSig]
        private static extern bool criAtomMic_IsAvailable(IntPtr mic);
        [PreserveSig]
        private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples);
        [PreserveSig]
        private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr);
        [PreserveSig]
        private static extern IntPtr criAtomMic_GetOutputReadStream();
        [PreserveSig]
        private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters);
        [PreserveSig]
        private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size);
        [PreserveSig]
        private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect);
        [PreserveSig]
        private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect);
        [PreserveSig]
        private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass);
        [PreserveSig]
        private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value);
        [PreserveSig]
        private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index);
        [PreserveSig]
        private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect);
    }
}
