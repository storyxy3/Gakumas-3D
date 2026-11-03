namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::TMPro;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(CampusSubTitleTimelineAsset))]
    [TrackBindingType(typeof(TMP_Text))]
    public class CampusSubtitleTrack : PlayableTrack
    {
        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusSubtitleTrack()
        {
        }
    }
}
