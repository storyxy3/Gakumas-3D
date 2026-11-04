namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusBpmTimelineAsset : PlayableAsset
    {
        [SerializeField]
        public CampusBpmTimelineBehaviour behaviour;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return Playable.Null;
        }

        public CampusBpmTimelineAsset()
        {
        }
    }
}
