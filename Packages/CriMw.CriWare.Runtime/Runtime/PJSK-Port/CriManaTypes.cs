using System;
using System.Runtime.InteropServices;

namespace CriWare.CriMana
{
    // CriWare.CriMana.CodecType.
    public enum CodecType
    {
        Unknown = 0,
        SofdecPrime = 1,
        H264 = 5,
        VP9 = 9
    }

    // CriWare.CriMana.AlphaType.
    public enum AlphaType
    {
        CompoOpaq = 0,
        CompoAlphaFull = 1,
        CompoAlpha3Step = 2,
        CompoAlpha32Bit = 3
    }

    // CriWare.CriMana.AudioInfo (TypeDefIndex 31948).
    [StructLayout(LayoutKind.Sequential)]
    public struct AudioInfo
    {
        public uint samplingRate;
        public uint numChannels;
        public uint totalSamples;
    }

    // CriWare.CriMana.MovieInfo (TypeDefIndex 31949): filled by the native player (criManaUnityPlayer_GetMovieInfo).
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial class MovieInfo
    {
        internal uint _reserved1;
        public uint numAlphaStreams;
        public uint width;
        public uint height;
        public uint dispWidth;
        public uint dispHeight;
        public uint framerateN;
        public uint framerateD;
        public uint totalFrames;
        public CodecType codecType;
        public CodecType alphaCodecType;
        public uint numAudioStreams;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public AudioInfo[] audioPrm;
        public uint numSubtitleChannels;
        public uint maxSubtitleSize;
        public uint maxChunkSize;
    }

    // CriWare.CriMana.FrameInfo (TypeDefIndex 31950): filled by the native player for each decoded frame.
    [StructLayout(LayoutKind.Sequential)]
    public partial class FrameInfo
    {
        public int frameNo;
        public int frameNoPerFile;
        public uint width;
        public uint height;
        public uint dispWidth;
        public uint dispHeight;
        public uint numImages;
        public uint framerateN;
        public uint framerateD;
        private uint _reserved1;
        public ulong time;
        public ulong tunit;
        public uint cntConcatenatedMovie;
        private AlphaType alphaType;
        public uint cntSkippedFrames;
        public uint totalFramesPerFile;
    }

    // CriWare.CriMana.EventPoint (TypeDefIndex 31951): a cue point passed to Player.cuePointCallback.
    [StructLayout(LayoutKind.Sequential)]
    public struct EventPoint
    {
        public IntPtr cueName;
        public uint cueNameSize;
        public ulong time;
        public ulong tunit;
        public int type;
        public IntPtr paramString;
        public uint paramStringSize;
        public uint cntCallback;
    }
}
