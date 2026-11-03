namespace Campus.Photography
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Photography;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::DG.Tweening;
    using global::Octo;
    using global::Qua.Utility;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [SingletonResourcePath("PhotographySceneManager", true)]
    public class PhotographySceneManager : Singleton<PhotographySceneManager>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__29 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public bool isLandScape;
            public PhotographySceneManager _003C_003E4__this;
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
        private struct _003CLoadBackgroundAsync_003Ed__31 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public PhotographySceneManager _003C_003E4__this;
            public string backgroundId;
            public CancellationToken ct;
            public string backgroundPrefabId;
            private UniTask.Awaiter _003C_003Eu__1;
            private TaskAwaiter<GameObject> _003C_003Eu__2;
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
        private struct _003CLoadSceneLayoutCollectionAsync_003Ed__30 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public PhotographySceneManager _003C_003E4__this;
            public string sceneLayoutCollectionId;
            public CancellationToken ct;
            private TaskAwaiter<GameObject> _003C_003Eu__1;
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
        private struct _003CReleaseAssetsAsync_003Ed__45 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public PhotographySceneManager _003C_003E4__this;
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
        private struct _003CUnloadBackgroundAsync_003Ed__32 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public PhotographySceneManager _003C_003E4__this;
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

        [SerializeField]
        private GameObject _dofVolumeRoot;
        [SerializeField]
        private Volume _dofVolume;
        [SerializeField]
        private PhotographyActivityController _activityController;
        [SerializeField]
        private AnimationCurve _lookAtEasingAnimationCurve;
        [SerializeField]
        private float _lookAtEasingMaxAngle;
        [SerializeField]
        private float _lookAtEasingMinSpeed;
        [SerializeField]
        private float _lookAtEasingMaxSpeed;
        [SerializeField]
        private float _lookAtTypeEaseDuration;
        [SerializeField]
        private Ease _lookAtTypeEaseToBodyEaseType;
        [SerializeField]
        private Ease _lookAtTypeEaseToEyeEaseType;
        private CampusGyroController _gyroController;
        private CampusPhotographySceneLayoutCollection _sceneLayoutCollection;
        [CompilerGenerated]
        private CampusPhotographySceneLayout _003CCurrentSceneLayout_003Ek__BackingField;
        private AssetBundleSceneLoader _env3dLoader;
        private AssetKeeper _envPartsAssetKeeper;
        private GameObject _envParts;
        public Volume DofVolume
        {
            get
            {
                return null;
            }
        }

        public PhotographyActivityController ActivityController
        {
            get
            {
                return null;
            }
        }

        public CampusPhotographySceneLayout CurrentSceneLayout
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

        public bool IsGyroSupported
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsGyroActive
        {
            get
            {
                return default(bool);
            }
        }

        public int MaxCameraCount
        {
            get
            {
                return default(int);
            }
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__29))]
        public UniTask InitializeAsync(bool isLandScape, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneLayoutCollectionAsync_003Ed__30))]
        public UniTask LoadSceneLayoutCollectionAsync(string sceneLayoutCollectionId, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadBackgroundAsync_003Ed__31))]
        public UniTask LoadBackgroundAsync(string backgroundId, string backgroundPrefabId, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CUnloadBackgroundAsync_003Ed__32))]
        public UniTask UnloadBackgroundAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void SetSceneLayoutInactive()
        {
        }

        public void ChangeSceneLayout(int index)
        {
        }

        public void SetCameraStartPosition()
        {
        }

        public CampusPhotographySceneLayout GetSceneLayout(int index)
        {
            return null;
        }

        public void SetCurrentSceneLayout(CampusPhotographySceneLayout sceneLayout)
        {
        }

        public AnimationCurve GetLookAtEasingAnimationCurve()
        {
            return null;
        }

        public float GetLookAtEasingMaxAngle()
        {
            return default(float);
        }

        public float GetLookAtEasingMinSpeed()
        {
            return default(float);
        }

        public float GetLookAtEasingMaxSpeed()
        {
            return default(float);
        }

        public float GetLookAtTypeEaseDuration()
        {
            return default(float);
        }

        public Ease GetLookAtTypeEaseToBodyEaseType()
        {
            return default(Ease);
        }

        public Ease GetLookAtTypeEaseToEyeEaseType()
        {
            return default(Ease);
        }

        [AsyncStateMachine(typeof(_003CReleaseAssetsAsync_003Ed__45))]
        public UniTask ReleaseAssetsAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public PhotographySceneManager()
        {
        }
    }
}
