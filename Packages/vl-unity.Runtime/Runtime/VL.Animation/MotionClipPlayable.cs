namespace VL.Animation
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;

    public class MotionClipPlayable : PlayableBehaviour
    {
        public IMotionDefinePlayerEvent playerEvent;
        public LayerParam layerParam;
        public ClipParam clipParam;
        private ScriptPlayable<MotionDefinePlayable> _motionDefinePlayable;
        private Animator GetAnimator(Playable playable)
        {
            return null;
        }

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

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public void SetTime(double time)
        {
        }

        public MotionClipPlayable()
        {
        }
    }
}
