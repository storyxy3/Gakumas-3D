namespace Campus.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackBindingType(typeof(CampusTimelineCriVideoPlayer))]
    [TrackClipType(typeof(CampusCriVideoPlayerAsset))]
    public class CampusCriVideoPlayerTrack : PlayableTrack
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<double, double> _003C_003E9__0_2;
            public _003C_003Ec()
            {
            }

            internal double _003CCreatePlayable_003Eb__0_2(double time)
            {
                return default(double);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public TimelineClip clip;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal bool _003CCreatePlayable_003Eb__0(CampusCriVideoSyncMarker marker)
            {
                return default(bool);
            }

            internal double _003CCreatePlayable_003Eb__1(CampusCriVideoSyncMarker marker)
            {
                return default(double);
            }
        }

        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            return default(Playable);
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        public CampusCriVideoPlayerTrack()
        {
        }
    }
}
