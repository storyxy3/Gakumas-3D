namespace VL.Timeline.Legacy
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::VL.Animation.Legacy;
    using global::VL.Timeline.Legacy;

    [Serializable]
    [TrackClipType(typeof(VLAnimationClipPlayerTimelineAsset), false)]
    [TrackBindingType(typeof(VLAnimationClipPlayer))]
    [TrackColor(0.1f, 0f, 1f)]
    public class VLAnimationClipPlayerTimelineTrack : PlayableTrack
    {
        protected override void OnCreateClip(TimelineClip clip)
        {
        }

        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            return default(Playable);
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public VLAnimationClipPlayerTimelineTrack()
        {
        }
    }
}
