namespace Campus.Common.Panorama
{
    using global::System;
    using global::Campus.Common;
    using global::Campus.Common.Panorama;
    using global::Cinemachine;
    using global::UnityEngine;

    [Serializable]
    public class SwitchPanoramaCameraHeightCorrectionUtility
    {
        [SerializeField]
        private CampusVirtualActorController _virtualActorController;
        [SerializeField]
        private PanoramaCameraHeightCorrectionType _heightCorrectionType;
        [SerializeField]
        private Vector3 _initialLocalPosition;
        [SerializeField]
        private Vector3 _initialLocalAngle;
        [SerializeField]
        [HideInInspector]
        private bool _isInitialTransformSaved;
        [SerializeField]
        private float _minHeightCameraYOffset;
        [SerializeField]
        private float _maxHeightCameraYOffset;
        public CampusVirtualActorController VirtualActorController
        {
            get
            {
                return null;
            }
        }

        public void SetupTransform(Transform targetTransform, CinemachineVirtualCamera virtualCamera)
        {
        }

        private static PanoramaCameraHeightCorrectionExtension GetHeightCorrectionExtension(CinemachineVirtualCamera virtualCamera, bool addIfMissing)
        {
            return null;
        }

        public SwitchPanoramaCameraHeightCorrectionUtility()
        {
        }
    }
}
