namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;

    public class CampusHomeSceneLayout : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass32_0
        {
            public CinemachineBrain brain;
            public GameObject loginBonusCameraObject;
            public string loginBonusCameraName;
            public string activeCameraName;
            public _003C_003Ec__DisplayClass32_0()
            {
            }

            internal bool _003CWaitUntilHomeBlendEndAsync_003Eb__0()
            {
                return default(bool);
            }

            internal bool _003CWaitUntilHomeBlendEndAsync_003Eb__1(CinemachineBlenderSettings.CustomBlend setting)
            {
                return default(bool);
            }

            internal bool _003CWaitUntilHomeBlendEndAsync_003Eb__2()
            {
                return default(bool);
            }

            internal bool _003CWaitUntilHomeBlendEndAsync_003Eb__3()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitUntilHomeBlendEndAsync_003Ed__32 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusHomeSceneLayout _003C_003E4__this;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;
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
        private CampusSceneLayout _homeLayout;
        private HomeEnvironmentCinemachineController _homeCameraCinemachine;
        [SerializeField]
        private Vector2 _homeCameraAngleLimitHorizontal;
        [SerializeField]
        private Vector2 _homeCameraAngleLimitVertical;
        [SerializeField]
        private CampusSceneLayout _storyLayout;
        private HomeEnvironmentCinemachineController _storyCameraCinemachine;
        [SerializeField]
        private Vector2 _storyCameraAngleLimitHorizontal;
        [SerializeField]
        private Vector2 _storyCameraAngleLimitVertical;
        [SerializeField]
        private CampusSceneLayout _idolLayout;
        private HomeEnvironmentCinemachineController _idolCameraCinemachine;
        [SerializeField]
        private Vector2 _idolCameraAngleLimitHorizontal;
        [SerializeField]
        private Vector2 _idolCameraAngleLimitVertical;
        [SerializeField]
        private CampusSceneLayout _contestLayout;
        private HomeEnvironmentCinemachineController _contestCameraCinemachine;
        [SerializeField]
        private Vector2 _contestCameraAngleLimitHorizontal;
        [SerializeField]
        private Vector2 _contestCameraAngleLimitVertical;
        [SerializeField]
        private CampusSceneLayout _loginBonusLayout;
        [SerializeField]
        private CinemachineBlenderSettings _blenderSettings;
        private CampusSceneLayout.SituationType _currentType;
        public CampusSceneLayout.SituationType CurrentType
        {
            get
            {
                return default(CampusSceneLayout.SituationType);
            }
        }

        private void Awake()
        {
        }

        public void SwitchSituation(CampusSceneLayout.SituationType target)
        {
        }

        private CampusSceneLayout GetSceneLayout(CampusSceneLayout.SituationType type)
        {
            return null;
        }

        public HomeEnvironmentCinemachineController GetCurrentHomeCamera()
        {
            return null;
        }

        public HomeEnvironmentCinemachineController GetHomeCamera(CampusSceneLayout.SituationType type)
        {
            return null;
        }

        public void SetupActor(CampusSceneLayout.SituationType type, ICampusActorController actor, bool isCorrectionLayoutHeight = false)
        {
        }

        public void SetupActor(CampusSceneLayout.SituationType type, List<ICampusActorController> actors)
        {
        }

        public void SetupActor(CampusSceneLayout.SituationType type, List<(ICampusActorController actor, bool isCorrectionLayoutHeight)> actors)
        {
        }

        public void Unset(CampusSceneLayout.SituationType type)
        {
        }

        private void SetupBlenderSetting()
        {
        }

        private void RemoveBlenderSetting()
        {
        }

        [AsyncStateMachine(typeof(_003CWaitUntilHomeBlendEndAsync_003Ed__32))]
        public UniTask WaitUntilHomeBlendEndAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private void OnDestroy()
        {
        }

        public CampusHomeSceneLayout()
        {
        }
    }
}
