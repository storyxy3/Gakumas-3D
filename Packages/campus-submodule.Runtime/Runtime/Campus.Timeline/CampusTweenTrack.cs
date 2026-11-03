namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusTweenAsset))]
    [TrackBindingType(typeof(Transform))]
    public class CampusTweenTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusTweenTrack()
        {
        }
    }
}
