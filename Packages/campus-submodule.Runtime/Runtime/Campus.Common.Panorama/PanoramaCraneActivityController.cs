namespace Campus.Common.Panorama
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.Panorama;
    using global::UnityEngine;

    public class PanoramaCraneActivityController : SwitchPanoramaCamera, IPanoramaGyroCamera, IPanoramaMoveCamera
    {
        [SerializeField]
        private float _minY;
        [SerializeField]
        private float _maxY;
        [SerializeField]
        private float _cameraSpeed;
        [SerializeField]
        private float _minAngleXOffset;
        [SerializeField]
        private float _maxAngleXOffset;
        [SerializeField]
        private float _minAngleYOffset;
        [SerializeField]
        private float _maxAngleYOffset;
        private PanoramaCameraController _cameraController;
        [CompilerGenerated]
        private Func<Vector3> _003CGetGyroParameterFunc_003Ek__BackingField;
        private Vector3 _requestAddPosition;
        private Vector3 _requestAddAngle;
        public PanoramaCameraController CameraController
        {
            get
            {
                return null;
            }
        }

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

        private void SetEvent()
        {
        }

        public override void ManualLateUpdate()
        {
        }

        private void AddAngle(Vector2 diffAngle)
        {
        }

        private Vector3 ClampAngleLimit(Vector3 angle)
        {
            return default(Vector3);
        }

        private float NormalizeAngle(float angle)
        {
            return default(float);
        }

        private float GetAngleDifference(float from, float to)
        {
            return default(float);
        }

        protected override void OnSetZoomFocalLength(float focalLength)
        {
        }

        private void AddAngleZ(float angleZ)
        {
        }

        private void AddPosition(Vector3 addPosition)
        {
        }

        public override void OnCameraDisable()
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

        public void SetAutoLookEnable(bool isEnable)
        {
        }

        public void SetAutoLookTarget(ICampusActorController target)
        {
        }

        public void AddAutoLookAdjustAngle(Vector3 angle)
        {
        }

        public PanoramaCraneActivityController()
        {
        }

        [CompilerGenerated]
        private Vector3 _003CSetEvent_003Eb__21_0()
        {
            return default(Vector3);
        }
    }
}
