namespace Campus.Live
{
    using global::Cinemachine;
    using global::UnityEngine;

    public class CampusLiveCameraTranslation : CinemachineExtension
    {
        private Vector2 _moveOffset;
        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
        }

        public void ResetOffset()
        {
        }

        public void SetOffset(Vector2 offset)
        {
        }

        public CampusLiveCameraTranslation()
        {
        }
    }
}
