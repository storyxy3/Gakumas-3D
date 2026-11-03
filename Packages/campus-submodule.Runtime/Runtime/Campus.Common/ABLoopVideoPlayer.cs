namespace Campus.Common
{
    using global::System.Collections.Generic;
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
    public class ABLoopVideoPlayer : QuaUIBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass17_0
        {
            public CancellationToken ct;
            public _003C_003Ec__DisplayClass17_0()
            {
            }

            internal UniTask<string> _003CLoadResourceAsync_003Eb__0(string x)
            {
                return default(UniTask<string>);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__16 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ABLoopVideoPlayer _003C_003E4__this;
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
        private struct _003CLoadResourceAsync_003Ed__17 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public IReadOnlyList<string> resourceNames;
            public ABLoopVideoPlayer _003C_003E4__this;
            private UniTask<string[]>.Awaiter _003C_003Eu__1;
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
        private struct _003CSkipToLoopAsync_003Ed__28 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ABLoopVideoPlayer _003C_003E4__this;
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
        private struct _003CSkipToNextMovieAsync_003Ed__30 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
            public ABLoopVideoPlayer _003C_003E4__this;
            public CancellationToken ct;
            private int _003CcurrentMovieIndex_003E5__2;
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
        private struct _003CTryInitializeAsync_003Ed__15 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ABLoopVideoPlayer _003C_003E4__this;
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
        private float _volume;
        private int _movieCount;
        private string[] _moviePaths;
        private string _loopMoviePath;
        [CompilerGenerated]
        private CriManaMovieControllerForUI _003CCriMana_003Ek__BackingField;
        [CompilerGenerated]
        private RawImage _003CTargetImage_003Ek__BackingField;
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

        protected override void Awake()
        {
        }

        [AsyncStateMachine(typeof(_003CTryInitializeAsync_003Ed__15))]
        public UniTask TryInitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__16))]
        private UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadResourceAsync_003Ed__17))]
        public UniTask LoadResourceAsync(IReadOnlyList<string> resourceNames, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void SetMoviePaths(IReadOnlyList<string> paths)
        {
        }

        public void Prepare()
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

        public UniTask OnPlayAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnStopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnReadyAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Rewind()
        {
        }

        [AsyncStateMachine(typeof(_003CSkipToLoopAsync_003Ed__28))]
        public UniTask SkipToLoopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public int GetCurrentMovieIndex()
        {
            return default(int);
        }

        [AsyncStateMachine(typeof(_003CSkipToNextMovieAsync_003Ed__30))]
        public UniTask<bool> SkipToNextMovieAsync(CancellationToken ct)
        {
            return default(UniTask<bool>);
        }

        public UniTask OnEnterLoopAsync(CancellationToken ct)
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

        public bool IsPlaying()
        {
            return default(bool);
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public bool IsStop()
        {
            return default(bool);
        }

        public float GetVolume()
        {
            return default(float);
        }

        public void SetVolume(float volume)
        {
        }

        private void LateUpdate()
        {
        }

        public ABLoopVideoPlayer()
        {
        }

        [CompilerGenerated]
        private void _003CTryInitializeAsync_003Eb__15_1()
        {
        }

        [CompilerGenerated]
        private bool _003CTryInitializeAsync_003Eb__15_0()
        {
            return default(bool);
        }

        [CompilerGenerated]
        private bool _003CInitializeAsync_003Eb__16_0()
        {
            return default(bool);
        }

        [CompilerGenerated]
        private bool _003COnEnterLoopAsync_003Eb__31_0()
        {
            return default(bool);
        }
    }
}
