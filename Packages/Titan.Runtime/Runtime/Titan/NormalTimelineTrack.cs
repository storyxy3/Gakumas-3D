namespace Titan
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(PlayableDirector))]
    [TrackClipType(typeof(NormalTimelineClip))]
    [DisplayName("Titan/Nest/NormalTimeline")]
    public class NormalTimelineTrack : TweenTrackBase<NormalTimelineClip, PlayableDirector>
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static DOGetter<float> _003C_003E9__0_0;
            public _003C_003Ec()
            {
            }

            internal float _003CGetTween_003Eb__0_0()
            {
                return default(float);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public PlayableDirector component;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal void _003CGetTween_003Eb__1(float x)
            {
            }
        }

        protected override Tween GetTween(PlayableDirector component, NormalTimelineClip clipAsset, float duration)
        {
            return null;
        }

        public NormalTimelineTrack()
        {
        }
    }
}
