namespace Campus.Common.Panorama
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Common.Panorama;
    using global::Campus.Live;
    using global::Cinemachine;
    using global::UnityEngine;

    public class SwitchPanoramaCamera : MonoBehaviour
    {
        [SerializeField]
        private CinemachineVirtualCamera _virtualCamera;
        [SerializeField]
        private PanoramaCameraType _cameraType;
        [SerializeField]
        [Header("Height Correction")]
        private SwitchPanoramaCameraHeightCorrectionUtility _heightCorrectionUtility;
        [CompilerGenerated]
        private float _003CInitialZoomRatio_003Ek__BackingField;
        private bool _isActiveCamera;
        [CompilerGenerated]
        private Vector3 _003CInitialCameraPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CInitialCameraLocalPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CInitialCameraLocalAngle_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CInitialFocusLength_003Ek__BackingField;
        [SerializeField]
        private float _zoomFocalLengthMin;
        [SerializeField]
        private float _zoomFocalLengthMax;
        [SerializeField]
        [Header("Eye LookAtの上下方向の注視範囲外角度")]
        private float _eyeLookOutVirtualAngle;
        [SerializeField]
        [Header("Eye LookAtの上下方向の復帰範囲内角度")]
        private float _eyeLookAgainVirtualAngle;
        [SerializeField]
        [Header("Eye LookAtの左右方向の注視範囲外角度")]
        private float _eyeLookOutHorizontalAngle;
        [SerializeField]
        [Header("Eye LookAtの左右方向の復帰範囲内角度")]
        private float _eyeLookAgainHorizontalAngle;
        private CampusLiveCameraTranslation _cameraTranslation;
        private float _cameraTranslationRatio;
        private Vector2 _cameraTranslationOffset;
        public CinemachineVirtualCamera VirtualCamera
        {
            get
            {
                return _virtualCamera;
            }
        }

        public PanoramaCameraType CameraType
        {
            get
            {
                return default(PanoramaCameraType);
            }
        }

        public CampusVirtualActorController VirtualActorController
        {
            get
            {
                return null;
            }
        }

        public float CurrentZoomRatio
        {
            get
            {
                return default(float);
            }
        }

        public float InitialZoomRatio
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsActiveCamera
        {
            get
            {
                return default(bool);
            }
        }

        protected Vector3 InitialCameraPosition
        {
            [CompilerGenerated]
            get
            {
                return default(Vector3);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        protected Vector3 InitialCameraLocalPosition
        {
            [CompilerGenerated]
            get
            {
                return default(Vector3);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        protected Vector3 InitialCameraLocalAngle
        {
            [CompilerGenerated]
            get
            {
                return default(Vector3);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        protected float InitialFocusLength
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public float EyeLookOutVirtualAngle
        {
            get
            {
                return default(float);
            }
        }

        public float EyeLookAgainVirtualAngle
        {
            get
            {
                return default(float);
            }
        }

        public float EyeLookOutHorizontalAngle
        {
            get
            {
                return default(float);
            }
        }

        public float EyeLookAgainHorizontalAngle
        {
            get
            {
                return default(float);
            }
        }

        private void Awake()
        {
        }

        protected void SetInitialTransform(Transform initialTransform)
        {
        }

        [ContextMenu("身長差を考慮してセットアップ")]
        public void SetupTransformWithHeightCorrection()
        {
        }

        public virtual void ManualLateUpdate()
        {
        }

        public virtual void OnCameraEnable()
        {
        }

        public virtual void OnCameraDisable()
        {
        }

        public void SetZoomRatio(float ratio)
        {
        }

        public void SetZoomFocalLength(float focusLength)
        {
        }

        protected virtual void OnSetZoomFocalLength(float focalLength)
        {
        }

        public void ResetZoomRatio()
        {
        }

        protected float GetZoomRatio(float focalLength)
        {
            return default(float);
        }

        protected float GetFocalLength(float zoomRatio)
        {
            return default(float);
        }

        public void ResetTranslationOffset()
        {
        }

        public void AddTranslationOffset(Vector2 offset)
        {
        }

        public void SetTranslationRatio(float ratio)
        {
        }

        private void ApplyCameraTranslationOffset()
        {
        }

        private CampusLiveCameraTranslation GetOrAddCameraTranslation()
        {
            return null;
        }

        private void OnValidate()
        {
        }

        public SwitchPanoramaCamera()
        {
        }
    }
}
