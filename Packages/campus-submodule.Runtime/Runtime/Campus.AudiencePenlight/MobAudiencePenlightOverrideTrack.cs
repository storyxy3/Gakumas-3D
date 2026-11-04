namespace Campus.AudiencePenlight
{
    using global::System;
    using global::Campus.AudiencePenlight;
    using global::Campus.MobAudience;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(MobAudiencePenlightController))]
    [TrackClipType(typeof(MobAudiencePenlightOverrideAsset))]
    public class MobAudiencePenlightOverrideTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            if (!go.TryGetComponent<PlayableDirector>(out var director)) return base.CreateTrackMixer(graph, go, inputCount);
            var playable = ScriptPlayable<MobAudiencePenlightOverrideMixerBehaviour>.Create(graph, inputCount);
            var target = director.GetGenericBinding(this) as global::Campus.MobAudience.MobAudiencePenlightController;
            if (target == null) return base.CreateTrackMixer(graph, go, inputCount);
            playable.GetBehaviour().MobAudiencePenlightController = target;
            return playable;
        }

        public MobAudiencePenlightOverrideTrack()
        {
        }
    }
}
