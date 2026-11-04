using System;
using System.Collections;
using System.Runtime.InteropServices;
using AOT;
using CriWare.CriMana.Detail;
using UnityEngine;

namespace CriWare.CriMana
{
    // CriWare.CriMana.Player (TypeDefIndex 31966), the members on the StreamingLive paths (CriManaMovieMaterial and the
    // SekaiMana timeline). The native player (cri_ware_unity) and its render-thread events go through
    // ICriWareNativeBackend / GL.IssuePluginEvent as in the game.
    public partial class Player : CriDisposable
    {
        public enum Status
        {
            Stop = 0,
            Dechead = 1,
            WaitPrep = 2,
            Prep = 3,
            Ready = 4,
            Playing = 5,
            PlayEnd = 6,
            Error = 7,
            StopProcessing = 8,
            ReadyForRendering = 9
        }

        public enum TimerType
        {
            None = 0,
            System = 1,
            Audio = 2,
            User = 3,
            Manual = 4
        }

        public enum SetMode
        {
            New = 0,
            Append = 1,
            AppendRepeatedly = 2
        }

        public enum CriManaUnityPlayer_RenderEventAction
        {
            UPDATE = 0,
            INITIALIZE = 256,
            RENDER = 512,
            DESTROY = 768
        }

        public delegate void CuePointCallback(ref EventPoint eventPoint);

        public delegate void StatusChangeCallback(Status status);

        public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer);

        public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode);

        // Public here (private in the game) because ICriWareNativeBackend.CRIWARE8F47EE33 takes it.
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint);

        private const int InvalidPlayerId = -1;
        private static Player updatingPlayer;
        private int playerId = InvalidPlayerId;
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
        private MovieInfo _movieInfo = new MovieInfo();
        private FrameInfo _frameInfo = new FrameInfo();
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
        private TimerType _timerType = TimerType.Audio;
        private bool isStoppingForSeek;
        public CuePointCallback cuePointCallback;
        public StatusChangeCallback statusChangeCallback;

        // Raised by the subtitle update, which is not on the StreamingLive paths (no movie there has subtitles).
#pragma warning disable 0414
        public event SubtitleChangeCallback OnSubtitleChanged;
