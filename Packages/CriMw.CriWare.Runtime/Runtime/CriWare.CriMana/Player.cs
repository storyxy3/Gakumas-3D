namespace CriWare.CriMana
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::AOT;
    using global::CriWare;
    using global::CriWare.CriMana;
    using global::CriWare.CriMana.Detail;
    using global::UnityEngine;

    public class Player : CriDisposable
    {
        public enum Status
        {
            Stop,
            Dechead,
            WaitPrep,
            Prep,
            Ready,
            Playing,
            PlayEnd,
            Error,
            StopProcessing,
            ReadyForRendering
        }

        public enum SetMode
        {
            New,
            Append,
            AppendRepeatedly
        }

        public enum MovieEventSyncMode
        {
            FrameTime,
            PlayBackTime
        }

        public enum AudioTrack
        {
            Off,
            Auto
        }

        public enum TimerType
        {
            None,
            System,
            Audio,
            User,
            Manual
        }

        public delegate void CuePointCallback(ref EventPoint eventPoint);
        public delegate void StatusChangeCallback(Status status);
        public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer);
        public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, [In] ref EventPoint eventPoint);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void SubtitleCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2);
        public enum CriManaUnityPlayer_RenderEventAction
        {
            UPDATE = 0,
            INITIALIZE = 256,
            RENDER = 512,
            DESTROY = 768
        }

        [CompilerGenerated]
        private sealed class _003CIssuePluginUpdatesForFrames_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public Player _003C_003E4__this;
            public int playerId;
            public int frameCount;
            public bool destroy;
            public MonoBehaviour playerHolder;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CIssuePluginUpdatesForFrames_003Ed__157(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        private const int InvalidPlayerId = -1;
        private static Player updatingPlayer;
        private int playerId;
        private bool isDisposed;
        private Status internalrequiredStatus;
        private Status _nativeStatus;
        private Status? lastNativeStatus;
        private Status? lastPlayerStatus;
        private bool wasStopping;
        private bool isPreparingForRendering;
        private bool isNativeStartInvoked;
        private bool isNativeInitialized;
        private RendererResource rendererResource;
        private MovieInfo _movieInfo;
        private FrameInfo _frameInfo;
        private bool isMovieInfoAvailable;
        private bool isFrameInfoAvailable;
        private ShaderDispatchCallback _shaderDispatchCallback;
        private bool enableSubtitle;
        private int subtitleBufferSize;
        private uint droppedFrameCount;
        private CriAtomExPlayer _atomExPlayer;
        private CriAtomExPlayer _subAtomExPlayer;
        private CriAtomExPlayer _extraAtomExPlayer;
        private CriAtomEx3dSource _atomEx3Dsource;
        private TimerType _timerType;
        private bool isStoppingForSeek;
        public CuePointCallback cuePointCallback;
        public StatusChangeCallback statusChangeCallback;
        [CompilerGenerated]
        private SubtitleChangeCallback m_OnSubtitleChanged;
        [CompilerGenerated]
        private bool _003CadditiveMode_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CmaxFrameDrop_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CapplyTargetAlpha_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CuiRenderMode_003Ek__BackingField;
        [CompilerGenerated]
        private IntPtr _003CsubtitleBuffer_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CsubtitleSize_003Ek__BackingField;
        [CompilerGenerated]
        private CriManaMoviePlayerHolder _003CplayerHolder_003Ek__BackingField;
        private Status requiredStatus
        {
            get
            {
                return default(Status);
            }

            set
            {
            }
        }

        public bool additiveMode
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int maxFrameDrop
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool applyTargetAlpha
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool uiRenderMode
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool isFrameAvailable
        {
            get
            {
                return default(bool);
            }
        }

        public MovieInfo movieInfo
        {
            get
            {
                return null;
            }
        }

        public FrameInfo frameInfo
        {
            get
            {
                return null;
            }
        }

        public Status status
        {
            get
            {
                return default(Status);
            }
        }

        public Status nativeStatus
        {
            get
            {
                return default(Status);
            }
        }

        public int numberOfEntries
        {
            get
            {
                return default(int);
            }
        }

        public IntPtr subtitleBuffer
        {
            [CompilerGenerated]
            get
            {
                return default(IntPtr);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int subtitleSize
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CriAtomExPlayer atomExPlayer
        {
            get
            {
                return null;
            }
        }

        public CriAtomExPlayer subAtomExPlayer
        {
            get
            {
                return null;
            }
        }

        public CriAtomExPlayer extraAtomExPlayer
        {
            get
            {
                return null;
            }
        }

        public CriAtomEx3dSource atomEx3DsourceForAmbisonics
        {
            get
            {
                return null;
            }
        }

        public TimerType timerType
        {
            get
            {
                return default(TimerType);
            }
        }

        public CriManaMoviePlayerHolder playerHolder
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool isAlive
        {
            get
            {
                return default(bool);
            }
        }

        public event SubtitleChangeCallback OnSubtitleChanged
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public Player()
        {
        }

        public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length)
        {
        }

        ~Player()
        {
        }

        public override void Dispose()
        {
        }

        public void CreateRendererResource(int width, int height, bool alpha)
        {
        }

        public void DisposeRendererResource()
        {
        }

        public void Prepare()
        {
        }

        public void PrepareForRendering()
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void StopForSeek()
        {
        }

        public void Pause(bool sw)
        {
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }

        public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }

        [Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
        public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }

        public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }

        public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New)
        {
            return default(bool);
        }

        public void Loop(bool sw)
        {
        }

        public void SetAudioBaseConcatenation(bool enabled)
        {
        }

        public void SetMasterTimerType(TimerType timerType)
        {
        }

        public void SetSeekPosition(int frameNumber)
        {
        }

        public void SetMovieEventSyncMode(MovieEventSyncMode mode)
        {
        }

        public void SetSpeed(float speed)
        {
        }

        public void SetMaxPictureDataSize(uint maxDataSize)
        {
        }

        public void SetBufferingTime(float sec)
        {
        }

        public void SetMinBufferSize(int min_buffer_size)
        {
        }

        public void SetAudioTrack(int track)
        {
        }

        public void SetAudioTrack(AudioTrack track)
        {
        }

        public void SetSubAudioTrack(int track)
        {
        }

        public void SetSubAudioTrack(AudioTrack track)
        {
        }

        public void SetExtraAudioTrack(int track)
        {
        }

        public void SetExtraAudioTrack(AudioTrack track)
        {
        }

        public void SetVolume(float volume)
        {
        }

        public float GetVolume()
        {
            return default(float);
        }

        public void SetSubAudioVolume(float volume)
        {
        }

        public float GetSubAudioVolume()
        {
            return default(float);
        }

        public void SetExtraAudioVolume(float volume)
        {
        }

        public float GetExtraAudioVolume()
        {
            return default(float);
        }

        public void SetBusSendLevel(string bus_name, float level)
        {
        }

        public void SetSubAudioBusSendLevel(string bus_name, float volume)
        {
        }

        public void SetExtraAudioBusSendLevel(string bus_name, float volume)
        {
        }

        public void SetSubtitleChannel(int channel)
        {
        }

        public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback)
        {
        }

        public long GetTime()
        {
            return default(long);
        }

        public int GetDisplayedFrameNo()
        {
            return default(int);
        }

        public bool HasRenderedNewFrame()
        {
            return default(bool);
        }

        public void SetAsrRackId(int asrRackId)
        {
        }

        public void SetTimeStretchQuality(float quality)
        {
        }

        public void SetDecryptionKey(ulong key)
        {
        }

        public void UpdateWithUserTime(ulong timeCount, ulong timeUnit)
        {
        }

        public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD)
        {
        }

        public void UpdateWithManualTimeAdvanced()
        {
        }

        public void Update()
        {
        }

        public void SyncMasterTimer()
        {
        }

        public void OnWillRenderObject(CriManaMovieMaterialBase sender)
        {
        }

        public bool UpdateMaterial(Material material)
        {
            return default(bool);
        }

        public void PauseOnApplicationPause(bool sw)
        {
        }

        public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction)
        {
        }

        private void Dispose(bool disposing)
        {
        }

        private void InternalUpdate()
        {
        }

        [IteratorStateMachine(typeof(_003CIssuePluginUpdatesForFrames_003Ed__157))]
        private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId)
        {
            return null;
        }

        private void DisableInfos(bool keepFrameInfo = false)
        {
        }

        private void PrepareNativePlayer()
        {
        }

        private void UpdateNativePlayer()
        {
        }

        private void InvokePlayerStatusCheck()
        {
        }

        private void AllocateSubtitleBuffer(int size)
        {
        }

        private void DeallocateSubtitleBuffer()
        {
        }

        internal void SetupPlayerHolder()
        {
        }

        [MonoPInvokeCallback(typeof(CuePointCallbackFromNativeDelegate))]
        private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, [In] ref EventPoint eventPoint)
        {
        }

        [MonoPInvokeCallback(typeof(SubtitleCallbackFromNativeDelegate))]
        private static void SubtitleCallbackFromNative(IntPtr ptr1, IntPtr ptr2)
        {
        }

        internal static int NativeMethods_GetNumberOfEntry(int playerId)
        {
            return default(int);
        }

        internal static int NativeMethods_Create()
        {
            return default(int);
        }

        internal static int NativeMethods_CreateWithParameters(bool useAtomExPlayer, uint maxPathLength)
        {
            return default(int);
        }

        internal static IntPtr NativeMethods_GetAtomExPlayerByTrackId(int player_id, uint track_id)
        {
            return default(IntPtr);
        }

        internal void NativeMethods_Stop(int player_id)
        {
        }

        internal void NativeMethods_Pause(int player_id, int sw)
        {
        }

        internal static bool NativeMethods_IsPaused(int player_id)
        {
            return default(bool);
        }

        internal static void NativeMethods_SetFile(int player_id, IntPtr binder, string path)
        {
        }

        internal static bool NativeMethods_EntryFile(int player_id, IntPtr binder, string path, bool repeat)
        {
            return default(bool);
        }

        internal static void NativeMethods_SetData(int player_id, IntPtr data, long datasize)
        {
        }

        internal static void NativeMethods_SetData(int player_id, byte[] data, long datasize)
        {
        }

        internal static bool NativeMethods_EntryData(int player_id, IntPtr data, long datasize, bool repeat)
        {
            return default(bool);
        }

        internal static bool NativeMethods_EntryData(int player_id, byte[] data, long datasize, bool repeat)
        {
            return default(bool);
        }

        internal static void NativeMethods_SetContentId(int player_id, IntPtr binder, int content_id)
        {
        }

        internal static bool NativeMethods_EntryContentId(int player_id, IntPtr binder, int content_id, bool repeat)
        {
            return default(bool);
        }

        internal static void NativeMethods_SetFileRange(int player_id, string path, ulong offset, long range)
        {
        }

        internal static bool NativeMethods_EntryFileRange(int player_id, string path, ulong offset, long range, bool repeat)
        {
            return default(bool);
        }

        internal void NativeMethods_Loop(int player_id, int sw)
        {
        }

        internal static void NativeMethods_SetAudioBaseConcatenation(int player_id, bool flag)
        {
        }

        internal static void NativeMethods_SetMasterTimerType(int player_id, TimerType timer_type)
        {
        }

        internal static void NativeMethods_SetSeekPosition(int player_id, int seek_frame_no)
        {
        }

        internal static void NativeMethods_SetMovieEventSyncMode(int player_id, MovieEventSyncMode mode)
        {
        }

        internal static void NativeMethods_SetSpeed(int player_id, float speed)
        {
        }

        internal static void NativeMethods_SetMaxPictureDataSize(int player_id, uint max_data_size)
        {
        }

        internal static void NativeMethods_SetBufferingTime(int player_id, float sec)
        {
        }

        internal static void NativeMethods_SetMinBufferSize(int player_id, int min_buffer_size)
        {
        }

        internal static void NativeMethods_SetAudioTrack(int player_id, int track)
        {
        }

        internal static void NativeMethods_SetSubAudioTrack(int player_id, int track)
        {
        }

        internal static void NativeMethods_SetExtraAudioTrack(int player_id, int track)
        {
        }

        internal static void NativeMethods_SetVolume(int player_id, float vol)
        {
        }

        internal static float NativeMethods_GetVolume(int player_id)
        {
            return default(float);
        }

        internal static void NativeMethods_SetSubAudioVolume(int player_id, float vol)
        {
        }

        internal static float NativeMethods_GetSubAudioVolume(int player_id)
        {
            return default(float);
        }

        internal static void NativeMethods_SetExtraAudioVolume(int player_id, float vol)
        {
        }

        internal static float NativeMethods_GetExtraAudioVolume(int player_id)
        {
            return default(float);
        }

        internal static void NativeMethods_SetBusSendLevelByName(int player_id, string bus_name, float level)
        {
        }

        internal static void NativeMethods_SetSubAudioBusSendLevelByName(int player_id, string bus_name, float level)
        {
        }

        internal static void NativeMethods_SetExtraAudioBusSendLevelByName(int player_id, string bus_name, float level)
        {
        }

        internal static void NativeMethods_SetSubtitleCallback(int player_id, SubtitleCallbackFromNativeDelegate cbfunc)
        {
        }

        internal static void NativeMethods_SetSubtitleChannel(int player_id, int channel)
        {
        }

        internal static long NativeMethods_GetTime(int player_id)
        {
            return default(long);
        }

        internal static int NativeMethods_GetDisplayedFrameNo(int player_id)
        {
            return default(int);
        }

        internal static void NativeMethods_SetAsrRackId(int player_id, int asr_rack_id)
        {
        }

        internal static void NativeMethods_SetTimeStretchQuality(int player_id, float quality)
        {
        }

        internal static void NativeMethods_SetUserTime(int player_id, ulong user_count, ulong user_unit)
        {
        }

        internal static void NativeMethods_SetManualTimerUnit(int player_id, ulong timer_unit_n, ulong timer_unit_d)
        {
        }

        internal static void NativeMethods_AdvanceManualTimer(int player_id)
        {
        }

        internal static void NativeMethods_SyncMasterTimer(int player_id)
        {
        }

        internal static IntPtr NativeMethods_GetRenderEventFunc()
        {
            return default(IntPtr);
        }

        internal static void NativeMethods_Destroy(int player_id)
        {
        }

        internal static void NativeMethods_SyncUpdate(int player_id)
        {
        }

        internal static void NativeMethods_GetMovieInfo(int player_id, [Out] MovieInfo movie_info)
        {
        }

        internal void NativeMethods_Start(int player_id)
        {
        }

        internal void NativeMethods_Prepare(int player_id)
        {
        }

        internal static int NativeMethods_Update(int player_id)
        {
            return default(int);
        }

        internal static void NativeMethods_SetCuePointCallback(int player_id, CuePointCallbackFromNativeDelegate cbfunc)
        {
        }

        internal static int NativeMethods_GetSubtitleOnTime(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size)
        {
            return default(int);
        }

        internal static void NativeMethods_SetDecryptionKey(int player_id, ulong key)
        {
        }

        [PreserveSig]
        internal static extern int CRIWARE475BF86E();
        [PreserveSig]
        internal static extern int CRIWAREE5A03CCE();
        [PreserveSig]
        internal static extern int CRIWAREB24ED750(bool useAtomExPlayer, uint maxPathLength);
        [PreserveSig]
        internal static extern void CRIWARE2A4ED1FF(int player_id);
        [PreserveSig]
        internal static extern void CRIWAREDF8F52BA(int player_id, IntPtr binder, string path);
        [PreserveSig]
        internal static extern void CRIWARE3B2D43C9(int player_id, IntPtr binder, int content_id);
        [PreserveSig]
        internal static extern void CRIWAREFF1DE7AB(int player_id, string path, ulong offset, long range);
        [PreserveSig]
        internal static extern void CRIWAREA380109E(int player_id, IntPtr data, long datasize);
        [PreserveSig]
        internal static extern void CRIWAREA380109E(int player_id, byte[] data, long datasize);
        [PreserveSig]
        internal static extern bool CRIWARE063F9CD6(int player_id, IntPtr binder, string path, bool repeat);
        [PreserveSig]
        internal static extern bool CRIWARE575DA4D3(int player_id, IntPtr binder, int content_id, bool repeat);
        [PreserveSig]
        internal static extern bool CRIWARE476D312C(int player_id, string path, ulong offset, long range, bool repeat);
        [PreserveSig]
        internal static extern bool CRIWAREE4CADDBF(int player_id, IntPtr data, long datasize, bool repeat);
        [PreserveSig]
        internal static extern bool CRIWAREE4CADDBF(int player_id, byte[] data, long datasize, bool repeat);
        [PreserveSig]
        internal static extern void CRIWAREA42870EE(int player_id);
        [PreserveSig]
        internal static extern int CRIWARE1EE934DC(int player_id);
        [PreserveSig]
        internal static extern void CRIWAREB3415BD1(int player_id, CuePointCallbackFromNativeDelegate cbfunc);
        [PreserveSig]
        internal static extern void CRIWARECBDDBFDE(int player_id, SubtitleCallbackFromNativeDelegate cbfunc);
        [PreserveSig]
        internal static extern void CRIWARE8AE2D116(int player_id, [Out] MovieInfo movie_info);
        [PreserveSig]
        internal static extern int CRIWARE3877C2D0(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE6F6F5ED6(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE8827FCD5(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE0F8FB788(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE859BCF67(int player_id, int seek_frame_no);
        [PreserveSig]
        internal static extern void CRIWARE8D0D011E(int player_id, MovieEventSyncMode mode);
        [PreserveSig]
        internal static extern void CRIWAREFD8970A0(int player_id, int sw);
        [PreserveSig]
        internal static extern bool CRIWARE8FC8AB6E(int player_id);
        [PreserveSig]
        internal static extern void CRIWARED473AD07(int player_id, int sw);
        [PreserveSig]
        internal static extern void CRIWARE31934366(int player_id, bool flag);
        [PreserveSig]
        internal static extern long CRIWARE5B7806CB(int player_id);
        [PreserveSig]
        internal static extern int CRIWAREF690CC8B(int player_id);
        [PreserveSig]
        internal static extern IntPtr CRIWAREE25E41A6(int player_id, uint track_id);
        [PreserveSig]
        internal static extern int CRIWARE74E28F8A(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE4D7061D4(int player_id, int track);
        [PreserveSig]
        internal static extern void CRIWARE0422E6E8(int player_id, float vol);
        [PreserveSig]
        internal static extern float CRIWAREAF011D79(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE612AF404(int player_id, int track);
        [PreserveSig]
        internal static extern void CRIWAREAF9A4734(int player_id, float vol);
        [PreserveSig]
        internal static extern float CRIWAREBC9CE189(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE1BD1C9B6(int player_id, int track);
        [PreserveSig]
        internal static extern void CRIWARE2D6D941C(int player_id, float vol);
        [PreserveSig]
        internal static extern float CRIWARE50B3D562(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE0B78E654(int player_id, string bus_name, float level);
        [PreserveSig]
        internal static extern void CRIWARE9E7102F4(int player_id, string bus_name, float level);
        [PreserveSig]
        internal static extern void CRIWAREDFFDA852(int player_id, string bus_name, float level);
        [PreserveSig]
        internal static extern void CRIWARE112B6E0A(int player_id, int channel);
        [PreserveSig]
        internal static extern int CRIWAREDDAD603D(int player_id, IntPtr subtitle_buffer, int subtitle_buffer_size);
        [PreserveSig]
        internal static extern void CRIWAREF95021CF(int player_id, float speed);
        [PreserveSig]
        internal static extern void CRIWARE87293984(int player_id, uint max_data_size);
        [PreserveSig]
        internal static extern void CRIWARE055B690C(int player_id, float sec);
        [PreserveSig]
        internal static extern void CRIWARE235E0536(int player_id, int min_buffer_size);
        [PreserveSig]
        internal static extern void CRIWARE3C9347E8(int player_id, int asr_rack_id);
        [PreserveSig]
        internal static extern void CRIWAREEF3782F9(int player_id, float quality);
        [PreserveSig]
        internal static extern void CRIWARED5FF6B61(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE14D1E6A6(int player_id, TimerType timer_type);
        [PreserveSig]
        internal static extern void CRIWARE9236C7AE(int player_id, ulong user_count, ulong user_unit);
        [PreserveSig]
        internal static extern void CRIWARE87BAA2D0(int player_id, ulong timer_unit_n, ulong timer_unit_d);
        [PreserveSig]
        internal static extern void CRIWARE30CC27A6(int player_id);
        [PreserveSig]
        internal static extern void CRIWARE64A1A3C1(int player_id);
        [PreserveSig]
        internal static extern void CRIWAREC2AB04BA(int player_id, ulong key);
        [PreserveSig]
        internal static extern IntPtr criWareUnity_GetRenderEventFunc();
    }
}
