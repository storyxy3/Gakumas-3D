namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Common.Live;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusCrossFadeAsset))]
    [TrackBindingType(typeof(CampusCrossFadeImage))]
    public class CampusCrossFadeTrack : PlayableTrack
    {
        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            return default(Playable);
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public CampusCrossFadeTrack()
        {
        }
    }
}
