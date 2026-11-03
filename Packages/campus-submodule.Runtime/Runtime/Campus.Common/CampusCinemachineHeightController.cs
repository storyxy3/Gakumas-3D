namespace Campus.Common
{
    using global::Campus.Common;
    using global::Cinemachine;
    using global::UnityEngine;

    [ExecuteAlways]
    [SaveDuringPlay]
    public class CampusCinemachineHeightController : CinemachineExtension
    {
        [SerializeField]
        private CampusVirtualActorController _virtualActorController;
        [SerializeField]
        private bool _useCampusActorControllerMatrix;
        private ICampusActorController _campusActorController;
        public CampusVirtualActorController VirtualActorController
        {
            get
            {
                return null;
            }
        }

        public bool UseCampusActorControllerMatrix
        {
            get
            {
                return default(bool);
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

        private CampusActorController GetPrimaryActorController()
        {
            return null;
        }

        private Matrix4x4 GetWorldToLocalMatrix()
        {
            return default(Matrix4x4);
        }

        private Matrix4x4 GetLocalToWorldMatrix()
        {
            return default(Matrix4x4);
        }

        public void SetActorController(ICampusActorController actorController)
        {
        }

        public void SetVirtualActorController(CampusVirtualActorController actorController)
        {
        }

        public CampusCinemachineHeightController()
        {
        }
    }
}
