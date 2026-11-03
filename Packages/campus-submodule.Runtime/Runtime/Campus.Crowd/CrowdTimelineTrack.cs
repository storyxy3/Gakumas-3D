namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(CrowdAnimationTimeline))]
    [TrackClipType(typeof(CrowdTimelineAsset))]
    public class CrowdTimelineTrack : PlayableTrack, ILayerable
    {
        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public CrowdTimelineTrack()
        {
        }
    }
}
