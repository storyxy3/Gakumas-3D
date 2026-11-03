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
            return default(Playable);
        }

        public MobAudiencePenlightOverrideTrack()
        {
        }
    }
}
