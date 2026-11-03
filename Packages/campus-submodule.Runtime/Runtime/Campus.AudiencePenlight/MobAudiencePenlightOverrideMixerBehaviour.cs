namespace Campus.AudiencePenlight
{
    using global::Campus.MobAudience;
    using global::UnityEngine.Playables;

    public class MobAudiencePenlightOverrideMixerBehaviour : PlayableBehaviour
    {
        public MobAudiencePenlightController MobAudiencePenlightController;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public MobAudiencePenlightOverrideMixerBehaviour()
        {
        }
    }
}
