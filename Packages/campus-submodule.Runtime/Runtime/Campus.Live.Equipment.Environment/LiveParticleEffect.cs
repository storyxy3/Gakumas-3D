namespace Campus.Live.Equipment.Environment
{
    using global::Campus.Live.Equipment;
    using global::UnityEngine;

    [AddComponentMenu("Equipment/Particle Effect")]
    public class LiveParticleEffect : EnvironmentBase
    {
        private static readonly int _Color;
        [SerializeField]
        private ParticleSystem _particle;
        [SerializeField]
        private ParticleSystemRenderer[] _renderers;
        private const float kUnsetTime = -1f;
        private float m_LastTime;
        private float m_SystemTime;
        protected override void OnApply(ref LiveEquipmentStreamData data)
        {
        }

        private void SimulateParticle(ParticleSystem particleSystem, float localTime)
        {
        }

        public LiveParticleEffect()
        {
        }
    }
}
