namespace CriWare
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::CriWare;
    using global::UnityEngine;

    public static class CriAtomEx
    {
        public enum CharacterEncoding
        {
            Utf8,
            Sjis
        }

        public enum SoundRendererType
        {
            Default = 0,
            Native = 1,
            Asr = 2,
            Extended = 3,
            Spatial = 4,
            Hw1 = 1,
            Hw2 = 65537,
            Hw3 = 131073,
            Hw4 = 196609,
            Haptic = 3,
            Pseudo = 65539,
            SpatialChannels = 4,
            Ambisonics = 65540,
            Passtrough = 131076,
            Object = 196612
        }

        public enum VoiceAllocationMethod
        {
            Once,
            Retry
        }

        public enum BiquadFilterType
        {
            Off,
            LowPass,
            HighPass,
            Notch,
            LowShelf,
            HighShelf,
            Peaking
        }

        public enum ResumeMode
        {
            AllPlayback,
            PausedPlayback,
            PreparedPlayback
        }

        public enum PanType
        {
            Unknown = -1,
            Pan3d,
            Pos3d,
            Auto
        }

        public enum VoiceControlMethod
        {
            PreferLast,
            PreferFirst
        }

        public enum Parameter
        {
            Volume = 0,
            Pitch = 1,
            Pan3dAngle = 2,
            Pan3dDistance = 3,
            Pan3dVolume = 4,
            BusSendLevel0 = 9,
            BusSendLevel1 = 10,
            BusSendLevel2 = 11,
            BusSendLevel3 = 12,
            BusSendLevel4 = 13,
            BusSendLevel5 = 14,
            BusSendLevel6 = 15,
            BusSendLevel7 = 16,
            BandPassFilterCofLow = 17,
            BandPassFilterCofHigh = 18,
            BiquadFilterType = 19,
            BiquadFilterFreq = 20,
            BiquadFIlterQ = 21,
            BiquadFilterGain = 22,
            EnvelopeAttackTime = 23,
            EnvelopeHoldTime = 24,
            EnvelopeDecayTime = 25,
            EnvelopeReleaseTime = 26,
            EnvelopeSustainLevel = 27,
            StartTime = 28,
            Priority = 31
        }

        public enum Speaker
        {
            FrontLeft,
            FrontRight,
            FrontCenter,
            LowFrequency,
            SurroundLeft,
            SurroundRight,
            SurroundBackLeft,
            SurroundBackRight
        }

        public enum Format : uint
        {
            ADX = 1u,
            HCA = 3u,
            HCA_MX = 4u,
            WAVE = 5u,
            RAW_PCM = 6u,
            AUDIO_BUFFER = 9u,
            HW1 = 65537u,
            HW2 = 65538u,
            HW3 = 65539u,
            MP3 = 65539u
        }

        public enum CurveType
        {
            Linear,
            Square,
            SquareReverse,
            SCurve,
            FlatAtHalf
        }

        private enum SpeakerSystem : uint
        {
            Surround_5_1,
            Surround_7_1
        }

        public struct SpeakerAngles6ch
        {
            public float frontLeft;
            public float frontRight;
            public float frontCenter;
            public float lowFrequency;
            public float surroundLeft;
            public float surroundRight;
            public static SpeakerAngles6ch Default()
            {
                return default(SpeakerAngles6ch);
            }
        }

        public struct SpeakerAngles8ch
        {
            public float frontLeft;
            public float frontRight;
            public float frontCenter;
            public float lowFrequency;
            public float surroundLeft;
            public float surroundRight;
            public float surroundBackLeft;
            public float surroundBackRight;
            public static SpeakerAngles8ch Default()
            {
                return default(SpeakerAngles8ch);
            }
        }

        public struct FormatInfo
        {
            public Format format;
            public int samplingRate;
            public long numSamples;
            public long loopOffset;
            public long loopLength;
            public int numChannels;
            public uint reserved;
        }

        public struct AisacControlInfo
        {
            public readonly string name;
            public uint id;
            public AisacControlInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public enum Randomize3dCalcType
        {
            None = -1,
            Rectangle = 0,
            Cuboid = 1,
            Circle = 2,
            Cylinder = 3,
            Sphere = 4,
            List = 6
        }

        public enum Randomize3dParamType
        {
            None,
            Width,
            Depth,
            Height,
            Radius
        }

        [Serializable]
        public struct Randomize3dConfig
        {
            public const int NumOfCalcParams = 3;
            [SerializeField]
            private bool followsOriginalSource;
            [SerializeField]
            private Randomize3dCalcType calculationType;
            [SerializeField]
            private float[] calculationParameters;
            public bool FollowsOriginalSource
            {
                get
                {
                    return default(bool);
                }
            }

            public Randomize3dCalcType CalculationType
            {
                get
                {
                    return default(Randomize3dCalcType);
                }
            }

            public float CalculationParameter1
            {
                get
                {
                    return default(float);
                }
            }

            public float CalculationParameter2
            {
                get
                {
                    return default(float);
                }
            }

            public float CalculationParameter3
            {
                get
                {
                    return default(float);
                }
            }

            internal Randomize3dConfig(byte[] data, int startIndex)
            {
                this = default;
            }

            public Randomize3dConfig(bool followsOriginalSource, Randomize3dCalcType calculationType, float param1 = 0f, float param2 = 0f, float param3 = 0f)
            {
                this = default;
            }

            public Randomize3dConfig(int dummy)
            {
                this = default;
            }

            public void ClearCalcParams(float initVal = 0f)
            {
            }

            public bool GetParamByType(Randomize3dParamType paramType, ref float paramVal)
            {
                return default(bool);
            }

            public bool SetParamByType(Randomize3dParamType paramType, float paramVal)
            {
                return default(bool);
            }
        }

        public struct CuePos3dInfo
        {
            public float coneInsideAngle;
            public float coneOutsideAngle;
            public float minAttenuationDistance;
            public float maxAttenuationDistance;
            public float sourceRadius;
            public float interiorDistance;
            public float dopplerFactor;
            public Randomize3dConfig randomPos;
            public uint distanceAisacControl;
            public uint listenerBaseAngleAisacControl;
            public uint sourceBaseAngleAisacControl;
            public uint listenerBaseElevationAisacControl;
            public uint sourceBaseElevationAisacControl;
            public CuePos3dInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct GameVariableInfo
        {
            public readonly string name;
            public uint id;
            public float gameValue;
            public GameVariableInfo(byte[] data, int startIndex)
            {
                this = default;
            }

            public GameVariableInfo(string name, uint id, float gameValue)
            {
                this = default;
            }
        }

        public enum CueType
        {
            Polyphonic,
            Sequential,
            Shuffle,
            Random,
            RandomNoRepeat,
            SwitchGameVariable,
            ComboSequential,
            SwitchSelector,
            TrackTransitionBySelector
        }

        public enum SilentMode
        {
            Normal,
            Stop,
            Virtual,
            VirtualRetrigger
        }

        public struct CueInfo
        {
            public int id;
            public CueType type;
            public readonly string name;
            public readonly string userData;
            public long length;
            public ushort[] categories;
            public short numLimits;
            public ushort numBlocks;
            public ushort numTracks;
            public ushort numRelatedWaveForms;
            public byte priority;
            public byte headerVisibility;
            public byte ignore_player_parameter;
            public byte probability;
            public PanType panType;
            public CuePos3dInfo pos3dInfo;
            public GameVariableInfo gameVariableInfo;
            public float volume;
            public SilentMode silentMode;
            public float pitch;
            public ushort selectorIndex;
            public CueInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct WaveformInfo
        {
            public int waveId;
            public uint format;
            public int samplingRate;
            public int numChannels;
            public long numSamples;
            public bool streamingFlag;
            public uint[] reserved;
            public WaveformInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct AisacInfo
        {
            public readonly string name;
            public bool defaultControlFlag;
            public float defaultControlValue;
            public uint controlId;
            public readonly string controlName;
            public AisacInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct PerformanceInfo
        {
            public uint serverProcessCount;
            public uint lastServerTime;
            public uint maxServerTime;
            public uint averageServerTime;
            public uint lastServerInterval;
            public uint maxServerInterval;
            public uint averageServerInterval;
        }

        public struct ResourceUsage
        {
            public uint useCount;
            public uint limit;
        }

        public struct NativeVector
        {
            public float x;
            public float y;
            public float z;
            public NativeVector(float x, float y, float z)
            {
                this = default;
            }

            public NativeVector(Vector3 vector)
            {
                this = default;
            }
        }

        public struct CueLinkInfo
        {
            public IntPtr nativePlayerHn;
            public uint basePlaybackId;
            public uint targetPlaybackId;
            public int cueLinkType;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CueLinkCbFunc(ref CueLinkInfo info);
        public const uint InvalidAisacControlId = 4294967295u;
        public static readonly Dictionary<Randomize3dCalcType, Randomize3dParamType[]> randomize3dParamTable;
        public static SoundRendererType androidDefaultSoundRendererType;
        public static event CueLinkCbFunc OnCueLinkCallback
        {
            add
            {
            }

            remove
            {
            }
        }

        public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle)
        {
        }

        public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle)
        {
        }

        public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle)
        {
        }

        public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle)
        {
        }

        public static void ControlVirtualSpeakerSetting(bool sw)
        {
        }

        public static bool RegisterAcf(CriFsBinder binder, string acfPath)
        {
            return default(bool);
        }

        public static bool RegisterAcf(IntPtr acfData, int dataSize)
        {
            return default(bool);
        }

        [Obsolete("Use RegisterAcf(IntPtr, int) instead")]
        public static bool RegisterAcf(byte[] acfData)
        {
            return default(bool);
        }

        public static void UnregisterAcf()
        {
        }

        public static string GetAppliedDspBusSnapshotName()
        {
            return null;
        }

        public static void AttachDspBusSetting(string settingName)
        {
        }

        public static void DetachDspBusSetting()
        {
        }

        public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms)
        {
        }

        public static int GetNumGameVariables()
        {
            return default(int);
        }

        public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info)
        {
            throw null;
        }

        public static float GetGameVariable(uint game_variable_id)
        {
            return default(float);
        }

        public static float GetGameVariable(string game_variable_name)
        {
            return default(float);
        }

        public static void SetGameVariable(uint game_variable_id, float game_variable_value)
        {
        }

        public static void SetGameVariable(string game_variable_name, float game_variable_value)
        {
        }

        public static void SetRandomSeed(uint seed)
        {
        }

        public static void ResetPerformanceMonitor()
        {
        }

        public static void GetPerformanceInfo(out PerformanceInfo info)
        {
            throw null;
        }

        public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index)
        {
        }

        public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name)
        {
        }

        public static void PauseTimer(bool sw)
        {
        }

        public static void Lock()
        {
        }

        public static void Unlock()
        {
        }

        public static void SetOutputAudioDevice_PC(string deviceId)
        {
        }

        public static string GetOutputAudioDeviceId_PC(out bool isDefaultDevice)
        {
            throw null;
        }

        public static int GetOutputAudioDeviceIndex_PC(out bool isDefaultDevice)
        {
            throw null;
        }

        public static bool LoadAudioDeviceList_PC()
        {
            return default(bool);
        }

        public static int GetNumAudioDevices_PC()
        {
            return default(int);
        }

        public static string GetAudioDeviceName_PC(int index)
        {
            return null;
        }

        public static void SetOutputAudioDevice_PC(int index)
        {
        }

        public static void SetOutputVolume_VITA(float volume)
        {
        }

        public static bool IsBgmPortAcquired_VITA()
        {
            return default(bool);
        }

        public static void EnableBackgroundPlayback_IOS()
        {
        }

        public static void DisableBackgroundPlayback_IOS()
        {
        }

        public static bool IsInterruptedOtherAudio_IOS()
        {
            return default(bool);
        }

        public static void ResumeAudio_IOS()
        {
        }

        public static bool IsSoundStopped_IOS()
        {
            return default(bool);
        }

        public static void EnableAudioSessionRestoration_IOS(bool flag)
        {
        }

        public static void EnableBusSendOffsetWhenLevelNotExist(bool enable)
        {
        }

        [PreserveSig]
        private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize);
        [PreserveSig]
        private static extern bool criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize);
        [PreserveSig]
        private static extern bool criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize);
        [PreserveSig]
        private static extern void criAtomEx_UnregisterAcf();
        [PreserveSig]
        private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize);
        [PreserveSig]
        private static extern void criAtomEx_DetachDspBusSetting();
        [PreserveSig]
        private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms);
        [PreserveSig]
        private static extern IntPtr criAtomEx_GetAppliedDspBusSnapshotName();
        [PreserveSig]
        private static extern int criAtomEx_GetNumGameVariables();
        [PreserveSig]
        private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info);
        [PreserveSig]
        private static extern float criAtomEx_GetGameVariableById(uint game_variable_id);
        [PreserveSig]
        private static extern float criAtomEx_GetGameVariableByName(string game_variable_name);
        [PreserveSig]
        private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value);
        [PreserveSig]
        private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value);
        [PreserveSig]
        private static extern void criAtomEx_SetRandomSeed(uint seed);
        [PreserveSig]
        private static extern void criAtomEx_PauseTimer(bool sw);
        [PreserveSig]
        private static extern void criAtomEx_Lock();
        [PreserveSig]
        private static extern void criAtomEx_Unlock();
        [PreserveSig]
        private static extern void criAtom_ResetPerformanceMonitor();
        [PreserveSig]
        private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info);
        [PreserveSig]
        private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index);
        [PreserveSig]
        private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name);
        [PreserveSig]
        private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array);
        [PreserveSig]
        private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array);
        [PreserveSig]
        private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array);
        [PreserveSig]
        private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array);
        [PreserveSig]
        private static extern void criAtomEx_ControlVirtualSpeakerSetting(bool sw);
        [PreserveSig]
        private static extern void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable);
        [PreserveSig]
        public static extern void criAtom_EnableSlLatencyCheck_ANDROID(bool sw);
        [PreserveSig]
        public static extern int criAtom_GetSlBufferConsumptionLatency_ANDROID();
    }
}
