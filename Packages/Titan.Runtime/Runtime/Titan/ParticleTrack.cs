namespace Titan
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(ParticleSystem))]
    [TrackClipType(typeof(ParticleClip))]
    [DisplayName("Titan/Particle")]
    public class ParticleTrack : TweenTrackBase<ParticleClip, ParticleSystem>
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static DOGetter<float> _003C_003E9__2_0;
            public _003C_003Ec()
            {
            }

            internal float _003CGetTween_003Eb__2_0()
            {
                return default(float);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public ParticleSystem component;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CInsertClipTween_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public Tween tween;
            public ParticleSystem component;
            public float prevParticleTime;
            public float prevTweenTime;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal void _003CGetTween_003Eb__1(float t)
            {
            }
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        protected override void InsertClipTween(TweenCreationContext context, ParticleSystem component, ParticleClip clipAsset, float clipStart, float clipDuration)
        {
        }

        protected override Tween GetTween(ParticleSystem component, ParticleClip clipAsset, float duration)
        {
            return null;
        }

        private static void Simulate(ParticleSystem particleSystem, float time, bool restart)
        {
        }

        public ParticleTrack()
        {
        }
    }
}
