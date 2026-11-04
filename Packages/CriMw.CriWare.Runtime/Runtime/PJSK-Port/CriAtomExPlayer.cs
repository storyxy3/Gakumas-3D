using System;

namespace CriWare
{
    // CriWare.CriAtomExPlayer (TypeDefIndex 31791), the members on the game's paths (CriAtomSource, the SekaiAtom
    // timeline track, CP.CRI CriCorePlayer). The beat-sync/sequence callback fields are only assigned by the
    // OnBeatSyncCallback/OnSequenceCallback events, which nothing on those paths subscribes to, so they are typed as
    // Delegate and stay null.
    public partial class CriAtomExPlayer : CriDisposable
    {
        public enum Status
        {
            Stop = 0,
            Prep = 1,
            Playing = 2,
            PlayEnd = 3,
            Error = 4
        }

        // Public here (internal in the game) because ICriWareNativeBackend.criAtomExPlayer_Create takes it.
        public struct Config
        {
            public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod;
            public int maxPathStrings;
            public int maxPath;
            public int maxAisacs;
            public bool updatesTime;
            public bool enableAudioSyncedTimer;
        }

        private Delegate _onBeatSyncCallback;
        private Delegate _onSequenceCallback;
        private bool hasExistingNativeHandle;
        private IntPtr entryPoolHandle = IntPtr.Zero;
        private int _entryPoolCapacity;
        private int max_path;
        public static readonly uint MaxOutputPorts = 8;
        private IntPtr handle = IntPtr.Zero;

        public IntPtr nativeHandle => handle;

        public bool isAvailable => handle != IntPtr.Zero;

        public int entryPoolCapacity => _entryPoolCapacity;

        public CriAtomExPlayer()
            : this(0, 0, false, IntPtr.Zero)
        {
        }

        public CriAtomExPlayer(int maxPath, int maxPathStrings)
            : this(maxPath, maxPathStrings, false, IntPtr.Zero)
        {
        }

        public CriAtomExPlayer(bool enableAudioSyncedTimer)
            : this(0, 0, enableAudioSyncedTimer, IntPtr.Zero)
        {
        }

        public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer)
            : this(maxPath, maxPathStrings, enableAudioSyncedTimer, IntPtr.Zero)
        {
        }

        public CriAtomExPlayer(IntPtr existingNativeHandle)
            : this(0, 0, false, existingNativeHandle)
        {
        }

