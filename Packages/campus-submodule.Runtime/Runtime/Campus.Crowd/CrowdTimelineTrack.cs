namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(CrowdAnimationTimeline))]
    [TrackClipType(typeof(CrowdTimelineAsset))]
    public class CrowdTimelineTrack : PlayableTrack, ILayerable
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<TimelineClip, int, (CrowdTimelineBehaviour behaviour, int index)> _003C_003E9__0_0;
            public static Func<TimelineClip, int, (CrowdTimelineBehaviour behaviour, int index)> _003C_003E9__0_1;
            public _003C_003Ec()
            {
            }

            internal (CrowdTimelineBehaviour, int) _003CCreateLayerMixer_003Eb__0_0(TimelineClip clip, int index)
            {
                return default((CrowdTimelineBehaviour, int));
            }

            internal (CrowdTimelineBehaviour, int) _003CCreateLayerMixer_003Eb__0_1(TimelineClip clip, int index)
            {
                return default((CrowdTimelineBehaviour, int));
            }
        }

        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public CrowdTimelineTrack()
        {
        }
    }
}
