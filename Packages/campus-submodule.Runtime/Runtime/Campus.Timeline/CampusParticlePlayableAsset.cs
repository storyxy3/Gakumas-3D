namespace Campus.Timeline
{
    using global::System.Collections.Generic;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    public class CampusParticlePlayableAsset : PlayableAsset, IPropertyPreview
    {
        public ExposedReference<ParticleSystem> particleSystemReference;
        public uint randomSeed;
        private ParticleSystem _particleSystem;
        private CampusParticlePlayableBehaviour _behaviour;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles)
        {
        }

        public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusParticlePlayableAsset()
        {
        }
    }
}
