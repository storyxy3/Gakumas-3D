namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public static class CriAtomExCategory
    {
        public enum ReactType
        {
            Ducker,
            AisacModulationTrigger
        }

        public enum ReactDuckerTargetType
        {
            Volume,
            AisacControlValue
        }

        [Obsolete("Use CriWare.CriAtomEx.CurveType instead")]
        public enum ReactDuckerCurveType
        {
            Linear,
            Square,
            SquareReverse,
            SCurve,
            FlatAtHalf
        }

        public struct ReactFadeParameter
        {
            public CriAtomEx.CurveType curveType;
            public float curveStrength;
            public ushort fadeTimeMs;
        }

        public enum ReactHoldType
        {
            WhilePlaying,
            FixedTime
        }

        [StructLayout((LayoutKind)2)]
        public struct ReactDuckerParameter
        {
            public struct Volume
            {
                public float level;
            }

            public struct AisacControl
            {
                public uint id;
                public float value;
            }

            [StructLayout((LayoutKind)2)]
            public struct Target
            {
                [System.Runtime.InteropServices.FieldOffset(0x0)]
                public Volume volume;
                [System.Runtime.InteropServices.FieldOffset(0x0)]
                public AisacControl aisacControl;
            }

            [System.Runtime.InteropServices.FieldOffset(0x0)]
            public Target target;
            [System.Runtime.InteropServices.FieldOffset(0x8)]
            public ReactDuckerTargetType targetType;
            [System.Runtime.InteropServices.FieldOffset(0xC)]
            public ReactFadeParameter entry;
            [System.Runtime.InteropServices.FieldOffset(0x18)]
            public ReactFadeParameter exit;
            [System.Runtime.InteropServices.FieldOffset(0x24)]
            public ReactHoldType holdType;
            [System.Runtime.InteropServices.FieldOffset(0x28)]
            public ushort holdTimeMs;
        }

        public struct ReactAisacModulationParameter
        {
            private int _enableDecrementAisacModulationKey;
            public uint decrementAisacModulationKey;
            private int _enableIncrementAisacModulationKey;
            public uint incrementAisacModulationKey;
            public bool enableDecrementAisacModulationKey
            {
                get
                {
                    return default(bool);
                }
            }

            public bool enableIncrementAisacModulationKey
            {
                get
                {
                    return default(bool);
                }
            }
        }

        [StructLayout((LayoutKind)2)]
        public struct ReactParameter
        {
            [StructLayout((LayoutKind)2)]
            public struct Parameter
            {
                [System.Runtime.InteropServices.FieldOffset(0x0)]
                public ReactDuckerParameter ducker;
                [System.Runtime.InteropServices.FieldOffset(0x0)]
                public ReactAisacModulationParameter aisacModulation;
            }

            [System.Runtime.InteropServices.FieldOffset(0x0)]
            public Parameter parameter;
            [System.Runtime.InteropServices.FieldOffset(0x2C)]
            public ReactType type;
            [System.Runtime.InteropServices.FieldOffset(0x30)]
            public bool enablePausingCue;
        }

        public enum ReactStatus
        {
            Stop,
            FadeOut,
            Hold,
            FadeIn,
            Error
        }

        public static void SetVolume(string name, float volume)
        {
        }

        public static void SetVolume(int id, float volume)
        {
        }

        public static float GetVolume(string name)
        {
            return default(float);
        }

        public static float GetVolume(int id)
        {
            return default(float);
        }

        public static void Mute(string name, bool mute)
        {
        }

        public static void Mute(int id, bool mute)
        {
        }

        public static bool IsMuted(string name)
        {
            return default(bool);
        }

        public static bool IsMuted(int id)
        {
            return default(bool);
        }

        public static void Solo(string name, bool solo, float muteVolume)
        {
        }

        public static void Solo(int id, bool solo, float muteVolume)
        {
        }

        public static bool IsSoloed(string name)
        {
            return default(bool);
        }

        public static bool IsSoloed(int id)
        {
            return default(bool);
        }

        public static void Pause(string name, bool pause)
        {
        }

        public static void Pause(int id, bool pause)
        {
        }

        public static bool IsPaused(string name)
        {
            return default(bool);
        }

        public static bool IsPaused(int id)
        {
            return default(bool);
        }

        public static void SetAisacControl(string name, string controlName, float value)
        {
        }

        [Obsolete("Use CriAtomExCategory.SetAisacControl")]
        public static void SetAisac(string name, string controlName, float value)
        {
        }

        public static void SetAisacControl(int id, int controlId, float value)
        {
        }

        [Obsolete("Use CriAtomExCategory.SetAisacControl")]
        public static void SetAisac(int id, int controlId, float value)
        {
        }

        public static void SetReactParameter(string name, ReactParameter parameter)
        {
        }

        public static bool GetReactParameter(string name, out ReactParameter parameter)
        {
            throw null;
        }

        public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
        {
            throw null;
        }

        public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
        {
            throw null;
        }

        public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue)
        {
            throw null;
        }

        public static ReactStatus GetReactStatus(string reactName)
        {
            return default(ReactStatus);
        }

        public static void Stop(int id)
        {
        }

        public static void Stop(string name)
        {
        }

        public static void StopWithoutReleaseTime(int id)
        {
        }

        public static void StopWithoutReleaseTime(string name)
        {
        }

        public static float GetTotalVolume(int id)
        {
            return default(float);
        }

        public static float GetTotalVolume(string name)
        {
            return default(float);
        }

        public static void SetFadeInTime(int id, ushort ms)
        {
        }

        public static void SetFadeInTime(string name, ushort ms)
        {
        }

        public static void SetFadeOutTime(int id, ushort ms)
        {
        }

        public static void SetFadeOutTime(string name, ushort ms)
        {
        }

        public static bool ResetAllAisacControl(int id)
        {
            return default(bool);
        }

        public static bool ResetAllAisacControl(string name)
        {
            return default(bool);
        }

        public static void AttachAisac(int id, string globalAisacName)
        {
        }

        public static void AttachAisac(string name, string globalAisacName)
        {
        }

        public static void DetachAisac(int id, string globalAisacName)
        {
        }

        public static void DetachAisac(string name, string globalAisacName)
        {
        }

        public static void DetachAisacAll(int id)
        {
        }

        public static void DetachAisacAll(string name)
        {
        }

        public static int GetNumAttachedAisacs(int id)
        {
            return default(int);
        }

        public static int GetNumAttachedAisacs(string name)
        {
            return default(int);
        }

        public static int GetNumCuePlayingCount(int id)
        {
            return default(int);
        }

        public static int GetNumCuePlayingCount(string name)
        {
            return default(int);
        }

        [PreserveSig]
        private static extern void criAtomExCategory_SetVolumeByName(string name, float volume);
        [PreserveSig]
        private static extern float criAtomExCategory_GetVolumeByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_SetVolumeById(int id, float volume);
        [PreserveSig]
        private static extern float criAtomExCategory_GetVolumeById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_MuteById(int id, bool mute);
        [PreserveSig]
        private static extern bool criAtomExCategory_IsMutedById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_MuteByName(string name, bool mute);
        [PreserveSig]
        private static extern bool criAtomExCategory_IsMutedByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume);
        [PreserveSig]
        private static extern bool criAtomExCategory_IsSoloedById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume);
        [PreserveSig]
        private static extern bool criAtomExCategory_IsSoloedByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_PauseById(int id, bool pause);
        [PreserveSig]
        private static extern bool criAtomExCategory_IsPausedById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_PauseByName(string name, bool pause);
        [PreserveSig]
        private static extern bool criAtomExCategory_IsPausedByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value);
        [PreserveSig]
        private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value);
        [PreserveSig]
        private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter);
        [PreserveSig]
        private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter);
        [PreserveSig]
        private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo);
        [PreserveSig]
        private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo);
        [PreserveSig]
        private static extern bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value);
        [PreserveSig]
        private static extern ReactStatus criAtomExCategory_GetReactStatus(string react_name);
        [PreserveSig]
        private static extern float criAtomExCategory_GetTotalVolumeById(int id);
        [PreserveSig]
        private static extern float criAtomExCategory_GetTotalVolumeByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_SetFadeInTimeById(int id, ushort ms);
        [PreserveSig]
        private static extern void criAtomExCategory_SetFadeInTimeByName(string name, ushort ms);
        [PreserveSig]
        private static extern void criAtomExCategory_SetFadeOutTimeById(int id, ushort ms);
        [PreserveSig]
        private static extern void criAtomExCategory_SetFadeOutTimeByName(string name, ushort ms);
        [PreserveSig]
        private static extern bool criAtomExCategory_ResetAllAisacControlById(int category_id);
        [PreserveSig]
        private static extern bool criAtomExCategory_ResetAllAisacControlByName(string category_name);
        [PreserveSig]
        private static extern void criAtomExCategory_AttachAisacById(int id, string global_aisac_name);
        [PreserveSig]
        private static extern void criAtomExCategory_AttachAisacByName(string name, string global_aisac_name);
        [PreserveSig]
        private static extern void criAtomExCategory_DetachAisacById(int id, string global_aisac_name);
        [PreserveSig]
        private static extern void criAtomExCategory_DetachAisacByName(string name, string global_aisac_name);
        [PreserveSig]
        private static extern void criAtomExCategory_DetachAisacAllById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_DetachAisacAllByName(string name);
        [PreserveSig]
        private static extern int criAtomExCategory_GetNumAttachedAisacsById(int id);
        [PreserveSig]
        private static extern int criAtomExCategory_GetNumAttachedAisacsByName(string name);
        [PreserveSig]
        private static extern int criAtomExCategory_GetNumCuePlayingCountById(int id);
        [PreserveSig]
        private static extern int criAtomExCategory_GetNumCuePlayingCountByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_StopById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_StopByName(string name);
        [PreserveSig]
        private static extern void criAtomExCategory_StopWithoutReleaseTimeById(int id);
        [PreserveSig]
        private static extern void criAtomExCategory_StopWithoutReleaseTimeByName(string name);
    }
}
