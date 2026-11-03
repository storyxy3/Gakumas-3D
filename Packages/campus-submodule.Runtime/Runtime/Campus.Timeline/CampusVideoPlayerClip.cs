namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class CampusVideoPlayerClip : PlayableAsset, ITimelineClipAsset
    {
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

        public CampusVideoPlayerClip()
        {
        }
    }
}
