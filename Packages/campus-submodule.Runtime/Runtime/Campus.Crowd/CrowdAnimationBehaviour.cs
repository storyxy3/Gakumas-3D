namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    internal class CrowdAnimationBehaviour : PlayableBehaviour
    {
        public CrowdAnimationJob jobTemplate;
        private ClipData[] _clips;
        private ClipData[] _overrideClips;
        private AnimationScriptPlayable _animationPlayable;
        private AnimationMixerPlayable[] _animationMixerPlayables;
        private AnimationMixerPlayable[] _overrideMixerPlayables;
        private const int OverrideMixerNum = 4;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public void SetAnimationCount(int count)
        {
        }

        public void ConnectAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
        }

        public void SetAnimationWeight(int index, float weight)
        {
        }

        public void SetAnimationTime(int index, double time)
        {
        }

        public void ConnectOverrideAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
        }

        public void SetOverrideAnimationCount(int count)
        {
        }

        public void SetOverrideAnimationWeight(int index, float inputWeight)
        {
        }

        public void SetOverrideAnimationTime(int index, double time)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public CrowdAnimationBehaviour()
        {
        }
    }
}
