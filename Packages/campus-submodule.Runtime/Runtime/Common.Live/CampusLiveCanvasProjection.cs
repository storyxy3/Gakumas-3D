namespace Common.Live
{
    using global::Cinemachine;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasScaler))]
    public class CampusLiveCanvasProjection : MonoBehaviour
    {
        private CanvasScaler _canvasScaler;
        private Vector2 _initialResolution;
        private CinemachineBrain _cinemachineBrain;
        private float _initialSensorSizeY;
        private void OnEnable()
        {
        }

        private void OnCameraUpdated(CinemachineBrain brain)
        {
        }

        private void OnDisable()
        {
        }

        public CampusLiveCanvasProjection()
        {
        }
    }
}
