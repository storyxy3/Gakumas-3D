namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class AudiencePenlightTimelineAsset : PlayableAsset, ITimelineClipAsset
    {
        public AudiencePenlightTimelineBehaviour behaviour = new AudiencePenlightTimelineBehaviour();
        public ClipCaps clipCaps
        {
            get
            {
                return ClipCaps.SpeedMultiplier;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return ScriptPlayable<AudiencePenlightTimelineBehaviour>.Create(graph, behaviour);
        }

        public AudiencePenlightTimelineAsset()
        {
        }
    }
}
