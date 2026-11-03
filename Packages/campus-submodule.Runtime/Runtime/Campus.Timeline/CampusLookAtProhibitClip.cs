namespace Campus.Timeline
{
    using global::System;
    using global::System.ComponentModel;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [DisplayName("振り向き禁止クリップ")]
    public class CampusLookAtProhibitClip : PlayableAsset, ITimelineClipAsset
    {
        public CampusLookAtProhibitBehaviour behaviour;
        public ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public CampusLookAtProhibitClip()
        {
        }
    }
}
