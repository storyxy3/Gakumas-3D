using System;

namespace CriWare
{
    // CriWare.CriFsConfig (TypeDefIndex 31879).
    [Serializable]
    public class CriFsConfig
    {
        public const int defaultAndroidDeviceReadBitrate = 50000000;
        public int numberOfLoaders = 16;
        public int numberOfBinders = 8;
        public int numberOfInstallers = 2;
        public int installBufferSize = CriFsPlugin.defaultInstallBufferSize / 1024;
        public int maxPath = 256;
        public string userAgentString = "";
        public bool minimizeFileDescriptorUsage;
        public bool enableCrcCheck;
        public int androidDeviceReadBitrate = 50000000;
    }

    // CriWare.CriAtomConfig (TypeDefIndex 31895).
    [Serializable]
    public partial class CriAtomConfig
    {
        public enum InGamePreviewSwitchMode
        {
            Disable = 0,
            Enable = 1,
            FollowBuildSetting = 2,
            Default = 3
        }

        public enum LinuxOutput
        {
            Default = 0,
            PulseAudio = 1,
            ALSA = 2
        }

        [Serializable]
        public class StandardVoicePoolConfig
        {
            public int memoryVoices = 16;
            public int streamingVoices = 8;
        }

        [Serializable]
        public class HcaMxVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
        }

        [Serializable]
        public class InGamePreviewConfig
        {
            public int maxPreviewObjects = 200;
            public int communicationBufferSize = 2048;
            public int playbackPositionUpdateInterval = 8;
        }

        [Serializable]
        public class EditorPcmOutputConfig
        {
            public bool enable;
            public int bufferLength = 4096;
        }

        [Serializable]
        public class AndroidLowLatencyStandardVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
        }

        [Serializable]
        public class VitaManaVoicePoolConfig
        {
            public int numberOfManaDecoders = 8;
        }

        [Serializable]
        public class VitaAtrac9VoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
        }

        [Serializable]
        public class Ps4Atrac9VoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
        }

        [Serializable]
        public class Ps5PortConfig
        {
            public int maxChannelPorts = 6;
            public int maxObjectPorts = 16;
        }

        [Serializable]
        public class SwitchOpusVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
        }

        [Serializable]
        public class Ps4Audio3dConfig
        {
            [Serializable]
            public class VoicePoolConfig
            {
                public int memoryVoices;
                public int streamingVoices;
            }

            public bool useAudio3D;
            public VoicePoolConfig voicePoolConfig = new VoicePoolConfig();
        }

        [Serializable]
        public class WebGLWebAudioVoicePoolConfig
        {
            public int voices = 16;
        }

        public string acfFileName = "";
        public int maxVirtualVoices = 32;
        public int maxVoiceLimitGroups = 32;
        public int maxCategories = 32;
        public int maxAisacs = 8;
        public int maxBusSends = 8;
        public int maxSequenceEventsPerFrame = 2;
        public int maxBeatSyncCallbacksPerFrame = 1;
        public int maxCueLinkCallbacksPerFrame = 1;
        public StandardVoicePoolConfig standardVoicePoolConfig = new StandardVoicePoolConfig();
        public HcaMxVoicePoolConfig hcaMxVoicePoolConfig = new HcaMxVoicePoolConfig();
        public int outputSamplingRate;
        public bool usesInGamePreview;
        public InGamePreviewSwitchMode inGamePreviewMode = InGamePreviewSwitchMode.Default;
        public bool switchInitializeSocket;
        public InGamePreviewConfig inGamePreviewConfig = new InGamePreviewConfig();
        public float serverFrequency = 60f;
        public CriAtom.SpeakerMapping speakerMapping;
        public int asrOutputChannels;
        public bool useRandomSeedWithTime = true;
        public int categoriesPerPlayback = 4;
        public int maxFaders = 4;
        public int maxBuses = 8;
        public float maxPitch = 2400f;
        public int maxParameterBlocks = 1024;
        public CriAtomEx.SoundRendererType soundRendererType = CriAtomEx.SoundRendererType.Native;
        public bool keepPlayingSoundOnPause = true;
        public bool enableSonicSync = true;
        public EditorPcmOutputConfig editorPcmOutputConfig = new EditorPcmOutputConfig();
        public int pcBufferingTime;
        public bool useMicrosoftSpatialSound = true;
        public LinuxOutput linuxOutput;
        public int linuxPulseLatencyUsec = 60000;
        public bool iosEnableSonicSync = true;
        public int iosBufferingTime = 50;
        public bool iosOverrideIPodMusic;
        public bool androidEnableSonicSync = true;
        public int androidBufferingTime = 133;
        public int androidStartBufferingTime = 100;
        public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig =
            new AndroidLowLatencyStandardVoicePoolConfig();
        public bool androidUsesAndroidFastMixer = true;
        public bool androidForceToUseAsrForDefaultPlayback = true;
        public bool androidUsesAAudio;
        public int androidStreamType;
        public VitaManaVoicePoolConfig vitaManaVoicePoolConfig = new VitaManaVoicePoolConfig();
        public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig = new VitaAtrac9VoicePoolConfig();
        public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig = new Ps4Atrac9VoicePoolConfig();
        public Ps5PortConfig ps5PortConfig = new Ps5PortConfig();
        public bool switchEnableSonicSync = true;
        public SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig = new SwitchOpusVoicePoolConfig();
        public Ps4Audio3dConfig ps4Audio3dConfig = new Ps4Audio3dConfig();
        public WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig = new WebGLWebAudioVoicePoolConfig();
    }

    // CriWare.CriManaConfig (TypeDefIndex 31899).
    [Serializable]
    public class CriManaConfig
    {
        [Serializable]
        public class PCH264PlaybackConfig
        {
            public bool useH264Playback = true;
        }

        [Serializable]
        public class VitaH264PlaybackConfig
        {
            public bool useH264Playback;
            public int maxWidth = 960;
            public int maxHeight = 544;
            public bool getMemoryFromTexture;
        }

        [Serializable]
        public class WebGLConfig
        {
            public string webworkerPath = "StreamingAssets";
            public int heapSize = 32;
        }

        public int numberOfDecoders = 8;
        public int numberOfMaxEntries = 4;
        public readonly bool graphicsMultiThreaded = true;
        public bool useStreamerManager;
        public PCH264PlaybackConfig pcH264PlaybackConfig = new PCH264PlaybackConfig();
        public VitaH264PlaybackConfig vitaH264PlaybackConfig = new VitaH264PlaybackConfig();
        public WebGLConfig webglConfig = new WebGLConfig();
    }
}
