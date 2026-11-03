namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public static class CriAtomExAcfDebug
    {
        public struct CategoryInfo
        {
            public uint groupNo;
            public uint id;
            public string name;
            public uint numCueLimits;
            public float volume;
        }

        public struct DspBusInfo
        {
            public string name;
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
        }

        public struct AisacControlInfo
        {
            public string name;
            public uint id;
        }

        public enum AisacType
        {
            Normal,
            AutoModulation
        }

        public struct GlobalAisacInfo
        {
            public string name;
            public ushort index;
            public ushort numGraphs;
            public AisacType type;
            public float randomRange;
            public ushort controlId;
        }

        public struct SelectorInfo
        {
            public string name;
            public ushort index;
            public ushort numLabels;
            public ushort globalLabelIndex;
        }

        public struct SelectorLabelInfo
        {
            public string selectorName;
            public string labelName;
        }

        private struct CategoryInfoForMarshaling
        {
            public uint groupNo;
            public uint id;
            public IntPtr namePtr;
            public uint numCueLimits;
            public float volume;
            public void Convert(out CategoryInfo x)
            {
                throw null;
            }
        }

        private struct DspBusInfoForMarshaling
        {
            public IntPtr namePtr;
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
            public CriAtomExAcf.DspBusOutputType outputType;
            public byte outputOptions;
            public void Convert(out DspBusInfo x)
            {
                throw null;
            }
        }

        private struct AisacControlInfoForMarshaling
        {
            public IntPtr namePtr;
            public uint id;
            public void Convert(out AisacControlInfo x)
            {
                throw null;
            }
        }

        private struct GlobalAisacInfoForMarshaling
        {
            public IntPtr namePtr;
            public ushort index;
            public ushort numGraphs;
            public uint type;
            public float randomRange;
            public ushort controlId;
            public ushort dummy;
            public void Convert(out GlobalAisacInfo x)
            {
                throw null;
            }
        }

        private struct SelectorInfoForMarshaling
        {
            public IntPtr namePtr;
            public ushort index;
            public ushort numLabels;
            public ushort globalLabelIndex;
            public void Convert(out SelectorInfo x)
            {
                throw null;
            }
        }

        private struct SelectorLabelInfoForMarshaling
        {
            public IntPtr selectorNamePtr;
            public IntPtr labelNamePtr;
            public void Convert(out SelectorLabelInfo x)
            {
                throw null;
            }
        }

        public static int GetNumCategories()
        {
            return default(int);
        }

        public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo)
        {
            throw null;
        }

        public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo)
        {
            throw null;
        }

        public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo)
        {
            throw null;
        }

        public static int GetNumBuses()
        {
            return default(int);
        }

        public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo)
        {
            throw null;
        }

        public static int GetNumAisacControls()
        {
            return default(int);
        }

        public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info)
        {
            throw null;
        }

        public static uint GetAisacControlIdByName(string name)
        {
            return default(uint);
        }

        public static string GetAisacControlNameById(uint id)
        {
            return null;
        }

        public static int GetNumGlobalAisacs()
        {
            return default(int);
        }

        public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info)
        {
            throw null;
        }

        public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info)
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

        public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo)
        {
            throw null;
        }

        [PreserveSig]
        private static extern int criAtomExAcf_GetNumCategories();
        [PreserveSig]
        private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo);
        [PreserveSig]
        private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo);
        [PreserveSig]
        private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumBuses();
        [PreserveSig]
        private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumAisacControls();
        [PreserveSig]
        private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info);
        [PreserveSig]
        private static extern uint criAtomExAcf_GetAisacControlIdByName(string name);
        [PreserveSig]
        private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumGlobalAisacs();
        [PreserveSig]
        private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetNumSelectors();
        [PreserveSig]
        private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info);
        [PreserveSig]
        private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info);
    }
}
