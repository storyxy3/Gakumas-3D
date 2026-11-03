namespace VL.Animation.Timeline
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
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
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<TimelineClip, bool> _003C_003E9__2_0;
            public static Func<TrackAsset, bool> _003C_003E9__3_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CCreateLayerParams_003Eb__2_0(TimelineClip x)
            {
                return default(bool);
            }

            internal bool _003CCreateLayerMixer_003Eb__3_0(TrackAsset x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public PlayableGraph graph;
            public bool isAdditive;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal ClipParam _003CCreateLayerParams_003Eb__1(TimelineClip clip)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public MotionDefinePlayerTimelineTrack _003C_003E4__this;
            public PlayableGraph graph;
            public MotionDefinePlayer player;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal ILayerAnimationController _003CCreateLayerMixer_003Eb__1(TrackAsset track, int index)
            {
                return null;
            }
        }

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
