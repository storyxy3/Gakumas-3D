namespace Campus.Common.Panorama
{
    using global::System.Collections.Generic;
    using global::Campus.Common.Panorama;
    using global::UnityEngine;

    public class PanoramaCameraHolder : MonoBehaviour
    {
        [SerializeField]
        private SwitchPanoramaCamera[] _focusCameras;
        [SerializeField]
        private SwitchPanoramaCamera[] _craneCameras;
        [SerializeField]
        private SwitchPanoramaCamera _droneCamera;
        [SerializeField]
        private SwitchPanoramaCamera[] _stageCameras;
        public SwitchPanoramaCamera ResolveCamera(PanoramaCameraType type, int index)
        {
            return null;
        }

        public IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> GetAllPanoramaCameras()
        {
            return null;
        }

        private SwitchPanoramaCamera[] GetCameraArray(PanoramaCameraType type)
        {
            return null;
        }

        private static void AddCameras(Dictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> dict, PanoramaCameraType type, SwitchPanoramaCamera[] cameras)
        {
        }

        public PanoramaCameraHolder()
        {
        }
    }
}