#pragma warning restore 0414

        public bool additiveMode { get; set; }

        public int maxFrameDrop { get; set; }

        public bool applyTargetAlpha { get; set; }

        public bool uiRenderMode { get; set; }

        public MovieInfo movieInfo => isMovieInfoAvailable ? _movieInfo : null;

        public FrameInfo frameInfo => isFrameInfoAvailable ? _frameInfo : null;

        public Status status
        {
            get
            {
                if (_nativeStatus == Status.Error)
                    return _nativeStatus;
                if (wasStopping)
                {
                    if (_nativeStatus != Status.Stop)
                        return Status.StopProcessing;
                    return internalrequiredStatus == Status.ReadyForRendering ? Status.Prep : Status.Stop;
                }
                if (internalrequiredStatus != Status.ReadyForRendering)
                {
                    if (_nativeStatus == Status.Ready)
                        return rendererResource != null ? Status.Ready : Status.Prep;
                    return _nativeStatus;
                }
                if (_nativeStatus != Status.Playing)
                    return Status.Prep;
                if (rendererResource == null)
                    return Status.Prep;
                return rendererResource.IsPrepared() ? Status.ReadyForRendering : Status.Prep;
            }
        }

        public IntPtr subtitleBuffer { get; private set; }

        public int subtitleSize { get; private set; }

        public CriAtomExPlayer atomExPlayer => _atomExPlayer;

        public CriManaMoviePlayerHolder playerHolder { get; set; }

        public bool isAlive => playerId != InvalidPlayerId;

        // CriManaMovieMaterialBase (PlayerManualUpdate) and CriManaAmbisonicSource read these fields directly in the
        // game build.
        internal TimerType timerType => _timerType;

        internal bool isFrameInfoAvailableForMaterial => isFrameInfoAvailable;

        internal CriAtomEx3dSource atomEx3Dsource => _atomEx3Dsource;

        public Player()
        {
            if (!CriManaPlugin.IsLibraryInitialized())
                throw new Exception("CriManaPlugin is not initialized.");
            playerId = CRIWARE069A61A1();
            additiveMode = false;
            maxFrameDrop = 0;
            SetupPlayerHolder();
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Mana);
        }

        public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length)
        {
            if (!CriManaPlugin.IsLibraryInitialized())
                throw new Exception("CriManaPlugin is not initialized.");
            if (max_path_length != 0 || advanced_audio_mode)
            {
                playerId = CRIWARED0162744(advanced_audio_mode, max_path_length);
                if (advanced_audio_mode)
                {
                    _atomExPlayer = new CriAtomExPlayer(criManaUnityPlayer_GetAtomExPlayerByTrackId(playerId, 0));
                    _subAtomExPlayer = new CriAtomExPlayer(criManaUnityPlayer_GetAtomExPlayerByTrackId(playerId, 1));
                    _extraAtomExPlayer = new CriAtomExPlayer(criManaUnityPlayer_GetAtomExPlayerByTrackId(playerId, 2));
                    if (ambisonics_mode)
                    {
                        _atomEx3Dsource = new CriAtomEx3dSource();
                        _atomExPlayer.Set3dSource(_atomEx3Dsource);
                        _atomExPlayer.SetPanType(CriAtomEx.PanType.Pos3d);
                        _atomExPlayer.UpdateAll();
                    }
                }
            }
            else
            {
                playerId = CRIWARE069A61A1();
            }
            additiveMode = false;
            maxFrameDrop = 0;
            SetupPlayerHolder();
            CriDisposableObjectManager.Register(this, CriDisposableObjectManager.ModuleType.Mana);
        }

        private void SetupPlayerHolder()
        {
            if (!Application.isPlaying)
                return;
            var gameObject = new GameObject("CriManaMovieResources");
            playerHolder = gameObject.AddComponent<CriManaMoviePlayerHolder>();
            playerHolder.player = this;
        }

        ~Player()
        {
            Dispose(false);
        }

        // Game behaviour kept: Dispose() passes disposing = false.
        public override void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (isDisposed)
                return;
            isDisposed = true;
            CriDisposableObjectManager.Unregister(this);
            var numberOfFrameBeforeDestroy = 0;
            if (rendererResource != null && playerId != InvalidPlayerId)
            {
                IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.DESTROY);
                numberOfFrameBeforeDestroy = rendererResource.GetNumberOfFrameBeforeDestroy(playerId);
            }
            DisposeRendererResource();
            DeallocateSubtitleBuffer();
            if (playerId != InvalidPlayerId)
            {
                if (_atomExPlayer != null)
                {
                    _atomExPlayer.Dispose();
                    _atomExPlayer = null;
                }
                if (_subAtomExPlayer != null)
                {
                    _subAtomExPlayer.Dispose();
                    _subAtomExPlayer = null;
                }
                if (_extraAtomExPlayer != null)
                {
                    _extraAtomExPlayer.Dispose();
                    _extraAtomExPlayer = null;
                }
                CRIWARE0554C38E(playerId);
                if (_atomEx3Dsource != null)
                {
                    _atomEx3Dsource.Dispose();
                    _atomEx3Dsource = null;
                }
            }
            if (playerHolder != null)
            {
                if (numberOfFrameBeforeDestroy < 1)
                    UnityEngine.Object.Destroy(playerHolder.gameObject);
                else
                    playerHolder.StartCoroutine(IssuePluginUpdatesForFrames(numberOfFrameBeforeDestroy, playerHolder,
                        true, playerId));
            }
            else if (numberOfFrameBeforeDestroy >= 1)
            {
                Debug.LogError("[CRIWARE] Player couldn't destroy internal resources.");
            }
            playerId = InvalidPlayerId;
            cuePointCallback = null;
            OnSubtitleChanged = null;
        }

        // Game behaviour kept: IssuePluginEvent uses this.playerId, which Dispose has already set to -1.
        private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy,
            int playerId)
        {
            while (frameCount > 0)
            {
                IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.UPDATE);
                CRIWAREFA328494(playerId);
                yield return null;
                frameCount--;
            }
            if (destroy)
                UnityEngine.Object.Destroy(playerHolder.gameObject);
        }

        public void DisposeRendererResource()
        {
            if (rendererResource != null)
            {
                rendererResource.Dispose();
                rendererResource = null;
            }
        }

        public void PrepareForRendering()
        {
            if (internalrequiredStatus != Status.Ready)
            {
                if (_nativeStatus != Status.PlayEnd && _nativeStatus != Status.Stop)
                    return;
                Start();
            }
            Pause(true);
            internalrequiredStatus = Status.ReadyForRendering;
            isPreparingForRendering = true;
            InvokePlayerStatusCheck();
        }

        public void Start()
        {
            var previousRequiredStatus = internalrequiredStatus;
            wasStopping = false;
            internalrequiredStatus = Status.Playing;
            InvokePlayerStatusCheck();
            if (previousRequiredStatus == Status.ReadyForRendering)
            {
                Pause(false);
                UpdateNativePlayer();
            }
            else if (_nativeStatus == Status.PlayEnd || _nativeStatus == Status.Stop)
            {
                PrepareNativePlayer();
                UpdateNativePlayer();
            }
            if (rendererResource != null)
                rendererResource.OnPlayerStart();
            isStoppingForSeek = false;
        }

        public void Stop()
        {
            isStoppingForSeek = false;
            internalrequiredStatus = Status.Stop;
            wasStopping = true;
            InvokePlayerStatusCheck();
            if (rendererResource != null)
                rendererResource.OnPlayerStop();
            if (playerId != InvalidPlayerId)
            {
                CRIWAREA6273B3C(playerId);
                UpdateNativePlayer();
            }
            isMovieInfoAvailable = false;
            isFrameInfoAvailable = false;
            isNativeStartInvoked = false;
            subtitleSize = 0;
        }

        public void Pause(bool sw)
        {
            CRIWARE10F14332(playerId, sw ? 1 : 0);
            if (rendererResource != null)
                rendererResource.OnPlayerPause(sw, false);
        }

        public bool IsPaused()
        {
            return CRIWARE8F9064CB(playerId);
        }

        public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New)
        {
            IntPtr binderHandle;
            if (binder == null)
            {
                if (Common.IsStreamingAssetsPath(moviePath))
                    moviePath = System.IO.Path.Combine(Common.streamingAssetsPath, moviePath);
                binderHandle = IntPtr.Zero;
            }
            else
            {
                binderHandle = binder.nativeHandle;
            }
            if (setMode != SetMode.New)
                return CRIWARE97D4A74F(playerId, binderHandle, moviePath, setMode == SetMode.AppendRepeatedly);
            CRIWAREF4FAFD40(playerId, binderHandle, moviePath);
            return true;
        }

        public void Loop(bool sw)
        {
            CRIWARE45230ACB(playerId, sw ? 1 : 0);
        }

        public void SetAudioBaseConcatenation(bool enabled)
        {
            CRIWAREAE6A37FE(playerId, enabled);
        }

        public void SetMasterTimerType(TimerType timerType)
        {
            _timerType = timerType;
            CRIWARE2A9F70F6(playerId, (int)timerType);
        }

        public void SetSeekPosition(int frameNumber)
        {
            CRIWAREBF4EA6F4(playerId, frameNumber);
        }

        public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback)
        {
            _shaderDispatchCallback = shaderDispatchCallback;
        }

        public bool HasRenderedNewFrame()
        {
            if (rendererResource == null)
                return false;
            return rendererResource.HasRenderedNewFrame();
        }

        public void UpdateWithUserTime(ulong timeCount, ulong timeUnit)
        {
            if (_timerType != TimerType.User)
                Debug.LogError("[CRIWARE] Timer type is invalid.");
            CRIWARE91A28C68(playerId, timeCount, timeUnit);
            InternalUpdate();
        }

        public void Update()
        {
            if (_timerType != TimerType.User && _timerType != TimerType.Manual)
                InternalUpdate();
        }

        public void OnWillRenderObject(CriManaMovieMaterialBase sender)
        {
            if (rendererResource == null)
                return;
            if (_nativeStatus == Status.Playing)
            {
                rendererResource.UpdateTextures();
                IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.RENDER);
            }
        }

        public bool UpdateMaterial(Material material)
        {
            if (rendererResource == null)
                return false;
            return isFrameInfoAvailable && rendererResource.UpdateMaterial(material) &&
                internalrequiredStatus != Status.ReadyForRendering;
        }

        public void PauseOnApplicationPause(bool sw)
        {
            CRIWARE10F14332(playerId, sw ? 1 : 0);
            if (rendererResource != null)
                rendererResource.OnPlayerPause(sw, true);
        }

        public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction)
        {
            var eventId = CriManaPlugin.renderingEventOffset | (int)renderEventAction | playerId;
            // Unity texture uploads must run on the main thread for the managed
            // decoder. Keep the game's event ordering at this platform seam.
            if (CriWareNative.Native is CriAtomNativeBackend managed)
            {
                managed.IssueManaRenderEvent(eventId);
                return;
            }
            GL.IssuePluginEvent(criWareUnity_GetRenderEventFunc(), eventId);
        }

        private void InvokePlayerStatusCheck()
        {
            var currentStatus = status;
            if (lastPlayerStatus.HasValue && currentStatus == lastPlayerStatus.Value)
                return;
            lastPlayerStatus = currentStatus;
            if (statusChangeCallback != null)
                statusChangeCallback(currentStatus);
            if (isPreparingForRendering && status != Status.Prep)
                isPreparingForRendering = false;
        }

        private void PrepareNativePlayer()
        {
            if (cuePointCallback != null)
                CRIWARE8F47EE33(playerId, new CuePointCallbackFromNativeDelegate(CuePointCallbackFromNative));
            CRIWARE1A89BB84(playerId);
        }

        private void UpdateNativePlayer()
        {
            updatingPlayer = this;
            var bufferSize = subtitleBufferSize;
            _nativeStatus = (Status)CRIWARE64FBEFB2(playerId);
            if (!lastNativeStatus.HasValue || _nativeStatus != lastNativeStatus.Value || isPreparingForRendering)
            {
                lastNativeStatus = _nativeStatus;
                InvokePlayerStatusCheck();
            }
            subtitleSize = bufferSize;
            updatingPlayer = null;
            if (isNativeInitialized && (_nativeStatus == Status.Stop || _nativeStatus == Status.StopProcessing))
            {
                isNativeInitialized = false;
                if (!isStoppingForSeek || rendererResource == null || !rendererResource.ShouldSkipDestroyOnStopForSeek())
                    IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.DESTROY);
            }
        }

        private void InvokeNativeStart()
        {
            CRIWARE38F608E1(playerId);
            isNativeStartInvoked = true;
            if (isNativeInitialized)
                IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.DESTROY);
            IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.INITIALIZE);
            isNativeInitialized = true;
        }

        private void InternalUpdate()
        {
            CRIWAREFA328494(playerId);
            if (internalrequiredStatus == Status.Stop)
            {
                if (_nativeStatus != Status.Stop)
                    UpdateNativePlayer();
                return;
            }
            switch (_nativeStatus)
            {
                case Status.Dechead:
                    UpdateNativePlayer();
                    if (_nativeStatus == Status.WaitPrep)
                        goto case Status.WaitPrep;
                    break;
                case Status.WaitPrep:
                    CRIWAREC91B6C0D(playerId, _movieInfo);
                    if (!isMovieInfoAvailable)
                    {
                        isMovieInfoAvailable = true;
                        if (enableSubtitle)
                            AllocateSubtitleBuffer((int)_movieInfo.maxSubtitleSize);
                        var userShader = _shaderDispatchCallback != null
                            ? _shaderDispatchCallback(movieInfo, additiveMode)
                            : null;
                        if (rendererResource != null &&
                            !rendererResource.IsSuitable(playerId, _movieInfo, additiveMode, userShader))
                        {
                            rendererResource.Dispose();
                            rendererResource = null;
                        }
                        if (rendererResource == null)
                        {
                            rendererResource =
                                RendererResourceFactory.DispatchAndCreate(playerId, _movieInfo, additiveMode, userShader);
                            if (rendererResource == null)
                            {
                                Stop();
                                return;
                            }
                        }
                        rendererResource.SetApplyTargetAlpha(applyTargetAlpha);
                        rendererResource.SetUiRenderMode(uiRenderMode);
                    }
                    rendererResource.AttachToPlayer(playerId);
                    if (internalrequiredStatus != Status.Ready)
                    {
                        if (internalrequiredStatus != Status.ReadyForRendering &&
                            internalrequiredStatus != Status.Playing)
                            break;
                        InvokeNativeStart();
                    }
                    goto case Status.Prep;
                case Status.Prep:
                    UpdateNativePlayer();
                    if (_nativeStatus == Status.Playing)
                        goto case Status.Playing;
                    if (_nativeStatus != Status.Ready)
                        break;
                    goto case Status.Ready;
                case Status.Ready:
                    if (internalrequiredStatus != Status.ReadyForRendering && internalrequiredStatus != Status.Playing)
                        break;
                    if (!isNativeStartInvoked)
                        InvokeNativeStart();
                    goto case Status.Playing;
                case Status.Playing:
                    UpdateNativePlayer();
                    if (_nativeStatus == Status.Playing)
                        UpdateFrames();
                    break;
                case Status.Error:
                    UpdateNativePlayer();
                    break;
            }
            if (_nativeStatus == Status.Error)
            {
                isMovieInfoAvailable = false;
                isFrameInfoAvailable = false;
                isNativeStartInvoked = false;
                subtitleSize = 0;
            }
        }

        // The Playing branch of InternalUpdate: drops late frames up to maxFrameDrop (negative = no limit).
        private void UpdateFrames()
        {
            var frameDrop = maxFrameDrop < 0 || droppedFrameCount < (uint)maxFrameDrop;
            bool isFrameUpdated;
            while (true)
            {
                isFrameUpdated = rendererResource.UpdateFrame(playerId, _frameInfo, ref frameDrop);
                if (!(isFrameUpdated && frameDrop))
                    break;
                if (maxFrameDrop < 0)
                {
                    droppedFrameCount++;
                }
                else if (droppedFrameCount < (uint)maxFrameDrop)
                {
                    droppedFrameCount++;
                    if (droppedFrameCount == (uint)maxFrameDrop)
                        frameDrop = false;
                }
            }
            if (isFrameUpdated)
                droppedFrameCount = 0;
            isFrameInfoAvailable |= isFrameUpdated;
            IssuePluginEvent(CriManaUnityPlayer_RenderEventAction.UPDATE);
        }

        private void AllocateSubtitleBuffer(int size)
        {
            if (subtitleBufferSize < size)
            {
                DeallocateSubtitleBuffer();
                subtitleBuffer = Marshal.AllocHGlobal(size);
                subtitleBufferSize = size;
                subtitleSize = 0;
            }
            for (var i = 0; i < subtitleBufferSize; i++)
                Marshal.WriteByte(subtitleBuffer, i, 0);
        }

        private void DeallocateSubtitleBuffer()
        {
            if (subtitleBuffer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(subtitleBuffer);
                subtitleBuffer = IntPtr.Zero;
                subtitleBufferSize = 0;
                subtitleSize = 0;
            }
        }

        // The native player hands the event point by reference; the managed callback gets a copy here.
        [MonoPInvokeCallback(typeof(CuePointCallbackFromNativeDelegate))]
        private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint)
        {
            var callback = updatingPlayer.cuePointCallback;
            if (callback != null)
            {
                var point = eventPoint;
                callback(ref point);
            }
        }

        private static int CRIWARE069A61A1() => CriWareNative.Native.CRIWARE069A61A1();
        private static int CRIWARED0162744(bool useAtomExPlayer, uint maxPathLength) =>
            CriWareNative.Native.CRIWARED0162744(useAtomExPlayer, maxPathLength);
        private static IntPtr criManaUnityPlayer_GetAtomExPlayerByTrackId(int player_id, uint track_id) =>
            CriWareNative.Native.criManaUnityPlayer_GetAtomExPlayerByTrackId(player_id, track_id);
        private static void CRIWARE0554C38E(int player_id) => CriWareNative.Native.CRIWARE0554C38E(player_id);
        private static void CRIWARE1A89BB84(int player_id) => CriWareNative.Native.CRIWARE1A89BB84(player_id);
        private static void CRIWARE8F47EE33(int player_id, CuePointCallbackFromNativeDelegate cbfunc) =>
            CriWareNative.Native.CRIWARE8F47EE33(player_id, cbfunc);
        private static void CRIWAREA6273B3C(int player_id) => CriWareNative.Native.CRIWAREA6273B3C(player_id);
        private static void CRIWARE10F14332(int player_id, int sw) => CriWareNative.Native.CRIWARE10F14332(player_id, sw);
        private static bool CRIWARE8F9064CB(int player_id) => CriWareNative.Native.CRIWARE8F9064CB(player_id);
        private static void CRIWAREF4FAFD40(int player_id, IntPtr binder, string path) =>
            CriWareNative.Native.CRIWAREF4FAFD40(player_id, binder, path);
        private static bool CRIWARE97D4A74F(int player_id, IntPtr binder, string path, bool repeat) =>
            CriWareNative.Native.CRIWARE97D4A74F(player_id, binder, path, repeat);
        private static void CRIWARE45230ACB(int player_id, int sw) => CriWareNative.Native.CRIWARE45230ACB(player_id, sw);
        private static void CRIWAREBF4EA6F4(int player_id, int seek_frame_no) =>
            CriWareNative.Native.CRIWAREBF4EA6F4(player_id, seek_frame_no);
        private static void CRIWAREAE6A37FE(int player_id, bool flag) => CriWareNative.Native.CRIWAREAE6A37FE(player_id, flag);
        private static void CRIWARE2A9F70F6(int player_id, int timer_type) =>
            CriWareNative.Native.CRIWARE2A9F70F6(player_id, timer_type);
        private static void CRIWARE91A28C68(int player_id, ulong user_count, ulong user_unit) =>
            CriWareNative.Native.CRIWARE91A28C68(player_id, user_count, user_unit);
        private static void CRIWAREFA328494(int player_id) => CriWareNative.Native.CRIWAREFA328494(player_id);
        private static void CRIWAREC91B6C0D(int player_id, MovieInfo movie_info) =>
            CriWareNative.Native.CRIWAREC91B6C0D(player_id, movie_info);
        private static void CRIWARE38F608E1(int player_id) => CriWareNative.Native.CRIWARE38F608E1(player_id);
        private static int CRIWARE64FBEFB2(int player_id) => CriWareNative.Native.CRIWARE64FBEFB2(player_id);
        private static IntPtr criWareUnity_GetRenderEventFunc() => CriWareNative.Native.criWareUnity_GetRenderEventFunc();
    }
}
