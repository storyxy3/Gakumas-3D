namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class CampusSubTitleTimelineAsset : PlayableAsset, ITimelineClipAsset
    {
        public CampusSubtitleBehaviour behaviour = new CampusSubtitleBehaviour();
        public ClipCaps clipCaps
        {
            get
            {
                return ClipCaps.ClipIn;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return ScriptPlayable<CampusSubtitleBehaviour>.Create(graph, behaviour);
        }

        public CampusSubTitleTimelineAsset()
        {
        }
    }
}
