namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(TitanPlayer))]
    [TrackClipType(typeof(TitanControlClip))]
    [DisplayName("Titan/TitanControl")]
    public class TitanControlTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public TitanControlTrack()
        {
        }
    }
}
