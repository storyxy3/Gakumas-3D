namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(ParticleSystem))]
    [TrackClipType(typeof(ParticleClip))]
    [DisplayName("Titan/Particle")]
    public class ParticleTrack : TweenTrackBase<ParticleClip, ParticleSystem>
    {
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
