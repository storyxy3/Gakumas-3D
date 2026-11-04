// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public static partial class CriAtomExCategory
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
    }
}
