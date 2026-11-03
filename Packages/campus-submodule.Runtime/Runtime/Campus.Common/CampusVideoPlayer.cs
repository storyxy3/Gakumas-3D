namespace Campus.Common
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::CriWare;
    using global::CriWare.CriMana;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CriManaMovieControllerForUI), typeof(RawImage))]
    public class CampusVideoPlayer : QuaUIBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass47_0
        {
            public CampusVideoPlayer _003C_003E4__this;
            public uint totalFrames;
            public _003C_003Ec__DisplayClass47_0()
            {
            }

            internal bool _003COnLoopOnceAsync_003Eb__0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__29 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusVideoPlayer _003C_003E4__this;
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
        private struct _003CLoadResourceAsync_003Ed__30 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public string resourceName;
            public CancellationToken ct;
            public CampusVideoPlayer _003C_003E4__this;
            private UniTask<string>.Awaiter _003C_003Eu__1;
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
        private struct _003CTryInitializeAsync_003Ed__28 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private CancellationTokenRegistration _003C__003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private bool _isInitializeCalled;
        private bool _isInitialized;
        private string _moviePath;
        private bool _isMonoBehaviourStartCalled;
        private float _speed;
        private bool _isPlayed;
        private bool _isPaused;
        private bool _isSeek;
        private int _targetFrame;
        private float _targetSpeed;
        private double _targetSetProgress;
        private float _targetSetSpeed;
        private float _volume;
        [CompilerGenerated]
        private CriManaMovieControllerForUI _003CCriMana_003Ek__BackingField;
        [CompilerGenerated]
        private RawImage _003CTargetImage_003Ek__BackingField;
        [SerializeField]
        private bool _disableDefaultApplicationPause;
        public CriManaMovieControllerForUI CriMana
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public RawImage TargetImage
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsSeek
        {
            get
            {
                return default(bool);
            }
        }

        public bool HasAudio
        {
            get
            {
                return default(bool);
            }
        }

        protected override void Awake()
        {
        }

        protected override void Start()
        {
        }

        [AsyncStateMachine(typeof(_003CTryInitializeAsync_003Ed__28))]
        public UniTask TryInitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__29))]
        private UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadResourceAsync_003Ed__30))]
        public UniTask LoadResourceAsync(string resourceName, CancellationToken ct)
        {
            return default(UniTask);
        }

        public string GetMoviePath()
        {
            return null;
        }

        public void SetMoviePath(string path)
        {
        }

        public void SetLoop(bool isLoop)
        {
        }

        public void SetApplyTargetAlpha(bool applyTargetAlpha)
        {
        }

        public void SetDisableDefaultApplicationPause(bool isDisable)
        {
        }

        public void Prepare()
        {
        }

        public void PrepareForRendering()
        {
        }

        public void Play()
        {
        }

        public void Pause()
        {
        }

        public void UnPause()
        {
        }

        public void Stop()
        {
        }

        public UniTask OnReadyAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnPlayAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnEndAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnStopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnEndOrStopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnLoopOnceAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public Player.Status GetStatus()
        {
            return default(Player.Status);
        }

        public bool IsPreparing()
        {
            return default(bool);
        }

        public bool IsReady()
        {
            return default(bool);
        }

        public bool IsPlayed()
        {
            return default(bool);
        }

        public bool IsPlaying()
        {
            return default(bool);
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public bool IsEnd()
        {
            return default(bool);
        }

        public bool IsStop()
        {
            return default(bool);
        }

        public bool IsEndOrStop()
        {
            return default(bool);
        }

        public double GetDuration()
        {
            return default(double);
        }

        public void BeginSeek()
        {
        }

        public void EndSeek()
        {
        }

        public double GetTime()
        {
            return default(double);
        }

        public void SetTime(double time)
        {
        }

        public double GetProgress()
        {
            return default(double);
        }

        public void SetProgress(double progress)
        {
        }

        public float GetSpeed()
        {
            return default(float);
        }

        public void SetSpeed(float speed)
        {
        }

        public float GetVolume()
        {
            return default(float);
        }

        public void SetVolume(float volume)
        {
        }

        private void OnStatusChange(Player.Status status)
        {
        }

        private void LateUpdate()
        {
        }

        private void ResetState()
        {
        }

        private void ResetTempState()
        {
        }

        private void SetCriManaApplicationPauseCallback(bool isBind)
        {
        }

        private void OnCriManaApplicationPause(CriManaMovieMaterialBase manaMovieMaterial, bool appPause)
        {
        }

        public CampusVideoPlayer()
        {
        }

        [CompilerGenerated]
        private void _003CTryInitializeAsync_003Eb__28_1()
        {
        }

        [CompilerGenerated]
        private bool _003CTryInitializeAsync_003Eb__28_0()
        {
            return default(bool);
        }

        [CompilerGenerated]
        private bool _003CInitializeAsync_003Eb__29_0()
        {
            return default(bool);
        }
    }
}
