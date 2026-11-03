namespace Campus.Common
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [ExecuteAlways]
    [SingletonResourcePath("UI/UICamera", true)]
    public class UICameraController : Singleton<UICameraController>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CCaptureRequestAsync_003Ed__17 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<RTHandle> _003C_003Et__builder;
            public UICameraController _003C_003E4__this;
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
        private struct _003CCaptureRequestAsync_003Ed__18 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public UICameraController _003C_003E4__this;
            public RTHandle target;
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

        private Camera _camera;
        private CinemachineBrain _cinemachineBrain;
        private UIRenderTargetBlurManager _renderTargetBlurManager;
        private UIRenderResultCopyManager _renderResultCopyManager;
        private RTHandle _captureTexture;
        public Camera UICamera
        {
            get
            {
                return null;
            }
        }

        public CinemachineBrain CinemachineBrain
        {
            get
            {
                return null;
            }
        }

        public UIRenderTargetBlurManager RenderTargetBlurManager
        {
            get
            {
                return null;
            }
        }

        public UIRenderResultCopyManager RenderResultCopyManager
        {
            get
            {
                return null;
            }
        }

        public RTHandle CaptureTexture
        {
            get
            {
                return null;
            }
        }

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        protected override void OnFinalize()
        {
        }

        [AsyncStateMachine(typeof(_003CCaptureRequestAsync_003Ed__17))]
        public UniTask<RTHandle> CaptureRequestAsync(CancellationToken ct)
        {
            return default(UniTask<RTHandle>);
        }

        [AsyncStateMachine(typeof(_003CCaptureRequestAsync_003Ed__18))]
        public UniTask CaptureRequestAsync(RTHandle target, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void SetCinemachineBrainEnabled(bool value)
        {
        }

        public void ResetTransform()
        {
        }

        public UICameraController()
        {
        }
    }
}
