namespace Titan
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening.Core;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public static class TitanAnimationTrackUtility
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static DOGetter<float> _003C_003E9__1_0;
            public _003C_003Ec()
            {
            }

            internal float _003CInsertAnimationClipTween_003Eb__1_0()
            {
                return default(float);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public AnimationClipPlayable playable;
            public PlayableGraph graph;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CInsertAnimationClipTween_003Eb__1(float x)
            {
            }

            internal void _003CInsertAnimationClipTween_003Eb__2()
            {
            }
        }

        public static void InsertAnimationTrackTween(TweenCreationContext context, AnimationTrack track)
        {
        }

        private static void InsertAnimationClipTween(TweenCreationContext context, Animator animator, AnimationClip clip, float start, float duration)
        {
        }
    }
}
