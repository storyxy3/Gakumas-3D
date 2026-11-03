namespace Campus.Common
{
    using global::Campus.Common;
    using global::Cinemachine;
    using global::UnityEngine;

    [ExecuteAlways]
    [AddComponentMenu("")]
    [SaveDuringPlay]
    public class CampusCinemachineRelativeScaleController : CinemachineExtension
    {
        [SerializeField]
        private CampusVirtualActorController _virtualActorController;
        private ICampusActorController _campusActorController;
        [SerializeField]
        private float _minCameraHeight;
        [SerializeField]
        private float _maxCameraHeight;
        public CampusVirtualActorController VirtualActorController
        {
            get
            {
                return null;
            }
        }

        public float MinCameraHeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float MaxCameraHeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
        }

        private float GetHumanScale()
        {
            return default(float);
        }

        public void SetActorController(ICampusActorController actorController)
        {
        }

        public void SetVirtualActorController(CampusVirtualActorController actorController)
        {
        }

        public CampusCinemachineRelativeScaleController()
        {
        }
    }
}
