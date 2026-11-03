namespace Campus.Photography
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Photography;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UniRx;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class PhotographyActivityController : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass22_0
        {
            public PhotographyActivityController _003C_003E4__this;
            public AsyncGPUReadbackRequest request;
            public _003C_003Ec__DisplayClass22_0()
            {
            }

            internal bool _003CGetDofFocalPoint_003Eb__0()
            {
                return default(bool);
            }

            internal bool _003CGetDofFocalPoint_003Eb__1()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CGetDofFocalPoint_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<float> _003C_003Et__builder;
            public PhotographyActivityController _003C_003E4__this;
            public Vector2 mousePosition;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;
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
        private PhotographyActivityMoveController _moveController;
        [SerializeField]
        private PhotographyActivityCameraController _cameraController;
        private PhotographyActivityControllerModel _model;
        public Action onBlockingHit;
        private BoolReactiveProperty _blockingHit;
        private int _vl3dLayer;
        private bool _isInitialized;
        private PointDepthData _pointDepthData;
        private GraphicsBuffer _outputBuffer;
        private NativeArray<float> _outputFocalPoint;
        public Vector3 CameraAngle
        {
            get
            {
                return default(Vector3);
            }
        }

        public void Initialize(VolumeProfile volumeProfile, CampusGyroController campusGyroController, float cameraStartHeight)
        {
        }

        public void SetStartPosition(CinemachineVirtualCamera virtualCamera)
        {
        }

        private void LateUpdate()
        {
        }

        private void Bind()
        {
        }

        public void SetDofFocusTarget(ICampusActorController actorController, [Optional] Transform target)
        {
        }

        public void SetDofFocusTarget(Transform target)
        {
        }

        public ICampusActorController GetFocusActor()
        {
            return null;
        }

        public void Reset()
        {
        }

        public void SetData(Vector3 position, float angleX, float angleY, float colliderY, float cameraHeight)
        {
        }

        private void UpdateCameraDoF()
        {
        }

        [AsyncStateMachine(typeof(_003CGetDofFocalPoint_003Ed__22))]
        public UniTask<float> GetDofFocalPoint(Vector2 mousePosition, CancellationToken ct)
        {
            return default(UniTask<float>);
        }

        public void AddAngle(Vector2 diffAngle)
        {
        }

        public void SetAngleZ(float angleZ)
        {
        }

        public void AddPosition(Vector2 diffPosition)
        {
        }

        public void AddCameraPosition(float diffDelta)
        {
        }

        public void SetStartCameraPosition(float posY)
        {
        }

        public void SetGyroActive(bool isActive)
        {
        }

        public void ResetGyro()
        {
        }

        public void SetFrontActor(ICampusActorController actorController, Vector3 offset, float cameraYOffset = 0.1f, bool stayAngleZ = false)
        {
        }

        public void RequestLookAt(Vector3 targetPosition, bool withEnable = true)
        {
        }

        public void SetAutoLookAtEnable(bool isEnable)
        {
        }

        public bool IsAutoLookEnable()
        {
            return default(bool);
        }

        public float GetRequestedFrameDeltaPosition()
        {
            return default(float);
        }

        private void SetFrontActorCameraHeight(ICampusActorController actorController, float offset = 0.1f)
        {
        }

        public void SetZoomRatio(float ratio)
        {
        }

        public void SetFNumber(float value)
        {
        }

        public void SetCameraHeightLimit(float min, float max)
        {
        }

        public void OnDestroy()
        {
        }

        public PhotographyActivityController()
        {
        }

        [CompilerGenerated]
        private void _003CBind_003Eb__15_0(bool isHit)
        {
        }
    }
}
