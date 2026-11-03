namespace CriWare
{
    using global::System;
    using global::CriWare;

    [Serializable]
    public class CriAtomConfig
    {
        [Serializable]
        public class StandardVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public StandardVoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class HcaMxVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public HcaMxVoicePoolConfig()
            {
            }
        }

        [Serializable]
        public enum InGamePreviewSwitchMode
        {
            Disable,
            Enable,
            FollowBuildSetting,
            Default
        }

        [Serializable]
        public class InGamePreviewConfig
        {
            public int maxPreviewObjects;
            public int communicationBufferSize;
            public int playbackPositionUpdateInterval;
            public InGamePreviewConfig()
            {
            }
        }

        [Serializable]
        public class EditorPcmOutputConfig
        {
            public bool enable;
            public int bufferLength;
            public EditorPcmOutputConfig()
            {
            }
        }

        public enum LinuxOutput
        {
            Default,
            PulseAudio,
            ALSA
        }

        [Serializable]
        public class AndroidLowLatencyStandardVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public AndroidLowLatencyStandardVoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class VitaManaVoicePoolConfig
        {
            public int numberOfManaDecoders;
            public VitaManaVoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class VitaAtrac9VoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public VitaAtrac9VoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class Ps4Atrac9VoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public Ps4Atrac9VoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class Ps5PortConfig
        {
            public int maxChannelPorts;
            public int maxObjectPorts;
            public Ps5PortConfig()
            {
            }
        }

        [Serializable]
        public class SwitchOpusVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public SwitchOpusVoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class Switch2OpusVoicePoolConfig
        {
            public int memoryVoices;
            public int streamingVoices;
            public Switch2OpusVoicePoolConfig()
            {
            }
        }

        [Serializable]
        public class Ps4Audio3dConfig
        {
            [Serializable]
            public class VoicePoolConfig
            {
                public int memoryVoices;
                public int streamingVoices;
                public VoicePoolConfig()
                {
                }
            }

            public bool useAudio3D;
            public VoicePoolConfig voicePoolConfig;
            public Ps4Audio3dConfig()
            {
            }
        }

        public string acfFileName;
        public int maxVirtualVoices;
        public int maxVoiceLimitGroups;
        public int maxCategories;
        public int maxAisacs;
        public int maxBusSends;
        public int maxSequenceEventsPerFrame;
        public int maxBeatSyncCallbacksPerFrame;
        public int maxCueLinkCallbacksPerFrame;
        public StandardVoicePoolConfig standardVoicePoolConfig;
        public HcaMxVoicePoolConfig hcaMxVoicePoolConfig;
        public int outputSamplingRate;
        public bool usesInGamePreview;
        public InGamePreviewSwitchMode inGamePreviewMode;
        public bool switchInitializeSocket;
        public bool switch2InitializeSocket;
        public InGamePreviewConfig inGamePreviewConfig;
        public float serverFrequency;
        public CriAtom.SpeakerMapping speakerMapping;
        public int asrOutputChannels;
        public bool useRandomSeedWithTime;
        public int categoriesPerPlayback;
        public int maxFaders;
        public int maxBuses;
        public float maxPitch;
        public int maxParameterBlocks;
        public CriAtomEx.SoundRendererType soundRendererType;
        public bool keepPlayingSoundOnPause;
        public bool enableSonicSync;
        public bool enableAtomSoundDisabledMode;
        public bool enableAtomSoundDisabledModeLinux;
        public EditorPcmOutputConfig editorPcmOutputConfig;
        public int pcBufferingTime;
        public bool useMicrosoftSpatialSound;
        public LinuxOutput linuxOutput;
        public int linuxPulseLatencyUsec;
        public bool iosEnableSonicSync;
        public int iosBufferingTime;
        public bool iosOverrideIPodMusic;
        public bool iosEnableOSNotificationHandling;
        public bool androidEnableSonicSync;
        public int androidBufferingTime;
        public int androidStartBufferingTime;
        public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig;
        public bool androidUsesAndroidFastMixer;
        public bool androidForceToUseAsrForDefaultPlayback;
        public bool androidUsesAAudio;
        public int androidStreamType;
        public VitaManaVoicePoolConfig vitaManaVoicePoolConfig;
        public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig;
        public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig;
        public Ps5PortConfig ps5PortConfig;
        public int ps5Mp3StreamingVoices;
        public bool switchEnableSonicSync;
        public SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig;
        public Switch2OpusVoicePoolConfig switch2OpusVoicePoolConfig;
        public Ps4Audio3dConfig ps4Audio3dConfig;
        public int ps4Mp3StreamingVoices;
        public CriAtomConfig()
        {
        }
    }
}
