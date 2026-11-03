namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class CampusTargetImageClip : PlayableAsset, ITimelineClipAsset
    {
        [SerializeField]
        public ExposedReference<Transform> trackingTargetReference;
        public CampusTargetImageClipBehaviour behaviour;
        public ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            return default(Playable);
        }

        public CampusTargetImageClip()
        {
        }
    }
}
