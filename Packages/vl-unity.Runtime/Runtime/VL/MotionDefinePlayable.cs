namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;

    public class MotionDefinePlayable : PlayableBehaviour
    {
        public Animator animator;
        public MotionDefine motionDefine;
        public bool isAdditive;
        public IReadOnlyList<AnimationData> defaultAnimations;
        public bool isTimeline;
        private AnimationLayerMixerPlayable _layerMixerPlayable;
        private ScriptPlayable<MotionEffectPlayable> _motionEffectPlayable;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public MotionDefinePlayable()
        {
        }
    }
}
