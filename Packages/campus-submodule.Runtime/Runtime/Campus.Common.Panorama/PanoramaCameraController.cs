namespace Campus.Common.Panorama
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Cinemachine;
    using global::UnityEngine;

    public class PanoramaCameraController
    {
        private const float RotateSpeed = 0.05f;
        private CinemachineVirtualCamera _virtualCamera;
        private Transform _cameraTransform;
        private Quaternion _gyroStartCameraRotation;
        private Quaternion _gyroSwipeAddRotationX;
        private Quaternion _gyroSwipeAddRotationY;
        private float _gyroAngleZ;
        private Vector3 _addRotation;
        private bool _isAngleZRequested;
        private Vector3 _prevLookAtPosition;
        private (Transform head, Transform leftEye, Transform rightEye) _lookAtTargets;
        [CompilerGenerated]
        private bool _003CIsAutoLookEnable_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CAutoLookAdjustAngle_003Ek__BackingField;
        private float _maxLocalHeight;
        private float _minLocalHeight;
        [CompilerGenerated]
        private bool _003CIsGyroActive_003Ek__BackingField;
        [CompilerGenerated]
        private Func<Vector3> _003CGetGyroParameter_003Ek__BackingField;
        [CompilerGenerated]
        private Func<Vector3, Vector3> _003CGetClampAngleLimit_003Ek__BackingField;
        public bool IsAutoLookEnable
        {
            [CompilerGenerated]
            get
            {
                return _003CIsAutoLookEnable_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsAutoLookEnable_003Ek__BackingField = value;
            }
        }

        public Vector3 AutoLookAdjustAngle
        {
            [CompilerGenerated]
            get
            {
                return _003CAutoLookAdjustAngle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAutoLookAdjustAngle_003Ek__BackingField = value;
            }
        }

        public bool IsGyroActive
        {
            [CompilerGenerated]
            get
            {
                return _003CIsGyroActive_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsGyroActive_003Ek__BackingField = value;
            }
        }

        public Func<Vector3> GetGyroParameter
        {
            [CompilerGenerated]
            get
            {
                return _003CGetGyroParameter_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CGetGyroParameter_003Ek__BackingField = value;
            }
        }

        public Func<Vector3, Vector3> GetClampAngleLimit
        {
            [CompilerGenerated]
            get
            {
                return _003CGetClampAngleLimit_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CGetClampAngleLimit_003Ek__BackingField = value;
            }
        }

        public void Initialize(CinemachineVirtualCamera virtualCamera)
        {
        }

        public void ResetGyroParameter()
        {
        }

        public void Rotate(Vector2 diffDelta)
        {
        }

        public void AddAngleZ(float angleZ)
        {
        }

        public void RequestLookAtTarget(ICampusActorController target)
        {
        }

        public void SetAutoLookEnable(bool isEnable)
        {
        }

        public void UpdateRotate()
        {
        }

        public PanoramaCameraController()
        {
        }

        [CompilerGenerated]
        private Vector3 _003CUpdateRotate_003Eg__GetNextAngle_007C51_0()
        {
            return default(Vector3);
        }
    }
}
