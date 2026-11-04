namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [Serializable]
    [TrackClipType(typeof(CampusTargetImageClip))]
    [TrackBindingType(typeof(RawImage))]
    [TrackColor(0.008f, 0.698f, 0.655f)]
    public class CampusTargetImageTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<CampusTargetImageTrackBehaviour>.Create(graph, inputCount);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
            base.GatherProperties(director, driver);
        }

        public CampusTargetImageTrack()
        {
        }
    }
}
