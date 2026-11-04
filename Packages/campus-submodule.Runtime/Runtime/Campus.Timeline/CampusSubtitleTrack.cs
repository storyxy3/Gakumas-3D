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
            var text = director.GetGenericBinding(this) as global::TMPro.TMP_Text;
            if (text != null) driver.AddFromName<global::TMPro.TMP_Text>(text.gameObject, "m_text");
            base.GatherProperties(director, driver);
        }

        public CampusSubtitleTrack()
        {
        }
    }
}
