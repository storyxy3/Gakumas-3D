namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public class ParticleClip : LoopableTweenClip
    {
        [SerializeField]
        private ParticlePlayType _playType;
        public ParticlePlayType PlayType
        {
            get
            {
                return default(ParticlePlayType);
            }
        }

        public ParticleClip()
        {
        }
    }
}
