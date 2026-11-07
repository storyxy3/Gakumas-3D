namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExAsrRack : CriDisposable
    {
        public enum StreamType
        {
            Music,
            Alarm,
            Dtmf,
            Notification,
            Ring,
            System,
            VoiceCall
        }

        public struct PlatformConfigAndroid : IPlatformConfig
        {
            public StreamType streamType;
            public bool enableSpatialAudio;
            public bool IsSupportedPlatform()
            {
                return default(bool);
            }

            public static PlatformConfigAndroid Default()
            {
                return default(PlatformConfigAndroid);
            }
        }

        protected class NativeMethods
        {
            [PreserveSig]
            internal static extern void criAtomExAsrRack_SetDefaultConfig_ANDROID_Macro(ref PlatformConfigAndroid config);
            public NativeMethods()
            {
            }
        }

        public struct Config
        {
            public float serverFrequency;
            public int numBuses;
            public int outputChannels;
            public CriAtom.SpeakerMapping speakerMapping;
            public int outputSamplingRate;
            public CriAtomEx.SoundRendererType soundRendererType;
            public int outputRackId;
            public IntPtr context;
            public static Config Default()
            {
                return default(Config);
            }
        }

        public struct PlatformConfig
        {
            public byte reserved;
        }

        public struct PerformanceInfo
        {
            public uint processCount;
            public uint lastProcessTime;
            public uint maxProcessTime;
            public uint averageProcessTime;
            public uint lastProcessInterval;
            public uint maxProcessInterval;
            public uint averageProcessInterval;
            public uint lastProcessSamples;
            public uint maxProcessSamples;
            public uint averageProcessSamples;
        }

        public interface IPlatformConfig
        {
            bool IsSupportedPlatform();
        }

        [CompilerGenerated]
        private static readonly CriAtomExAsrRack _003CDefault_003Ek__BackingField;
        public const int defaultRackId = 0;
        public const int IllegalRackId = -1;
        private int _rackId;
        private bool hasExistingRackId;
        public int rackId
        {
            get
            {
                return default(int);
            }
        }

        public static CriAtomExAsrRack Default
        {
            [CompilerGenerated]
            get
            {
                return _003CDefault_003Ek__BackingField;
            }
        }

        [Obsolete("Use CriAtomExAsrRack.Config.Default")]
        public static Config defaultConfig
        {
            get
            {
                return default(Config);
            }
        }

        public static void SetDefaultConfig_ANDROID(ref PlatformConfigAndroid platformConfig)
        {
        }

        public CriAtomExAsrRack(Config config, IPlatformConfig platformConfig)
        {
        }

        [Obsolete("Use CriAtomExAsrRack.CriAtomExAsrRack(Config config, IPlatformConfig platformConfig)")]
        public CriAtomExAsrRack(Config config, PlatformConfig platformConfig)
        {
        }

        public CriAtomExAsrRack(int existingRackId)
        {
        }

        public void AttachDspBusSetting(string settingName)
        {
        }

        public void DetachDspBusSetting()
        {
        }

        public void ApplyDspBusSnapshot(string snapshotName, int timeMs)
        {
        }

        public static string GetAppliedDspBusSnapshotName(int rackId)
        {
            return null;
        }

        public string GetAppliedDspBusSnapshotName()
        {
            return null;
        }

        public PerformanceInfo GetPerformanceInfo()
        {
            return default(PerformanceInfo);
        }

        public static PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0)
        {
            return default(PerformanceInfo);
        }

        public void ResetPerformanceMonitor()
        {
        }

        public static void ResetPerformanceMonitorByRackId(int rackId = 0)
        {
        }

        public static void SetAisacControl(int rackId, string controlName, float value)
        {
        }

        public static void SetAisacControl(int rackId, int controlId, float value)
        {
        }

        public static void SetDefaultConfig(ref Config config)
        {
        }

        public override void Dispose()
        {
        }

        public static void GetNumRenderedSamples(int rackId, out long numSamples, out int samplingRate)
        {
            throw null;
        }

        public static int GetAmbisonicRackId()
        {
            return default(int);
        }

        public static int GetChannelBasedAudioRackId()
        {
            return default(int);
        }

        public static int GetObjectBasedAudioRackId()
        {
            return default(int);
        }

        public static int GetPassThroughRackId()
        {
            return default(int);
        }

        ~CriAtomExAsrRack()
        {
        }

        [PreserveSig]
        private static extern int criAtomExAsrRack_Create(in Config config, IntPtr work, int work_size);
        [PreserveSig]
        private static extern int CRIWARE5FFADED2([In] ref Config config, [In] ref PlatformConfig platformConfig);
        [PreserveSig]
        private static extern void criAtomExAsrRack_Destroy(int rackId);
        [PreserveSig]
        private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize);
        [PreserveSig]
        private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId);
        [PreserveSig]
        private static extern IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId);
        [PreserveSig]
        private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs);
        [PreserveSig]
        private static extern void CRIWARED5DF3C60(ref Config config);
        [PreserveSig]
        private static extern void criAtomExAsrRack_GetPerformanceInfo(int rackId, out PerformanceInfo perfInfo);
        [PreserveSig]
        private static extern void criAtomExAsrRack_ResetPerformanceMonitor(int rackId);
        [PreserveSig]
        private static extern void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value);
        [PreserveSig]
        private static extern void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value);
        [PreserveSig]
        private static extern void criAtomExAsrRack_GetNumRenderedSamples(int rack_id, ref long num_samples, ref int sampling_rate);
        [PreserveSig]
        private static extern int criAtomExAsrRack_GetAmbisonicRackId();
        [PreserveSig]
        private static extern int criAtomExAsrRack_GetChannelBasedAudioRackId();
        [PreserveSig]
        private static extern int criAtomExAsrRack_GetObjectBasedAudioRackId();
        [PreserveSig]
        private static extern int criAtomExAsrRack_GetPassThroughRackId();
    }
}
