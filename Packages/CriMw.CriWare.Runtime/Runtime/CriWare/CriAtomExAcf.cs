namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public class CriAtomExAcf
    {
        public struct AcfDspSettingInfo
        {
            public string name;
            public ushort[] busIndexes;
            public ushort[] extendBusIndexes;
            public ushort snapshotStartIndex;
            public byte numBuses;
            public byte numExtendBuses;
            public ushort numSnapshots;
            public ushort snapshotWorkSize;
            public ushort numMixerAisacs;
            public ushort mixerAisacStartIndex;
            public AcfDspSettingInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct AcfDspSettingSnapshotInfo
        {
            public string name;
            public byte numBuses;
            public byte numExtendBuses;
            public byte[] reserved;
            public ushort[] busIndexes;
            public ushort[] extendBusIndexes;
            public AcfDspSettingSnapshotInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct AcfDspBusInfo
        {
            public IntPtr namePointer;
            public float volume;
            public float pan3dVolume;
            public float pan3dAngle;
            public float pan3dDistance;
            public float pan3dSpread;
            public float pan3dWideness;
            public ushort[] fxIndexes;
            public ushort[] busLinkIndexes;
            public ushort busNo;
            public byte numFxes;
            public byte numBusLinks;
            public CriAtom.SpeakerMapping speakerMapping;
            public DspBusOutputType outputType;
            public byte outputOptions;
            public string name
            {
                get
                {
                    return null;
                }
            }
        }

        public enum DspBusOutputType
        {
            None,
            Main,
            MainPassthrough,
            PadHaptic,
            PadSpeaker,
            Personal,
            PersonalPassthrough
        }

        public enum AcfDspBusLinkType : uint
        {
            preVolume,
            postVolume,
            postPan
        }

        public struct AcfDspBusLinkInfo
        {
            public AcfDspBusLinkType type;
            public float sendLevel;
            public ushort busNo;
            public ushort busId;
            public AcfDspBusLinkInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct CategoryInfo
        {
            public uint groupNo;
            public uint id;
            public string name;
            public uint numCueLimits;
            public float volume;
            public CategoryInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public enum AcfAisacType : uint
        {
            normal,
            autoModulation
        }

        public struct GlobalAisacInfo
        {
            public string name;
            public ushort index;
            public ushort numGraphs;
            public AcfAisacType type;
            public float randomRange;
            public ushort controlId;
            public ushort dummy;
            public GlobalAisacInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public enum AisacGraphType
        {
            none,
            volume,
            pitch,
            bandpassHigh,
            bandpassLow,
            biquadFreq,
            biquadQ,
            busSend0,
            busSend1,
            busSend2,
            busSend3,
            busSend4,
            busSend5,
            busSend6,
            busSend7,
            pan3dAngel,
            pan3dVolume,
            pan3dInteriorDistance,
            pan3dCenter,
            pan3dLfe,
            aisac0,
            aisac1,
            aisac2,
            aisac3,
            aisac4,
            aisac5,
            aisac6,
            aisac7,
            aisac8,
            aisac9,
            aisac10,
            aisac11,
            aisac12,
            aisac13,
            aisac14,
            aisac15,
            priority,
            preDelayTime,
            biquadGain,
            pan3dMixdownCenter,
            pan3dMixdownLfe,
            egAttack,
            egRelease,
            playbackRatio,
            drySendL,
            drySendR,
            drySendCenter,
            drySendLfe,
            drySendSl,
            drySendSr,
            drySendEx1,
            drySendEx2,
            panSpread
        }

        public struct AisacGraphInfo
        {
            public AisacGraphType type;
            public AisacGraphInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public enum CharacterEncoding : uint
        {
            utf8,
            sjis
        }

        public struct AcfInfo
        {
            public string name;
            public uint size;
            public uint version;
            public CharacterEncoding characterEncoding;
            public int numDspSettings;
            public int numCategories;
            public int numCategoriesPerPlayback;
            public int numReacts;
            public int numAisacControls;
            public int numGlobalAisacs;
            public int numGameVariables;
            public int maxBusesOfDspBusSettings;
            public int numBuses;
            public int numVoiceLimitGroups;
            public int numOutputPorts;
            public AcfInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct SelectorInfo
        {
            public string name;
            public ushort index;
            public ushort numLabels;
            public ushort globalLabelIndex;
            public SelectorInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public struct SelectorLabelInfo
        {
            public string selectorName;
            public string labelName;
            public SelectorLabelInfo(byte[] data, int startIndex)
            {
                this = default;
            }
        }

        public static int GetNumAisacControls()
        {
            return default(int);
        }

        public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info)
        {
            throw null;
        }

        public static int GetNumDspSettings()
        {
            return default(int);
        }

        public static int GetNumDspSettings(IntPtr acfData, int size)
        {
            return default(int);
        }

        public static string GetDspSettingNameByIndex(ushort index)
        {
            return null;
        }

        public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index)
        {
            return null;
        }

        public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info)
        {
            throw null;
        }

        public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info)
        {
            throw null;
        }

        public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info)
        {
            throw null;
        }

        public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info)
        {
            throw null;
        }

        public static int GetNumCategories()
        {
            return default(int);
        }

        public static int GetNumCategoriesPerPlayback()
        {
            return default(int);
        }

        public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info)
        {
            throw null;
        }

        public static bool GetCategoryInfoByName(string name, out CategoryInfo info)
        {
            throw null;
        }

        public static bool GetCategoryInfoById(uint id, out CategoryInfo info)
        {
            throw null;
        }

        public static int GetNumGlobalAisacs()
        {
            return default(int);
        }

        public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info)
        {
            throw null;
        }

        public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info)
        {
            throw null;
        }

        public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo)
        {
            throw null;
        }

        public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value)
        {
            throw null;
        }

        public static bool GetAcfInfo(out AcfInfo acfInfo)
        {
            throw null;
        }

        public static int GetNumSelectors()
        {
            return default(int);
        }

        public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info)
        {
            throw null;
        }

        public static bool GetSelectorInfoByName(string name, out SelectorInfo info)
        {
            throw null;
        }

        public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info)
        {
            throw null;
        }

        public static int GetNumBuses()
        {
            return default(int);
        }

        public static int GetMaxBusesOfDspBusSettings()
        {
            return default(int);
        }

        public static string FindBusName(string busName)
        {
            return null;
        }

        public static CriAtomExOutputPort GetOutputPort(string name)
        {
            return null;
        }

        [PreserveSig]
        private static extern int criAtomExAcf_GetNumAisacControls();
        [PreserveSig]
        private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info);
        [PreserveSig]
        private static extern uint criAtomExAcf_GetAisacControlIdByName(string name);
        [PreserveSig]
        private static extern string criAtomExAcf_GetAisacControlNameById(uint id);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumDspSettings();
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size);
        [PreserveSig]
        private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index);
        [PreserveSig]
        private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, out AcfDspBusInfo info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetDspFxType(ushort index);
        [PreserveSig]
        private static extern string criAtomExAcf_GetDspFxName(ushort index);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumCategories();
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumCategoriesPerPlayback();
        [PreserveSig]
        private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumGlobalAisacs();
        [PreserveSig]
        private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumSelectors();
        [PreserveSig]
        private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info);
        [PreserveSig]
        private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumBuses();
        [PreserveSig]
        private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size);
        [PreserveSig]
        private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings();
        [PreserveSig]
        private static extern string criAtomExAcf_FindBusName(string bus_name);
        [PreserveSig]
        private static extern IntPtr criAtomExAcf_GetOutputPortHnByName(string name);
        public CriAtomExAcf()
        {
        }
    }
}
