namespace Campus.Timeline
{
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Timeline;

    public class CampusVolumeTimelineBehaviour : ActivationControlPlayable
    {
        public Volume volume;
        public float initialVolumePriority;
        public double startTime;
        public void SetVolumeWeight(float weight)
        {
        }

        public void OffsetVolumePriority(float offset)
        {
        }

        public void ResetVolumePriority()
        {
        }

        public CampusVolumeTimelineBehaviour()
        {
        }
    }
}
