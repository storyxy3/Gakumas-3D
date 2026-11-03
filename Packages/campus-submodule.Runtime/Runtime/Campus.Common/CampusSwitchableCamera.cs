namespace Campus.Common
{
    using global::Campus.Live;
    using global::Cinemachine;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CampusSwitchableCamera : MonoBehaviour
    {
        public CinemachineVirtualCamera virtualCamera;
        public PlayableDirector director;
        private CinemachineDollyCart _dollyCartCache;
        private bool _isTryGetDollyCart;
        [SerializeField]
        private Vector2 _offsetLimitMin;
        [SerializeField]
        private Vector2 _offsetLimitMax;
        private CampusLiveCameraTranslation _cameraTranslation;
        private CinemachineDollyCart GetCinemachineDollyCart()
        {
            return null;
        }

        public void SetDollyCartEnable(bool isEnable)
        {
        }

        public void ResetTranslationOffset()
        {
        }

        public void SetTranslationOffset(Vector2 offset)
        {
        }

        private CampusLiveCameraTranslation GetOrAddCameraTranslation()
        {
            return null;
        }

        private void OnValidate()
        {
        }

        public CampusSwitchableCamera()
        {
        }
    }
}
