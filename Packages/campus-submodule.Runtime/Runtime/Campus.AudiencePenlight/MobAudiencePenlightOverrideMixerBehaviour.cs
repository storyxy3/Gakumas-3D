namespace Campus.AudiencePenlight
{
    using global::Campus.MobAudience;
    using global::UnityEngine.Playables;

    public class MobAudiencePenlightOverrideMixerBehaviour : PlayableBehaviour
    {
        public MobAudiencePenlightController MobAudiencePenlightController;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (MobAudiencePenlightController == null) return;
            MobAudiencePenlightController.ClearOverrides();
            int count = playable.GetInputCount();
            for (int i = 0; i < count; i++)
            {
                if (playable.GetInputWeight(i) <= 0f) continue;
                var behaviour = ((ScriptPlayable<MobAudiencePenlightOverrideBehaviour>)playable.GetInput(i)).GetBehaviour();
                MobAudiencePenlightController.SetOverrides(behaviour.Overrides);
            }
        }

        public MobAudiencePenlightOverrideMixerBehaviour()
        {
        }
    }
}
