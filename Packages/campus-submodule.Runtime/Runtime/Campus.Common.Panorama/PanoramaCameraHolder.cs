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
            SwitchPanoramaCamera[] cameras;
            switch (type)
            {
                case PanoramaCameraType.Focus: cameras = _focusCameras; break;
                case PanoramaCameraType.Crane: cameras = _craneCameras; break;
                case PanoramaCameraType.Drone: return index == 0 ? _droneCamera : null;
                case PanoramaCameraType.Stage: cameras = _stageCameras; break;
                default: return null;
            }
            return index >= 0 && cameras != null && index < cameras.Length ? cameras[index] : null;
        }

        public IReadOnlyDictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> GetAllPanoramaCameras()
        {
            var cameras = new Dictionary<(PanoramaCameraType, int), SwitchPanoramaCamera>();
            AddCameras(cameras, PanoramaCameraType.Focus, _focusCameras);
            AddCameras(cameras, PanoramaCameraType.Crane, _craneCameras);
            if (_droneCamera != null) cameras[(PanoramaCameraType.Drone, 0)] = _droneCamera;
            AddCameras(cameras, PanoramaCameraType.Stage, _stageCameras);
            return cameras;
        }

        private SwitchPanoramaCamera[] GetCameraArray(PanoramaCameraType type)
        {
            return null;
        }

        private static void AddCameras(Dictionary<(PanoramaCameraType, int), SwitchPanoramaCamera> dict, PanoramaCameraType type, SwitchPanoramaCamera[] cameras)
        {
            if (cameras == null) return;
            for (int i = 0; i < cameras.Length; i++)
            {
                if (cameras[i] == null) continue;
                dict[(type, i)] = cameras[i];
            }
        }

        public PanoramaCameraHolder()
        {
        }
    }
}
