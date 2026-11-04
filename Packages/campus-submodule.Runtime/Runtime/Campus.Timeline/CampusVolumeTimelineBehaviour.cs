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
            if (volume != null) volume.weight = weight;
        }

        public void OffsetVolumePriority(float offset)
        {
            if (volume != null) volume.priority = initialVolumePriority + offset;
        }

        public void ResetVolumePriority()
        {
            if (volume != null) volume.priority = initialVolumePriority;
        }

        public CampusVolumeTimelineBehaviour()
        {
        }
    }
}
