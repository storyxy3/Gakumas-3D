namespace Campus.Common.Panorama
{
    using global::Campus.Common;
    using global::Campus.Common.Panorama;
    using global::Cinemachine;
    using global::UnityEngine;

    [ExecuteAlways]
    [AddComponentMenu("")]
    [SaveDuringPlay]
    public class PanoramaCameraHeightCorrectionExtension : CinemachineExtension
    {
        [SerializeField]
        private CampusVirtualActorController _virtualActorController;
        [SerializeField]
        private PanoramaCameraHeightCorrectionType _heightCorrectionType;
        [SerializeField]
        private float _minHeightCameraYOffset;
        [SerializeField]
        private float _maxHeightCameraYOffset;
        public void SetCorrection(PanoramaCameraHeightCorrectionType heightCorrectionType, CampusVirtualActorController virtualActorController, float minHeightCameraYOffset, float maxHeightCameraYOffset)
        {
        }

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
        }

        private void ApplyActorRelativeScale(ref CameraState state)
        {
        }

        private void ApplyRelativeHeight(ref CameraState state)
        {
        }

        public PanoramaCameraHeightCorrectionExtension()
        {
        }
    }
}
