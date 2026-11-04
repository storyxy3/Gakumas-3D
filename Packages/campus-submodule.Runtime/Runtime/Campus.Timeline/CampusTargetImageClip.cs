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
        public CampusTargetImageClipBehaviour behaviour = new CampusTargetImageClipBehaviour();
        public ClipCaps clipCaps
        {
            get
            {
                return ClipCaps.None;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            behaviour.trackingTarget = trackingTargetReference.Resolve(graph.GetResolver());
            return ScriptPlayable<CampusTargetImageClipBehaviour>.Create(graph, behaviour);
        }

        public CampusTargetImageClip()
        {
        }
    }
}
