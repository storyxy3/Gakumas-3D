namespace Campus.Timeline
{
    using global::System;
    using global::Campus.live;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(CampusLiveVolumeController))]
    [TrackClipType(typeof(CampusVolumeProfileTimelineAsset), false)]
    public class CampusVolumeProfileTimelineTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            return default(Playable);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusVolumeProfileTimelineTrack()
        {
        }
    }
}
