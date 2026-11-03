namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine.Playables;

    public class CrowdTimelineMixerBehaviour : PlayableBehaviour
    {
        public CrowdAnimationTimeline crowdAnimationTimeline;
        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public CrowdTimelineMixerBehaviour()
        {
        }
    }
}
