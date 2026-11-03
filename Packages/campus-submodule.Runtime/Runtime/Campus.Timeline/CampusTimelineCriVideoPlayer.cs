namespace Campus.Timeline
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Timeline;
    using global::CriWare;
    using global::CriWare.CriMana;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [RequireComponent(typeof(RawImage))]
    public class CampusTimelineCriVideoPlayer : CriManaMovieControllerForUI
    {
        public class VideoPlayerState
        {
            public bool isMovieNameValid;
            public bool isMoviePathValid;
            public bool isInitializedLibrary;
            public bool isInitializePlayer;
            public bool CanPlay
            {
                get
                {
                    return default(bool);
                }
            }

            public void DebugLog()
            {
            }

            public static VideoPlayerState Create(CampusTimelineCriVideoPlayer videoPlayer)
            {
                return null;
            }

            public VideoPlayerState()
            {
            }
        }

        public class MovieInfo
        {
            public int width;
            public int height;
            public float frameRate;
            public int totalFrames;
            public float duration;
            public CriWare.CriMana.MovieInfo rawInfo;
            public static MovieInfo CreateFromCriMovieInfo(CriWare.CriMana.MovieInfo movieInfo)
            {
                return null;
            }

            public MovieInfo()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<bool> _003C_003E9__26_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CDownloadMovieAsync_003Eb__26_0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CDownloadMovieAsync_003Ed__26 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<string>.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLightScrubToFrameAsync_003Ed__41 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public int frameNumber;
            public CancellationToken ct;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnEnableAsync_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPrepareForScrubSeekAsync_003Ed__43 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CRunScrubLoopAsync_003Ed__40 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            private int _003CframeNumber_003E5__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetMovieInfo_003Ed__27 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitForDisplayReadyAsync_003Ed__45 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
            public CancellationToken ct;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public int frameNumber;
            private int _003Ci_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitForPlayerStoppedAsync_003Ed__44 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitForStatusAsync_003Ed__46 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
            public CancellationToken ct;
            public CampusTimelineCriVideoPlayer _003C_003E4__this;
            public Func<Player.Status, bool> predicate;
            private int _003Ci_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public string movieName;
        public bool downloadOnEnable;
        [NonSerialized]
        private string _moviePath;
        private bool _isTimelineClipActive;
        private double _lastSyncedTimelineTime;
        private int _lastScrubFrame;
        private int _scrubTargetFrame;
        private bool _scrubLoopRunning;
        private CancellationTokenSource _scrubLoopCts;
        private bool _isInteractiveScrubActive;
        private const int ScrubMaxUpdateIterations = 90;
        [CanBeNull]
        private MovieInfo _movieInfo;
        public bool IsRecording;
        internal bool IsTimelineClipActive
        {
            get
            {
                return default(bool);
            }
        }

        public VideoPlayerState State
        {
            get
            {
                return null;
            }
        }

        [CanBeNull]
        public MovieInfo GetMovieInfo()
        {
            return null;
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        [AsyncStateMachine(typeof(_003COnEnableAsync_003Ed__22))]
        private UniTask OnEnableAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void OnDisable()
        {
        }

        public void InitializePlayer()
        {
        }

        public void FinalizePlayer()
        {
        }

        [AsyncStateMachine(typeof(_003CDownloadMovieAsync_003Ed__26))]
        public UniTask DownloadMovieAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetMovieInfo_003Ed__27))]
        public UniTask SetMovieInfo(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Seek(int frameNumber)
        {
        }

        public new void Stop()
        {
        }

        public void SetTime(double time)
        {
        }

        public void SeekToFrame(int frameNumber)
        {
        }

        public void SeekToTime(double timeInSeconds)
        {
        }

        public void Pause()
        {
        }

        protected override void OnDestroy()
        {
        }

        private void LateUpdate()
        {
        }

        private void OnValidate()
        {
        }

        private void RequestScrubFrame(int frameNumber)
        {
        }

        internal bool ShouldSkipScrubRequest(int frameNumber)
        {
            return default(bool);
        }

        private void CancelScrubRequest()
        {
        }

        [AsyncStateMachine(typeof(_003CRunScrubLoopAsync_003Ed__40))]
        private UniTaskVoid RunScrubLoopAsync(CancellationToken ct)
        {
            return default(UniTaskVoid);
        }

        [AsyncStateMachine(typeof(_003CLightScrubToFrameAsync_003Ed__41))]
        private UniTask LightScrubToFrameAsync(int frameNumber, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void FinishScrubFrame(int frameNumber)
        {
        }

        [AsyncStateMachine(typeof(_003CPrepareForScrubSeekAsync_003Ed__43))]
        private UniTask<bool> PrepareForScrubSeekAsync(CancellationToken ct)
        {
            return default(UniTask<bool>);
        }

        [AsyncStateMachine(typeof(_003CWaitForPlayerStoppedAsync_003Ed__44))]
        private UniTask<bool> WaitForPlayerStoppedAsync(CancellationToken ct)
        {
            return default(UniTask<bool>);
        }

        [AsyncStateMachine(typeof(_003CWaitForDisplayReadyAsync_003Ed__45))]
        private UniTask<bool> WaitForDisplayReadyAsync(int frameNumber, CancellationToken ct)
        {
            return default(UniTask<bool>);
        }

        [AsyncStateMachine(typeof(_003CWaitForStatusAsync_003Ed__46))]
        private UniTask<bool> WaitForStatusAsync(Func<Player.Status, bool> predicate, CancellationToken ct)
        {
            return default(UniTask<bool>);
        }

        private bool TrySkipScrubFrame(int frameNumber)
        {
            return default(bool);
        }

        private static bool IsPlayerStopped(Player.Status status)
        {
            return default(bool);
        }

        private static bool IsFrameDisplayReady(Player.Status status)
        {
            return default(bool);
        }

        public void SyncTimelineTime(double timeInSeconds, bool shouldPlay)
        {
        }

        internal bool DetectTimelineDiscontinuity(double timelineTime, float deltaTime)
        {
            return default(bool);
        }

        internal void RecordSyncedTimelineTime(double timelineTime)
        {
        }

        internal void ResetSyncedTimelineTime()
        {
        }

        internal static bool IsInteractivePausedScrub(FrameData info, bool shouldPlay)
        {
            return default(bool);
        }

        internal void UpdateInteractiveScrubDisplay(FrameData info, bool shouldPlay)
        {
        }

        internal void EndInteractiveScrubDisplay()
        {
        }

        internal static bool ShouldMixerSync(FrameData info, CampusTimelineCriVideoPlayer player, double timelineTime, bool shouldPlay)
        {
            return default(bool);
        }

        internal bool DetectTimelineFrameDrift(double timelineTime)
        {
            return default(bool);
        }

        public void StopOutsideClip()
        {
        }

        private bool NeedsStopForOutsideClip()
        {
            return default(bool);
        }

        private void PrepareTargetDisplayForScrub()
        {
        }

        private void HideTargetDisplay()
        {
        }

        private bool IsTargetDisplayVisible()
        {
            return default(bool);
        }

        internal void MarkTimelineClipActive()
        {
        }

        internal static bool ShouldContinuePlayback(FrameData info, CampusTimelineCriVideoPlayer videoPlayer)
        {
            return default(bool);
        }

        internal static bool ShouldPlayAfterSync(FrameData info, CampusTimelineCriVideoPlayer videoPlayer)
        {
            return default(bool);
        }

        internal int TimeToFrame(double timeInSeconds)
        {
            return default(int);
        }

        private int ClampFrame(int frameNumber)
        {
            return default(int);
        }

        public CampusTimelineCriVideoPlayer()
        {
        }

        [CompilerGenerated]
        [DebuggerHidden]
        private void _003C_003En__0()
        {
        }

        [CompilerGenerated]
        private bool _003CSetMovieInfo_003Eb__27_0()
        {
            return default(bool);
        }

        [CompilerGenerated]
        private bool _003CSetMovieInfo_003Eb__27_1()
        {
            return default(bool);
        }

        [CompilerGenerated]
        private bool _003CSetMovieInfo_003Eb__27_2()
        {
            return default(bool);
        }
    }
}
