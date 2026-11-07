namespace Campus.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusParticlePlayableBehaviour : PlayableBehaviour
    {
        private const float kUnsetTime = 3.4028235E+38f;
        private float m_LastPlayableTime;
        private float m_LastParticleTime;
        private uint m_RandomSeed;
        [CompilerGenerated]
        private ParticleSystem _003CparticleSystem_003Ek__BackingField;
        public ParticleSystem particleSystem
        {
            [CompilerGenerated]
            get
            {
                return _003CparticleSystem_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CparticleSystem_003Ek__BackingField = value;
            }
        }

        public static ScriptPlayable<CampusParticlePlayableBehaviour> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed)
        {
            return default(ScriptPlayable<CampusParticlePlayableBehaviour>);
        }

        public void Initialize(ParticleSystem ps, uint randomSeed)
        {
        }

        private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData data)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        private void Simulate(float time, bool restart)
        {
        }

        public CampusParticlePlayableBehaviour()
        {
        }
    }
}
