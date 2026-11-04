namespace CriWare
{
    // CriWare.CriAtomExPlayback (TypeDefIndex 31786): a playback id returned by CriAtomExPlayer.Start.
    public partial struct CriAtomExPlayback
    {
        public enum Status
        {
            Prep = 1,
            Playing = 2,
            Removed = 3
        }

        public const uint invalidId = 4294967295;

        public uint id { get; private set; }

        public Status status => GetStatus();

        // 0x66C262C / 0x66C2634
        public long time => GetTime();

        public long timeSyncedWithAudio => GetTimeSyncedWithAudio();

        public CriAtomExPlayback(uint id)
        {
            this.id = id;
        }

        public Status GetStatus()
        {
            return (Status)criAtomExPlayback_GetStatus(id);
        }

        public void Stop()
        {
            if (CriAtomPlugin.IsLibraryInitialized())
                criAtomExPlayback_Stop(id);
        }

        public void StopWithoutReleaseTime()
        {
            if (CriAtomPlugin.IsLibraryInitialized())
                criAtomExPlayback_StopWithoutReleaseTime(id);
        }

        // 0x66C2714: the obsolete Pause(bool) forwards to criAtomExPlayback_Pause.
        public void Pause(bool sw)
        {
            criAtomExPlayback_Pause(id, sw);
        }

        // 0x66C1D38
        public void Pause()
        {
            criAtomExPlayback_Pause(id, true);
        }

        // 0x66C1DC8
        public void Resume(CriAtomEx.ResumeMode mode)
        {
            criAtomExPlayback_Resume(id, mode);
        }

        // 0x66C1E54
        public bool IsPaused()
        {
            return criAtomExPlayback_IsPaused(id);
        }

        // 0x66C1FF8
        public long GetTime()
        {
            return criAtomExPlayback_GetTime(id);
        }

        // 0x66C207C
        public long GetTimeSyncedWithAudio()
        {
            return criAtomExPlayback_GetTimeSyncedWithAudio(id);
        }

        public void GetTimeAndScaleSyncedWithAudio(ref long playbackTime, ref float timeScale)
        {
            criAtomExPlayback_GetTimeAndScaleSyncedWithAudio(id, ref playbackTime, ref timeScale);
        }

        private static void criAtomExPlayback_Pause(uint id, bool sw) => CriWareNative.Native.criAtomExPlayback_Pause(id, sw);
        private static void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode) =>
            CriWareNative.Native.criAtomExPlayback_Resume(id, mode);
        private static bool criAtomExPlayback_IsPaused(uint id) => CriWareNative.Native.criAtomExPlayback_IsPaused(id);
        private static long criAtomExPlayback_GetTime(uint id) => CriWareNative.Native.criAtomExPlayback_GetTime(id);
        private static long criAtomExPlayback_GetTimeSyncedWithAudio(uint id) =>
            CriWareNative.Native.criAtomExPlayback_GetTimeSyncedWithAudio(id);
        private static int criAtomExPlayback_GetStatus(uint id) => CriWareNative.Native.criAtomExPlayback_GetStatus(id);
        private static void criAtomExPlayback_Stop(uint id) => CriWareNative.Native.criAtomExPlayback_Stop(id);
        private static void criAtomExPlayback_StopWithoutReleaseTime(uint id) =>
            CriWareNative.Native.criAtomExPlayback_StopWithoutReleaseTime(id);
        private static void criAtomExPlayback_GetTimeAndScaleSyncedWithAudio(uint id, ref long playbackTime,
            ref float timeScale) =>
            CriWareNative.Native.criAtomExPlayback_GetTimeAndScaleSyncedWithAudio(id, ref playbackTime, ref timeScale);
    }
}
