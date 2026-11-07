namespace Campus.Photography
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Photography;
    using global::Cinemachine;
    using global::UnityEngine;

    public class PhotographyActivityBlockingCinemachine : CinemachineExtension
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass23_0
        {
            public Vector3 cameraPos;
            public PhotographyActivityBlockingCinemachine _003C_003E4__this;
        }

        private const float CameraDistance = 2.5f;
        private const float MaxRayDistance = 500f;
        private readonly RaycastHit[] _blockHits;
        private readonly Vector3[] _blockPoints;
        private Camera _mainCamera;
        [SerializeField]
        private LayerMask _targetLayer;
        [CompilerGenerated]
        private bool _003CIsBlockingHit_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsRightPosition_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CAddAngle_003Ek__BackingField;
        public bool IsBlockingHit
        {
            [CompilerGenerated]
            get
            {
                return _003CIsBlockingHit_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsBlockingHit_003Ek__BackingField = value;
            }
        }

        public bool IsRightPosition
        {
            [CompilerGenerated]
            get
            {
                return _003CIsRightPosition_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsRightPosition_003Ek__BackingField = value;
            }
        }

        public float AddAngle
        {
            [CompilerGenerated]
            get
            {
                return _003CAddAngle_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CAddAngle_003Ek__BackingField = value;
            }
        }

        public void ResetAddAngle()
        {
        }

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
        }

        private bool IsHitBlocking(out float angle, ref CameraState state, Vector3 eulerAngles)
        {
            throw null;
        }

        private void SetBoxPoint(BoxCollider boxCollider, float cameraY, Vector3[] points)
        {
        }

        private Vector3 GetMaxPosition(Vector3 cameraPos, Vector3 cameraForward, Vector3 topPos, Vector3 bottomPos)
        {
            return default(Vector3);
        }

        private BoxCollider GetHitBoxCollider(Vector3 cameraPos, Vector3 leftPos, Vector3 rightPos, Vector3 forward)
        {
            return null;
        }

        private float GetAngle(BoxCollider boxCollider, Vector3 cameraPos, Vector3 cameraForward, Vector3 leftDir, Vector3 rightDir)
        {
            return default(float);
        }

        private void OnDrawGizmos()
        {
        }

        public PhotographyActivityBlockingCinemachine()
        {
        }

        [CompilerGenerated]
        private bool _003CGetHitBoxCollider_003Eg__IsHit_007C23_0(Vector3 targetPos, ref _003C_003Ec__DisplayClass23_0 P_1)
        {
            return default(bool);
        }
    }
}
