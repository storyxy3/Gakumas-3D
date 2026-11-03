namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.MobAudience;
    using global::UnityEngine.Playables;

    [Serializable]
    public class MobAudiencePenlightOverrideBehaviour : PlayableBehaviour
    {
        public MobAudiencePenlightOverride[] Overrides;
        public MobAudiencePenlightOverrideBehaviour()
        {
        }
    }
}
