namespace Campus.Photography
{
    using global::Campus.Common;
    using global::Campus.Photography;
    using global::Cinemachine;
    using global::UnityEngine;

    public class PhotographyActivityCameraController : MonoBehaviour
    {
        private const float RotateSpeed = 0.09f;
        [SerializeField]
        private CinemachineVirtualCamera _virtualCamera;
        private PhotographyActivityBlockingCinemachine _blockingCinemachine;
        private Transform _cameraTransform;
        [SerializeField]
        private float _slideSpeed;
        private CampusGyroController _gyroController;
        private Quaternion _gyroStartCameraRotation;
        private Quaternion _gyroSwipeAddRotationX;
        private Quaternion _gyroSwipeAddRotationY;
        private float _gyroAngleZ;
        private Vector3 _addRotation;
        private bool _isAngleZRequested;
        private Vector3 _lookAtTarget;
        private bool _isAutoLookAtEnable;
        private float _maxLocalHeight;
        private float _minLocalHeight;
        public CinemachineVirtualCamera VirtualCamera
        {
            get
            {
                return null;
            }
        }

        public Vector3 CameraPosition
        {
            get
            {
                return default(Vector3);
            }
        }

        public Vector3 CameraAngle
        {
            get
            {
                return default(Vector3);
            }
        }

        public bool IsAutoLookAtEnable
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsBlockingHit
        {
            get
            {
                return default(bool);
            }
        }

        public int Priority
        {
            set
            {
            }
        }

        public void Initialize(CampusGyroController gyroController)
        {
        }

        public void SetAngleData(float angleX, float angleY)
        {
        }

        public void MoveY(float diffDelta)
        {
        }

        public void SetCameraY(float posY)
        {
        }

        public void SetZoomRatio(float ratio)
        {
        }

        public void SetGyroActive(bool isActive)
        {
        }

        public void ResetGyro()
        {
        }

        private void ResetGyroParameter()
        {
        }

        public void ResetGyroAngleZ()
        {
        }

        public void Rotate(Vector2 diffDelta)
        {
        }

        public void SetAngleZ(float angleZ)
        {
        }

        public void SetLookTarget(ICampusActorController actorController, float offset)
        {
        }

        public void RequestLookAtTarget(Vector3 position)
        {
        }

        public void SetLookAtEnable(bool isEnable)
        {
        }

        public void UpdateRotate()
        {
        }

        public void SetCameraHeightLimit(float minHeight, float maxHeight)
        {
        }

        public PhotographyActivityCameraController()
        {
        }
    }
}
