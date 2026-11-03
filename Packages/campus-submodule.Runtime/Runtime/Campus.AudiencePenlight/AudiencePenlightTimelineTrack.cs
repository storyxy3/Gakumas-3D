namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(AudiencePenlightTimeline))]
    [TrackClipType(typeof(AudiencePenlightTimelineAsset))]
    public class AudiencePenlightTimelineTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public AudiencePenlightTimelineTrack()
        {
        }
    }
}