        public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle)
        {
            if (!CriAtomPlugin.IsLibraryInitialized())
                throw new Exception("CriAtomPlugin is not initialized.");
            Config config;
            config.voiceAllocationMethod = CriAtomEx.VoiceAllocationMethod.Once;
            config.maxPath = maxPath;
            config.maxPathStrings = maxPathStrings;
            config.enableAudioSyncedTimer = enableAudioSyncedTimer;
            config.updatesTime = true;
            config.maxAisacs = 8;
            hasExistingNativeHandle = existingNativeHandle != IntPtr.Zero;
            if (hasExistingNativeHandle)
            {
                handle = existingNativeHandle;
            }
            else
            {
                handle = criAtomExPlayer_Create(ref config, IntPtr.Zero, 0);
                max_path = config.maxPath;
            }
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Atom);
        }

        public override void Dispose()
        {
            CriDisposableObjectManager.Unregister(this);
            if (entryPoolHandle != IntPtr.Zero)
            {
                StopWithoutReleaseTime();
                CRIWAREE3EC6941(entryPoolHandle);
            }
            entryPoolHandle = IntPtr.Zero;
            _entryPoolCapacity = 0;
            if (!hasExistingNativeHandle && handle != IntPtr.Zero)
                criAtomExPlayer_Destroy(handle);
            if (_onBeatSyncCallback != null)
            {
                // The game also removes its chain handler from CriAtom.OnBeatSyncCallback here; that handler is only
                // added together with _onBeatSyncCallback, which nothing on the ported paths sets.
                _onBeatSyncCallback = null;
            }
            handle = IntPtr.Zero;
            GC.SuppressFinalize(this);
        }

        public void SetCue(CriAtomExAcb acb, string name)
        {
            criAtomExPlayer_SetCueName(handle, acb != null ? acb.nativeHandle : IntPtr.Zero, name);
        }

        public CriAtomExPlayback Start()
        {
            if (entryPoolHandle != IntPtr.Zero)
                CRIWARED9B89F57(entryPoolHandle);
            return new CriAtomExPlayback(criAtomExPlayer_Start(handle));
        }

        public void Stop()
        {
            if (handle != IntPtr.Zero)
            {
                criAtomExPlayer_Stop(handle);
                CRIWARE6BA643AC(entryPoolHandle);
            }
        }

        public void StopWithoutReleaseTime()
        {
            if (handle != IntPtr.Zero)
            {
                criAtomExPlayer_StopWithoutReleaseTime(handle);
                CRIWARE6BA643AC(entryPoolHandle);
            }
        }

        public void Stop(bool ignoresReleaseTime)
        {
            if (handle != IntPtr.Zero)
            {
                if (ignoresReleaseTime)
                    criAtomExPlayer_StopWithoutReleaseTime(handle);
                else
                    criAtomExPlayer_Stop(handle);
                if (entryPoolHandle != IntPtr.Zero)
                    CRIWARE6BA643AC(entryPoolHandle);
            }
        }

        // 0x66C4A44: Pause() is criAtomExPlayer_Pause(handle, true).
        public void Pause()
        {
            criAtomExPlayer_Pause(handle, true);
        }

        // 0x66C9BC4
        public void Pause(bool sw)
        {
            criAtomExPlayer_Pause(handle, sw);
        }

        // 0x66C4B24
        public void Resume(CriAtomEx.ResumeMode mode)
        {
            criAtomExPlayer_Resume(handle, mode);
        }

        // 0x66C4C10
        public bool IsPaused()
        {
            return criAtomExPlayer_IsPaused(handle);
        }

        public void SetVolume(float volume)
        {
            criAtomExPlayer_SetVolume(handle, volume);
        }

        public void SetPitch(float pitch)
        {
            criAtomExPlayer_SetPitch(handle, pitch);
        }

        public void SetAisacControl(string controlName, float value)
        {
            criAtomExPlayer_SetAisacControlByName(handle, controlName, value);
        }

        public void Set3dSource(CriAtomEx3dSource source)
        {
            criAtomExPlayer_Set3dSourceHn(handle, source != null ? source.nativeHandle : IntPtr.Zero);
        }

        public void Set3dListener(CriAtomEx3dListener listener)
        {
            criAtomExPlayer_Set3dListenerHn(handle, listener != null ? listener.nativeHandle : IntPtr.Zero);
        }

        public void SetStartTime(long startTimeMs)
        {
            criAtomExPlayer_SetStartTime(handle, startTimeMs);
        }

        public void SetVoicePriority(int priority)
        {
            criAtomExPlayer_SetVoicePriority(handle, priority);
        }

        public void AttachFader()
        {
            criAtomExPlayer_AttachFader(handle, IntPtr.Zero, IntPtr.Zero, 0);
        }

        public void SetFadeOutTime(int ms)
        {
            criAtomExPlayer_SetFadeOutTime(handle, ms);
        }

        public void SetFadeInTime(int ms)
        {
            criAtomExPlayer_SetFadeInTime(handle, ms);
        }

        public bool IsFading()
        {
            return criAtomExPlayer_IsFading(handle);
        }

        public void Update(CriAtomExPlayback playback)
        {
            criAtomExPlayer_Update(handle, playback.id);
        }

        public void UpdateAll()
        {
            criAtomExPlayer_UpdateAll(handle);
        }

        public Status GetStatus()
        {
            return criAtomExPlayer_GetStatus(handle);
        }

        public void Loop(bool sw)
        {
            if (sw)
            {
                criAtomExPlayer_LimitLoopCount(handle, -3);
            }
            else
            {
                var loopCountParameterId = CriAtomPlugin.GetLoopCountParameterId();
                criAtomExPlayerParameter_RemoveParameter(criAtomExPlayer_GetPlayerParameter(handle),
                    loopCountParameterId);
            }
        }

        public void SetPanType(CriAtomEx.PanType panType)
        {
            criAtomExPlayer_SetPanType(handle, panType);
        }

        public void SetSoundRendererType(CriAtomEx.SoundRendererType type)
        {
            criAtomExPlayer_SetSoundRendererType(handle, type);
        }

        ~CriAtomExPlayer()
        {
            Dispose();
        }

        private static IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size) =>
            CriWareNative.Native.criAtomExPlayer_Create(ref config, work, work_size);
        private static void criAtomExPlayer_Destroy(IntPtr player) => CriWareNative.Native.criAtomExPlayer_Destroy(player);
        private static void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name) =>
            CriWareNative.Native.criAtomExPlayer_SetCueName(player, acb_hn, cue_name);
        private static uint criAtomExPlayer_Start(IntPtr player) => CriWareNative.Native.criAtomExPlayer_Start(player);
        private static void criAtomExPlayer_Stop(IntPtr player) => CriWareNative.Native.criAtomExPlayer_Stop(player);
        private static void criAtomExPlayer_Pause(IntPtr player, bool sw) => CriWareNative.Native.criAtomExPlayer_Pause(player, sw);
        private static void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode) =>
            CriWareNative.Native.criAtomExPlayer_Resume(player, mode);
        private static bool criAtomExPlayer_IsPaused(IntPtr player) => CriWareNative.Native.criAtomExPlayer_IsPaused(player);
        private static void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player) =>
            CriWareNative.Native.criAtomExPlayer_StopWithoutReleaseTime(player);
        private static Status criAtomExPlayer_GetStatus(IntPtr player) =>
            CriWareNative.Native.criAtomExPlayer_GetStatus(player);
        private static void criAtomExPlayer_SetVolume(IntPtr player, float volume) =>
            CriWareNative.Native.criAtomExPlayer_SetVolume(player, volume);
        private static void criAtomExPlayer_SetPitch(IntPtr player, float pitch) =>
            CriWareNative.Native.criAtomExPlayer_SetPitch(player, pitch);
        private static void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name,
            float control_value) =>
            CriWareNative.Native.criAtomExPlayer_SetAisacControlByName(player, control_name, control_value);
        private static void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source) =>
            CriWareNative.Native.criAtomExPlayer_Set3dSourceHn(player, source);
        private static void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener) =>
            CriWareNative.Native.criAtomExPlayer_Set3dListenerHn(player, listener);
        private static void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms) =>
            CriWareNative.Native.criAtomExPlayer_SetStartTime(player, start_time_ms);
        private static void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority) =>
            CriWareNative.Native.criAtomExPlayer_SetVoicePriority(player, priority);
        private static void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size) =>
            CriWareNative.Native.criAtomExPlayer_AttachFader(player, config, work, work_size);
        private static void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms) =>
            CriWareNative.Native.criAtomExPlayer_SetFadeOutTime(player, ms);
        private static void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms) =>
            CriWareNative.Native.criAtomExPlayer_SetFadeInTime(player, ms);
        private static bool criAtomExPlayer_IsFading(IntPtr player) => CriWareNative.Native.criAtomExPlayer_IsFading(player);
        private static void criAtomExPlayer_Update(IntPtr player, uint id) =>
            CriWareNative.Native.criAtomExPlayer_Update(player, id);
        private static void criAtomExPlayer_UpdateAll(IntPtr player) => CriWareNative.Native.criAtomExPlayer_UpdateAll(player);
        private static void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type) =>
            CriWareNative.Native.criAtomExPlayer_SetSoundRendererType(player, type);
        private static void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType type) =>
            CriWareNative.Native.criAtomExPlayer_SetPanType(player, type);
        private static void criAtomExPlayer_LimitLoopCount(IntPtr player, int count) =>
            CriWareNative.Native.criAtomExPlayer_LimitLoopCount(player, count);
        private static IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player) =>
            CriWareNative.Native.criAtomExPlayer_GetPlayerParameter(player);
        private static void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, uint id) =>
            CriWareNative.Native.criAtomExPlayerParameter_RemoveParameter(player_parameter, id);
        private static void CRIWARE6BA643AC(IntPtr pool) => CriWareNative.Native.CRIWARE6BA643AC(pool);
        private static void CRIWARED9B89F57(IntPtr pool) => CriWareNative.Native.CRIWARED9B89F57(pool);
        private static void CRIWAREE3EC6941(IntPtr pool) => CriWareNative.Native.CRIWAREE3EC6941(pool);
    }
}
