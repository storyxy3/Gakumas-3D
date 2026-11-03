namespace Campus.Live
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Panorama;
    using global::Campus.Live;
    using global::Campus.Timeline;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    [SingletonResourcePath("LivePanoramaCameraManager", true)]
    public class LivePanoramaCameraManager : Singleton<LivePanoramaCameraManager>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__40 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public LivePanoramaCameraManager _003C_003E4__this;
            public IPanoramaCameraController timelineCameraController;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private IPanoramaCameraController _timelineCameraController;
        [CompilerGenerated]
        private IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> _003CPanoramaCameraTypeMap_003Ek__BackingField;
        [CompilerGenerated]
        private IReadOnlyList<SwitchPanoramaCamera> _003CAllSwitchPanoramaCameras_003Ek__BackingField;
        [CompilerGenerated]
        private PanoramaDroneActivityController _003CDroneCamera_003Ek__BackingField;
        [CompilerGenerated]
        private SwitchPanoramaCamera _003CCurrentSelectCamera_003Ek__BackingField;
        [CompilerGenerated]
        private SwitchPanoramaCamera _003CCurrentLiveCamera_003Ek__BackingField;
        [CompilerGenerated]
        private (bool isActive, PanoramaCameraType type, int index) _003CLiveOverwriteCamera_003Ek__BackingField;
        private CampusGyroController _gyroController;
        private (long gyroUpdateFrame, Vector3 gyroParameter) _gyroUpdateStatus;
        private Action _onGyroRest;
        [SerializeField]
        private Volume _dofVolume;
        private VolumeProfile _dofVolumeProfile;
        private (Transform target, bool isActorHead) _dofTarget;
        private int _currentDoFSizeIndex;
        private List<PanoramaActorLookAtController> _panoramaActors;
        private int _currentFocusActorIndex;
        private SimulationMode _initialSimulationMode;
        private bool _isInitialized;
        private IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> PanoramaCameraTypeMap
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

        private IReadOnlyList<SwitchPanoramaCamera> AllSwitchPanoramaCameras
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

        public PanoramaDroneActivityController DroneCamera
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

        public SwitchPanoramaCamera CurrentSelectCamera
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

        public SwitchPanoramaCamera CurrentLiveCamera
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

        private (bool isActive, PanoramaCameraType type, int index) LiveOverwriteCamera
        {
            [CompilerGenerated]
            get
            {
                return default((bool, PanoramaCameraType, int));
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool IsGyroReady
        {
            get
            {
                return default(bool);
            }
        }

        public IReadOnlyList<PanoramaActorLookAtController> PanoramaActors
        {
            get
            {
                return null;
            }
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__40))]
        public UniTask InitializeAsync(IPanoramaCameraController timelineCameraController, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void SetEvent()
        {
        }

        private void LateUpdate()
        {
        }

        public void SwitchPanoramaCamera(PanoramaCameraType type, int index)
        {
        }

        public void AddPanoramaActor(PanoramaActorLookAtController actor)
        {
        }

        private void EnsureLatestEyeAnglesFor(PanoramaActorLookAtController actor)
        {
        }

        public static void RefreshActorEyeAngles(PanoramaActorLookAtController actor)
        {
        }

        public static void SetGyroStatus(bool isActive)
        {
        }

        private Vector3 UpdateGyroParameter()
        {
            return default(Vector3);
        }

        public static void ResetGyroParameter(bool isResetCameraAngle = false)
        {
        }

        public static void SetCameraFNumber(int dofIndex)
        {
        }

        private void UpdateCameraDoF()
        {
        }

        public static void SetLiveLookAtEnable(int actorIndex, bool isEnable)
        {
        }

        public static void SetLiveProhibitLookEnable(int actorIndex, bool isProhibit)
        {
        }

        public static void SetShouldLookAtEnable(bool isEnable)
        {
        }

        public static bool CanChangeActorLookStatus(bool shouldEnable)
        {
            return default(bool);
        }

        public static void SetFocusTarget(ICampusActorController actorController)
        {
        }

        private void SetFocusTargetIndex(int index)
        {
        }

        public static void SetAutoLookTargetEnable(bool isEnable)
        {
        }

        public static void AddMoveCameraPosition(Vector3 diffPosition)
        {
        }

        public static void AddMoveCameraAngle(Vector3 angle)
        {
        }

        public static void OnChangeCameraByTimelineTack(PanoramaCameraType type, int index, bool isActive)
        {
        }

        private void OnChangeLiveCamera()
        {
        }

        protected override void OnFinalize()
        {
        }

        public LivePanoramaCameraManager()
        {
        }
    }
}
