namespace Campus.Common.Live
{
    using global::Cinemachine;
    using global::UnityEngine;

    [ExecuteInEditMode]
    public class CampusLiveCameraOverlay : MonoBehaviour
    {
        [SerializeField]
        private float _offset;
        [SerializeField]
        private float _scalerMagnification;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnCameraUpdated(CinemachineBrain brain)
        {
        }

        private void SetCameraTransform(CinemachineBrain onCameraUpdated, float near)
        {
        }

        private void SetCameraScaler(float near)
        {
        }

        public CampusLiveCameraOverlay()
        {
        }
    }
}
