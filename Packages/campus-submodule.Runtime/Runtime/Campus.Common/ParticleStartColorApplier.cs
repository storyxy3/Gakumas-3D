namespace Campus.Common
{
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;

    [RequireComponent(typeof(ParticleSystem))]
    public class ParticleStartColorApplier : QuaUIBehaviour
    {
        [SerializeField]
        private int _targetKey;
        [SerializeField]
        private ParticleColor[] _particleColors;
        private ParticleSystem _targetParticleSystem;
        public ParticleColor[] ParticleColors
        {
            get
            {
                return null;
            }
        }

        public void SetStartColor(string key)
        {
        }

        private int SetColor(string key)
        {
            return default(int);
        }

        public ParticleStartColorApplier()
        {
        }
    }
}
