namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    public class CampusBpmTimelineMixer : PlayableBehaviour
    {
        public CampusBpmInfo bpmInfo;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public CampusBpmTimelineMixer()
        {
        }
    }
}
