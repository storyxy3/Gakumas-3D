namespace Campus.Common
{
    using global::Campus.Common;
    using global::Cinemachine;
    using global::UnityEngine;

    [ExecuteAlways]
    [SaveDuringPlay]
    public class HomeEnvironmentCinemachineController : CinemachineExtension
    {
        [SerializeField]
        private Vector2 _horizontalAngleLimit;
        [SerializeField]
        private Vector2 _verticalAngleLimit;
        private float _horizontalAngle;
        private float _verticalAngle;
        public Vector2 HorizontalAngleLimit
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 VerticalAngleLimit
        {
            get
            {
                return default(Vector2);
            }
        }

        public float HorizontalAngle
        {
            get
            {
                return default(float);
            }
        }

        public float VerticalAngle
        {
            get
            {
                return default(float);
            }
        }

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
        }

        public HomeEnvironmentCinemachineController Initialize(Vector2 horizontal, Vector2 vertical)
        {
            return null;
        }

        public void ResetAngle()
        {
        }

        public void SetAngle(float horizontal, float vertical)
        {
        }

        public void AddAngle(float horizontal, float vertical)
        {
        }

        public void SetHorizontalAngle(float horizontal)
        {
        }

        public void SetVerticalAngle(float vertical)
        {
        }

        public HomeEnvironmentCinemachineController()
        {
        }
    }
}
