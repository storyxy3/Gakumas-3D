namespace VL.Animation.Timeline
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::VL.Animation;
    using global::VL.Animation.Timeline;

    [Serializable]
    [TrackClipType(typeof(MotionDefinePlayerTimelineAsset), false)]
    [TrackBindingType(typeof(MotionDefinePlayer))]
    [TrackColor(0.1f, 0f, 1f)]
    public class MotionDefinePlayerTimelineTrack : PlayableTrack, ILayerable
    {
        protected override void OnCreateClip(TimelineClip clip)
        {
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        private LayerParam CreateLayerParams(PlayableGraph graph, int index, IEnumerable<TimelineClip> clips)
        {
            return null;
        }

        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public MotionDefinePlayerTimelineTrack()
        {
        }
    }
}
