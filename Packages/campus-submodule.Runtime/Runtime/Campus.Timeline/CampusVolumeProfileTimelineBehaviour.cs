namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Rendering;

    [Serializable]
    public class CampusVolumeProfileTimelineBehaviour : PlayableBehaviour
    {
        public VolumeProfile volumeProfile;
        public double startTime;
        public CampusVolumeProfileTimelineBehaviour()
        {
        }
    }
}
