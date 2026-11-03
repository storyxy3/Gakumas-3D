namespace VL.Animation
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;
    using global::VL.Animation;

    public class MotionPrefabEffectPlayable : PlayableBehaviour
    {
        public GameObject prefabAsset;
        public uint particleRandomSeed;
        public Transform parentTransform;
        public Vector3 offsetPosition;
        public Vector3 offsetRotation;
        public bool isTimeline;
        private ScriptPlayable<VL.Animation.PrefabControlPlayable> _prefabControlPlayable;
        private ScriptPlayable<ParticleControlPlayable>[] _particleControlPlayables;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        private void GetParticleSystems(Transform t, ICollection<ParticleSystem> particles, HashSet<ParticleSystem> subEmitters)
        {
        }

        public MotionPrefabEffectPlayable()
        {
        }
    }
}
