namespace Campus.Common.Panorama
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.Panorama;
    using global::UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(SphereCollider))]
    public class PanoramaDroneActivityController : SwitchPanoramaCamera, IPanoramaGyroCamera, IPanoramaMoveCamera
    {
        private bool _isInitialized;
        private PanoramaCameraController _cameraController;
        private Rigidbody _rigidbody;
        private SphereCollider _collider;
        [SerializeField]
        private float _minY;
        [SerializeField]
        private float _maxY;
        [SerializeField]
        private float _cameraSpeed;
        [CompilerGenerated]
        private Func<Vector3> _003CGetGyroParameterFunc_003Ek__BackingField;
        private Vector3 _requestAddPosition;
        private Vector3 _requestAddAngle;
        private (int frameCount, bool checkResult) _checkMoveableCameraPositionCache;
        public Func<Vector3> GetGyroParameterFunc
        {
            [CompilerGenerated]
            get
            {
                return _003CGetGyroParameterFunc_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CGetGyroParameterFunc_003Ek__BackingField = value;
            }
        }

        public bool EnableFreeMove
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsAutoLookEnable
        {
            get
            {
                return default(bool);
            }
        }

        private void Start()
        {
        }

        private void InitializeRigidBody()
        {
        }

        private void SetEvent()
        {
        }

        public override void ManualLateUpdate()
        {
        }

        private void AddMoveAndRotate()
        {
        }

        private void MoveCollider()
        {
        }

        private void AddAngleZ(float angleZ)
        {
        }

        public override void OnCameraDisable()
        {
        }

        private void OnCollisionEnter(Collision other)
        {
        }

        private void OnCollisionStay(Collision other)
        {
        }

        public int ColliderCast(RaycastHit[] results, int layerMask)
        {
            return default(int);
        }

        protected override void OnSetZoomFocalLength(float focalLength)
        {
        }

        public void OnGyroStatusChanged(bool isGyro)
        {
        }

        public void ResetGyroParameter()
        {
        }

        public void RequestAddPosition(Vector3 diffPosition)
        {
        }

        public void RequestAddAngle(Vector3 diffAngle)
        {
        }

        public void ResetAngle()
        {
        }

        public void ResetPosition()
        {
        }

        public void SetTransform(Vector3 position, Vector3 angle)
        {
        }

        public void SetAutoLookEnable(bool isEnable)
        {
        }

        public void SetAutoLookTarget(ICampusActorController target)
        {
        }

        public void AddAutoLookAdjustAngle(Vector3 angle)
        {
        }

        public PanoramaDroneActivityController()
        {
        }

        [CompilerGenerated]
        private Vector3 _003CSetEvent_003Eb__20_0()
        {
            return default(Vector3);
        }
    }
}
