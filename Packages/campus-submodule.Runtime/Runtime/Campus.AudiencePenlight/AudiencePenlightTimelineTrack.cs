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
            if (!go.TryGetComponent<PlayableDirector>(out var director)) return base.CreateTrackMixer(graph, go, inputCount);
            var playable = ScriptPlayable<AudiencePenlightTimelineMixerBehaviour>.Create(graph, inputCount);
            var target = director.GetGenericBinding(this) as AudiencePenlightTimeline;
            if (target == null) return base.CreateTrackMixer(graph, go, inputCount);
            playable.GetBehaviour().AudiencePenlightTimeline = target;
            return playable;
        }

        public AudiencePenlightTimelineTrack()
        {
        }
    }
}
