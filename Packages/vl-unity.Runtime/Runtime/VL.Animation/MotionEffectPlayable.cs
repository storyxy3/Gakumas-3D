namespace VL.Animation
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public class MotionEffectPlayable : PlayableBehaviour
    {
        public GameObject root;
        public EffectData[] effects;
        public double defaultAnimationLength;
        public bool isLoopMotionEffect;
        public bool isTimeline;
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

        public MotionEffectPlayable()
        {
        }
    }
}
