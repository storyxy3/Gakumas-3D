namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.Video;

    [Serializable]
    [TrackClipType(typeof(CampusVideoPlayerClip))]
    [TrackBindingType(typeof(VideoPlayer))]
    [TrackColor(0.008f, 0.698f, 0.655f)]
    public class CampusVideoPlayerTrack : TrackAsset
    {
        [SerializeField]
        [NotKeyable]
        public bool Loop;
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusVideoPlayerTrack()
        {
        }
    }
}
