namespace VL.Animation
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Animations;
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
            PlayableGraph graph = playable.GetGraph();
            for (int i = 0; i < graph.GetOutputCountByType<AnimationPlayableOutput>(); ++i)
            {
                AnimationPlayableOutput output = (AnimationPlayableOutput)graph.GetOutputByType<AnimationPlayableOutput>(i);
                if (output.IsOutputValid())
                    return output.GetTarget();
            }
            return null;
        }

        public override void OnPlayableCreate(Playable playable)
        {
            if (clipParam.motionDefine == null)
                return;
            Animator animator = GetAnimator(playable);
            if (animator == null)
            {
                Debug.LogError("MotionDefinePlayable: Animatorが指定されていません");
                return;
            }
            playable.SetInputCount(1);
            _motionDefinePlayable = ScriptPlayable<MotionDefinePlayable>.Create(playable.GetGraph(), new MotionDefinePlayable
            {
                animator = animator,
                motionDefine = clipParam.motionDefine,
                isAdditive = layerParam.isAdditive,
                defaultAnimations = layerParam.defaultAnimations,
                isTimeline = layerParam.externalControl
            });
            playable.ConnectInput(0, _motionDefinePlayable, 0, 1f);
            if (!clipParam.isLoop)
                playable.SetDuration(clipParam.length);
        }

        public override void OnPlayableDestroy(Playable playable)
        {
            if (_motionDefinePlayable.IsValid())
                playable.GetGraph().DestroySubgraph(_motionDefinePlayable);
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            _motionDefinePlayable.Play();
            playerEvent?.InvokePlayEvent(layerParam, clipParam, in info);
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            _motionDefinePlayable.Pause();
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            double time = playable.GetTime();
            playerEvent?.InvokePrepareFrameEvent(layerParam, clipParam, time, in info);
            SetTime(time);
        }

        public void SetTime(double time)
        {
            if (_motionDefinePlayable.IsValid())
                _motionDefinePlayable.SetTime(time);
        }

        public MotionClipPlayable()
        {
        }
    }
}
