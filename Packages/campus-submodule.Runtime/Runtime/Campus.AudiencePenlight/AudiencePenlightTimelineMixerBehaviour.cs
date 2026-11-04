namespace Campus.AudiencePenlight
{
    using global::Campus.AudiencePenlight;
    using global::UnityEngine.Playables;

    public class AudiencePenlightTimelineMixerBehaviour : PlayableBehaviour
    {
        public AudiencePenlightTimeline AudiencePenlightTimeline;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (AudiencePenlightTimeline == null) return;
            int count = playable.GetInputCount();
            for (int i = 0; i < count; i++)
            {
                if (playable.GetInputWeight(i) <= 0f) continue;
                var behaviour = ((ScriptPlayable<AudiencePenlightTimelineBehaviour>)playable.GetInput(i)).GetBehaviour();
                AudiencePenlightTimeline.SetUsePenlightColorProjection(behaviour.UseColorProjection);
                if (behaviour.UseColorProjection) AudiencePenlightTimeline.SetPenlightProjectionUvRect(behaviour.ProjectionUvRectMin, behaviour.ProjectionUvRectMax);
                else AudiencePenlightTimeline.SetPenlightColorTable(behaviour.ColorTable);
            }
        }

        public AudiencePenlightTimelineMixerBehaviour()
        {
        }
    }
}
