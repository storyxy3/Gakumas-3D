using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace CriWare
{
    // CriWare.CriAtomEx (TypeDefIndex 31713), the members on the game's paths. The info structs are parsed from the
    // native struct bytes (CriStructMemory) with the game's 32/64-bit offsets.
    public static partial class CriAtomEx
    {
        public const uint InvalidAisacControlId = 4294967295;
        public static SoundRendererType androidDefaultSoundRendererType;

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
            Once = 0,
            Retry = 1
        }

        public enum CueType
        {
            Polyphonic = 0,
            Sequential = 1,
            Shuffle = 2,
            Random = 3,
            RandomNoRepeat = 4,
            SwitchGameVariable = 5,
            ComboSequential = 6,
            SwitchSelector = 7,
            TrackTransitionBySelector = 8
        }

        // CriWare.CriAtomEx.ResumeMode (TypeDefIndex 31686).
        public enum ResumeMode
        {
            AllPlayback = 0,
            PausedPlayback = 1,
            PreparedPlayback = 2
        }

        public enum PanType
        {
            Unknown = -1,
            Pan3d = 0,
            Pos3d = 1,
            Auto = 2
        }

        public enum SilentMode
        {
            Normal = 0,
            Stop = 1,
            Virtual = 2,
            VirtualRetrigger = 3
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

        public enum Format : uint
        {
            ADX = 1,
            HCA = 3,
            HCA_MX = 4,
            WAVE = 5,
            RAW_PCM = 6,
            AUDIO_BUFFER = 9
        }

        [Serializable]
        public struct Randomize3dConfig
        {
            [SerializeField]
            [MarshalAs(UnmanagedType.Bool)]
            private bool followsOriginalSource;
            [SerializeField]
            private Randomize3dCalcType calculationType;
            [SerializeField]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            private float[] calculationParameters;

            public const int NumOfCalcParams = 3;

            public bool FollowsOriginalSource => followsOriginalSource;

            public Randomize3dCalcType CalculationType => calculationType;

            public Randomize3dConfig(byte[] data, int startIndex)
            {
                followsOriginalSource = BitConverter.ToInt32(data, startIndex) != 0;
                calculationType = (Randomize3dCalcType)BitConverter.ToInt32(data, startIndex + 4);
                calculationParameters = new float[3];
                for (var i = 0; i < 3; i++)
                    calculationParameters[i] = BitConverter.ToSingle(data, startIndex + 8 + 4 * i);
            }

            // CriAtomSourceBase's field initializer: calculationType stays 0 (Rectangle), not None.
            public Randomize3dConfig(int dummy)
            {
                followsOriginalSource = false;
                calculationType = 0;
                calculationParameters = new float[3];
                ClearCalcParams();
            }

            public void ClearCalcParams(float initVal = 0)
            {
                for (var i = 0; i < 3; i++)
                    calculationParameters[i] = initVal;
            }
        }

        public struct NativeVector
        {
            public float x;
            public float y;
            public float z;

            public NativeVector(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public NativeVector(Vector3 vector)
            {
                x = vector.x;
                y = vector.y;
                z = vector.z;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
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
                coneInsideAngle = BitConverter.ToSingle(data, startIndex);
                coneOutsideAngle = BitConverter.ToSingle(data, startIndex + 4);
                minAttenuationDistance = BitConverter.ToSingle(data, startIndex + 8);
                maxAttenuationDistance = BitConverter.ToSingle(data, startIndex + 12);
                sourceRadius = BitConverter.ToSingle(data, startIndex + 16);
                interiorDistance = BitConverter.ToSingle(data, startIndex + 20);
                dopplerFactor = BitConverter.ToSingle(data, startIndex + 24);
                randomPos = new Randomize3dConfig(data, startIndex + 28);
                distanceAisacControl = BitConverter.ToUInt32(data, startIndex + 48);
                listenerBaseAngleAisacControl = BitConverter.ToUInt32(data, startIndex + 52);
                sourceBaseAngleAisacControl = BitConverter.ToUInt32(data, startIndex + 56);
                listenerBaseElevationAisacControl = BitConverter.ToUInt32(data, startIndex + 60);
                sourceBaseElevationAisacControl = BitConverter.ToUInt32(data, startIndex + 64);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GameVariableInfo
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public readonly string name;
            public uint id;
            public float gameValue;

            public GameVariableInfo(byte[] data, int startIndex)
            {
                int index;
                if (IntPtr.Size == 4)
                {
                    name = Marshal.PtrToStringAnsi(new IntPtr(BitConverter.ToInt32(data, startIndex)));
                    id = BitConverter.ToUInt32(data, startIndex + 4);
                    index = startIndex + 8;
                }
                else
                {
                    name = Marshal.PtrToStringAnsi(new IntPtr(BitConverter.ToInt64(data, startIndex)));
                    id = BitConverter.ToUInt32(data, startIndex + 8);
                    index = startIndex + 12;
                }
                gameValue = BitConverter.ToSingle(data, index);
            }
        }

        // 176 bytes on 64-bit, 160 on 32-bit.
        [StructLayout(LayoutKind.Sequential)]
        public struct CueInfo
        {
            public int id;
            public CueType type;
            [MarshalAs(UnmanagedType.LPStr)]
            public readonly string name;
            [MarshalAs(UnmanagedType.LPStr)]
            public readonly string userData;
            public long length;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
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

            public CueInfo(byte[] data, int startIndex)
            {
                var size = IntPtr.Size;
                id = BitConverter.ToInt32(data, startIndex);
                type = (CueType)BitConverter.ToInt32(data, startIndex + 4);
                int index;
                if (size != 4)
                {
                    name = Marshal.PtrToStringAnsi(new IntPtr(BitConverter.ToInt64(data, startIndex + 8)));
                    userData = Marshal.PtrToStringAnsi(new IntPtr(BitConverter.ToInt64(data, startIndex + 16)));
                    length = BitConverter.ToInt64(data, startIndex + 24);
                    categories = new ushort[16];
                    for (var i = 0; i < 16; i++)
                        categories[i] = BitConverter.ToUInt16(data, startIndex + 32 + 2 * i);
                    numLimits = BitConverter.ToInt16(data, startIndex + 64);
                    numBlocks = BitConverter.ToUInt16(data, startIndex + 66);
                    numTracks = BitConverter.ToUInt16(data, startIndex + 68);
                    numRelatedWaveForms = BitConverter.ToUInt16(data, startIndex + 70);
                    priority = data[startIndex + 72];
                    headerVisibility = data[startIndex + 73];
                    ignore_player_parameter = data[startIndex + 74];
                    probability = data[startIndex + 75];
                    panType = (PanType)BitConverter.ToInt32(data, startIndex + 76);
                    pos3dInfo = new CuePos3dInfo(data, startIndex + 80);
                    gameVariableInfo = new GameVariableInfo(data, startIndex + 152);
                    volume = BitConverter.ToSingle(data, startIndex + 168);
                    index = startIndex + 172;
                }
                else
                {
                    name = Marshal.PtrToStringAnsi(new IntPtr(BitConverter.ToInt32(data, startIndex + 8)));
                    userData = Marshal.PtrToStringAnsi(new IntPtr(BitConverter.ToInt32(data, startIndex + 12)));
                    length = BitConverter.ToInt64(data, startIndex + 16);
                    categories = new ushort[16];
                    for (var i = 0; i < 16; i++)
                        categories[i] = BitConverter.ToUInt16(data, startIndex + 24 + 2 * i);
                    numLimits = BitConverter.ToInt16(data, startIndex + 56);
                    numBlocks = BitConverter.ToUInt16(data, startIndex + 58);
                    numTracks = BitConverter.ToUInt16(data, startIndex + 60);
                    numRelatedWaveForms = BitConverter.ToUInt16(data, startIndex + 62);
                    priority = data[startIndex + 64];
                    headerVisibility = data[startIndex + 65];
                    ignore_player_parameter = data[startIndex + 66];
                    probability = data[startIndex + 67];
                    panType = (PanType)BitConverter.ToInt32(data, startIndex + 68);
                    pos3dInfo = new CuePos3dInfo(data, startIndex + 72);
                    gameVariableInfo = new GameVariableInfo(data, startIndex + 140);
                    volume = BitConverter.ToSingle(data, startIndex + 152);
                    index = startIndex + 156;
                }
                silentMode = (SilentMode)BitConverter.ToInt32(data, index);
            }
        }

        // 32 bytes.
        [StructLayout(LayoutKind.Sequential)]
        public struct WaveformInfo
        {
            public int waveId;
            public uint format;
            public int samplingRate;
            public int numChannels;
            public long numSamples;
            [MarshalAs(UnmanagedType.Bool)]
            public bool streamingFlag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public uint[] reserved;

            public WaveformInfo(byte[] data, int startIndex)
            {
                waveId = BitConverter.ToInt32(data, startIndex);
                format = BitConverter.ToUInt32(data, startIndex + 4);
                samplingRate = BitConverter.ToInt32(data, startIndex + 8);
                numChannels = BitConverter.ToInt32(data, startIndex + 12);
                numSamples = BitConverter.ToInt64(data, startIndex + 16);
                streamingFlag = BitConverter.ToInt32(data, startIndex + 24) != 0;
                reserved = new uint[1];
                reserved[0] = BitConverter.ToUInt32(data, startIndex + 28);
            }
        }

        public static bool RegisterAcf(CriFsBinder binder, string acfPath)
        {
            return criAtomEx_RegisterAcfFile(binder != null ? binder.nativeHandle : IntPtr.Zero, acfPath, IntPtr.Zero, 0);
        }

        public static bool RegisterAcf(byte[] acfData)
        {
            return criAtomEx_RegisterAcfData(acfData, acfData.Length, IntPtr.Zero, 0);
        }

        public static void UnregisterAcf()
        {
            criAtomEx_UnregisterAcf();
        }

        public static void AttachDspBusSetting(string settingName)
        {
            criAtomEx_AttachDspBusSetting(settingName, IntPtr.Zero, 0);
        }

        public static void DetachDspBusSetting()
        {
            criAtomEx_DetachDspBusSetting();
        }

        public static void SetRandomSeed(uint seed)
        {
            criAtomEx_SetRandomSeed(seed);
        }

        private static bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize) =>
            CriWareNative.Native.criAtomEx_RegisterAcfFile(binder, path, work, workSize);
        private static bool criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize) =>
            CriWareNative.Native.criAtomEx_RegisterAcfData(acfData, acfDataSize, work, workSize);
        private static void criAtomEx_UnregisterAcf() => CriWareNative.Native.criAtomEx_UnregisterAcf();
        private static void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize) =>
            CriWareNative.Native.criAtomEx_AttachDspBusSetting(settingName, work, workSize);
        private static void criAtomEx_DetachDspBusSetting() => CriWareNative.Native.criAtomEx_DetachDspBusSetting();
        private static void criAtomEx_SetRandomSeed(uint seed) => CriWareNative.Native.criAtomEx_SetRandomSeed(seed);
    }
}
