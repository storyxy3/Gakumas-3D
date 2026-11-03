namespace Titan
{
    using global::Titan;
    using global::UnityEngine.Playables;

    public class TitanControlMixerBehaviour : PlayableBehaviour
    {
        private ITimelineTween _timelineTween;
        public void SetTimelineTween(ITimelineTween timelineTween)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public TitanControlMixerBehaviour()
        {
        }
    }
}
