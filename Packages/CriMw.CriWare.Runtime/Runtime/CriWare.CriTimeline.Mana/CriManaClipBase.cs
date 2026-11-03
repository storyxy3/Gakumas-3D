namespace CriWare.CriTimeline.Mana
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare.CriMana;
    using global::CriWare.CriTimeline.Mana;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset
    {
        private struct MovieInfoStruct
        {
            public uint width;
            public uint height;
            public uint dispWidth;
            public uint dispHeight;
            public uint framerateN;
            public uint framerateD;
            public uint totalFrames;
            public CodecType _codecType;
            public CodecType _alphaCodecType;
        }

        public readonly Guid guid;
        public bool m_loopWithinClip;
        public bool m_useOnMemoryPlayback;
        public GCHandle gcHandle;
        [SerializeField]
        private double m_movieFrameRate;
        [SerializeField]
        private double m_clipDuration;
        public float m_fadeinDuration;
        public AnimationCurve m_fadeinCurve;
        public float m_fadeoutDuration;
        public AnimationCurve m_fadeoutCurve;
        public bool m_fadeAudio;
        [NonSerialized]
        public TimelineClip m_clip;
        private MovieInfoStruct? m_movieInfoStruct;
        public abstract string MoviePath { get; }
        public abstract byte[] MovieData { get; }
        public abstract string MovieName { get; }
        public abstract int DataId { get; }

        public ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public bool IsMovieInfoReady
        {
            get
            {
                return default(bool);
            }
        }

        public override double duration
        {
            get
            {
                return default(double);
            }
        }

        private MovieInfoStruct? StructToMovieInfo(MovieInfo movieInfo)
        {
            return null;
        }

        public void ReplaceMovieInfo(MovieInfo movieInfo)
        {
        }

        public bool IsSameMovie(MovieInfo movieInfo)
        {
            return default(bool);
        }

        public int GetSeekFrame(double seekTimeSec, bool loop)
        {
            return default(int);
        }

        protected CriManaClipBase()
        {
        }
    }
}
