namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class CampusSubTitleTimelineAsset : PlayableAsset, ITimelineClipAsset
    {
        public CampusSubtitleBehaviour behaviour;
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

        public CampusSubTitleTimelineAsset()
        {
        }
    }
}
