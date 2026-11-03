namespace Campus.Gasha
{
    using global::System;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(GashaLightUpClip))]
    [TrackBindingType(typeof(GashaListSequence))]
    public class GashaLightUpTrack : PlayableTrack
    {
        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            return default(Playable);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public GashaLightUpTrack()
        {
        }
    }
}
