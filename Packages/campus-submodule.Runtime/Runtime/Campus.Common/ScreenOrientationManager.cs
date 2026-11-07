namespace Campus.Common
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::DG.Tweening;
    using global::Qua.Utility;
    using global::UnityEngine;

    [SingletonResourcePath("ScreenOrientationManager", true)]
    public class ScreenOrientationManager : Singleton<ScreenOrientationManager>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass26_0
        {
            public ScreenOrientation to;
            public ScreenOrientationManager _003C_003E4__this;
            public _003C_003Ec__DisplayClass26_0()
            {
            }

            internal bool _003CAfterChangeOrientationAsync_003Eb__0()
            {
                return default(bool);
            }

            internal float _003CAfterChangeOrientationAsync_003Eb__1()
            {
                return default(float);
            }

            internal void _003CAfterChangeOrientationAsync_003Eb__2(float x)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CAfterChangeOrientationAsync_003Ed__26 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ScreenOrientation to;
            public ScreenOrientationManager _003C_003E4__this;
            public ScreenOrientation from;
            public AsyncLazy completedOrientationTask;
            public UniTaskCompletionSource completionSource;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;
            private CancellationTokenRegistration _003Cregister_003E5__2;
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
        private struct _003CBeforeChangeOrientationAsync_003Ed__25 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ScreenOrientationManager _003C_003E4__this;
            public ScreenOrientation from;
            public ScreenOrientation to;
            public CancellationToken ct;
            private CancellationTokenRegistration _003Cregister_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private ScreenOrientationControllerBase _controller;
        [CompilerGenerated]
        private Func<ScreenOrientation, ScreenOrientation, CancellationToken, UniTask> _003COnBeforeChangeOrientationAsync_003Ek__BackingField;
        [CompilerGenerated]
        private Func<ScreenOrientation, ScreenOrientation, AsyncLazy, UniTaskCompletionSource, CancellationToken, UniTask> _003COnAfterChangeOrientationAsync_003Ek__BackingField;
        [SerializeField]
        private CanvasGroup _fadeGroup;
        private Tween _fadeTween;
        private bool? _isActiveVLCameraBeforeChange;
        [CompilerGenerated]
        private Action<ScreenOrientation, ScreenOrientation> m_OnBeforeChangeOrientationCallback;
        [CompilerGenerated]
        private Action<ScreenOrientation, ScreenOrientation> m_OnAfterChangeOrientationCallback;
        public static OrientationType CurrentOrientationType
        {
            get
            {
                return default(OrientationType);
            }
        }

        public static bool IsOrientating
        {
            get
            {
                return default(bool);
            }
        }

        public Func<ScreenOrientation, ScreenOrientation, CancellationToken, UniTask> OnBeforeChangeOrientationAsync
        {
            [CompilerGenerated]
            get
            {
                return _003COnBeforeChangeOrientationAsync_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnBeforeChangeOrientationAsync_003Ek__BackingField = value;
            }
        }

        public Func<ScreenOrientation, ScreenOrientation, AsyncLazy, UniTaskCompletionSource, CancellationToken, UniTask> OnAfterChangeOrientationAsync
        {
            [CompilerGenerated]
            get
            {
                return _003COnAfterChangeOrientationAsync_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnAfterChangeOrientationAsync_003Ek__BackingField = value;
            }
        }

        public event Action<ScreenOrientation, ScreenOrientation> OnBeforeChangeOrientationCallback
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

        public event Action<ScreenOrientation, ScreenOrientation> OnAfterChangeOrientationCallback
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

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        protected override void OnInitialize()
        {
        }

        protected override void OnFinalize()
        {
        }

        [AsyncStateMachine(typeof(_003CBeforeChangeOrientationAsync_003Ed__25))]
        private UniTask BeforeChangeOrientationAsync(ScreenOrientation from, ScreenOrientation to, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CAfterChangeOrientationAsync_003Ed__26))]
        private UniTask AfterChangeOrientationAsync(ScreenOrientation from, ScreenOrientation to, AsyncLazy completedOrientationTask, UniTaskCompletionSource completionSource, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void ReleaseFullScreenBlackMask()
        {
        }

        public void SetAdjustScreenResolutionErrorCallback(Action<ScreenOrientation, ScreenOrientation> callback)
        {
        }

        public static void SetOrientation(OrientationType orientationType)
        {
        }

        public static UniTask SetOrientationAsync(OrientationType orientationType, [Optional] Func<UniTask> completedOrientationTask)
        {
            return default(UniTask);
        }

        public ScreenOrientationManager()
        {
        }

        [CompilerGenerated]
        private float _003CBeforeChangeOrientationAsync_003Eb__25_0()
        {
            return default(float);
        }

        [CompilerGenerated]
        private void _003CBeforeChangeOrientationAsync_003Eb__25_1(float x)
        {
        }
    }
}
