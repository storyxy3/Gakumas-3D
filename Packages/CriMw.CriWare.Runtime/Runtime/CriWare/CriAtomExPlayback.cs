namespace CriWare
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    public struct CriAtomExPlayback
    {
        public enum Status
        {
            Prep = 1,
            Playing,
            Removed
        }

        public struct TrackInfo
        {
            public uint id;
            public CriAtomEx.CueType sequenceType;
            public IntPtr playerHn;
            public ushort trackNo;
            public ushort reserved;
        }

        [CompilerGenerated]
        private uint _003Cid_003Ek__BackingField;
        public const uint invalidId = 4294967295u;
        public uint id
        {
            [CompilerGenerated]
            readonly get
            {
                return default(uint);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Status status
        {
            get
            {
                return default(Status);
            }
        }

        public long time
        {
            get
            {
                return default(long);
            }
        }

        public long timeSyncedWithAudio
        {
            get
            {
                return default(long);
            }
        }

        public CriAtomExPlayback(uint id)
        {
            this = default;
        }

        public void Stop(bool ignoresReleaseTime)
        {
        }

        public void Pause()
        {
        }

        public void Resume(CriAtomEx.ResumeMode mode)
        {
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public bool GetFormatInfo(out CriAtomEx.FormatInfo info)
        {
            throw null;
        }

        public Status GetStatus()
        {
            return default(Status);
        }

        public long GetTime()
        {
            return default(long);
        }

        public long GetTimeSyncedWithAudio()
        {
            return default(long);
        }

        public bool GetNumPlayedSamples(out long numSamples, out int samplingRate)
        {
            throw null;
        }

        public long GetSequencePosition()
        {
            return default(long);
        }

        public int GetCurrentBlockIndex()
        {
            return default(int);
        }

        public bool GetTrackInfo(out TrackInfo info)
        {
            throw null;
        }

        public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info)
        {
            throw null;
        }

        public void SetNextBlockIndex(int index)
        {
        }

        public bool SetBeatSyncOffset(short timeMs)
        {
            return default(bool);
        }

        public void Stop()
        {
        }

        public void StopWithoutReleaseTime()
        {
        }

        public void Pause(bool sw)
        {
        }

        [PreserveSig]
        private static extern void criAtomExPlayback_Stop(uint id);
        [PreserveSig]
        private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id);
        [PreserveSig]
        private static extern void criAtomExPlayback_Pause(uint id, bool sw);
        [PreserveSig]
        private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode);
        [PreserveSig]
        private static extern bool criAtomExPlayback_IsPaused(uint id);
        [PreserveSig]
        private static extern Status criAtomExPlayback_GetStatus(uint id);
        [PreserveSig]
        private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info);
        [PreserveSig]
        private static extern long criAtomExPlayback_GetTime(uint id);
        [PreserveSig]
        private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id);
        [PreserveSig]
        private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate);
        [PreserveSig]
        private static extern long criAtomExPlayback_GetSequencePosition(uint id);
        [PreserveSig]
        private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index);
        [PreserveSig]
        private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id);
        [PreserveSig]
        private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info);
        [PreserveSig]
        private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info);
        [PreserveSig]
        private static extern bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs);
    }
}
