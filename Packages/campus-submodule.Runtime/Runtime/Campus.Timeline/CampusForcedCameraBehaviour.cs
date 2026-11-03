namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Common.Panorama;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusForcedCameraBehaviour : PlayableBehaviour
    {
        public PanoramaCameraType CameraType;
        public int CameraIndex;
        public CampusForcedCameraBehaviour()
        {
        }
    }
}
