namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class MobAudiencePenlightOverrideAsset : PlayableAsset, ITimelineClipAsset
    {
        public MobAudiencePenlightOverrideBehaviour behaviour;
        public ClipCaps clipCaps
        {
            get
            {
                return ClipCaps.None;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return ScriptPlayable<MobAudiencePenlightOverrideBehaviour>.Create(graph, behaviour);
        }

        public MobAudiencePenlightOverrideAsset()
        {
        }
    }
}
