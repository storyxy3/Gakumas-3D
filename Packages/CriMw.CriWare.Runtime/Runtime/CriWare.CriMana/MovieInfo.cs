namespace CriWare.CriMana
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare.CriMana;

    [Serializable]
    [StructLayout((LayoutKind)0)]
    public class MovieInfo
    {
        private uint _reserved1;
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
        public AudioInfo[] audioPrm;
        public uint numSubtitleChannels;
        public uint maxSubtitleSize;
        public uint maxChunkSize;
        public bool hasAlpha
        {
            get
            {
                return default(bool);
            }

            internal set
            {
            }
        }

        public MovieInfo()
        {
        }
    }
}
