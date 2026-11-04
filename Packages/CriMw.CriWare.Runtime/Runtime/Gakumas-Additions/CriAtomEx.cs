// Gakumas (CriWare 2.44.49) nested types missing from the PJSK port, copied from the DummyDll skeleton.
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare
{
    public static partial class CriAtomEx
    {

        public enum CharacterEncoding
        {
            Utf8,
            Sjis
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



        public enum Randomize3dParamType
        {
            None,
            Width,
            Depth,
            Height,
            Radius
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



        public struct CueLinkInfo
        {
            public IntPtr nativePlayerHn;
            public uint basePlaybackId;
            public uint targetPlaybackId;
            public int cueLinkType;
        }



        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CueLinkCbFunc(ref CueLinkInfo info);
    }
}
