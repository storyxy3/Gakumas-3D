namespace VL.Animation
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    [ExecuteAlways]
    [DefaultExecutionOrder(-1000)]
    public class MotionDefinePlayer : AnimationPlayerBase, IMotionDefinePlayer, IAnimationPlayer, IMotionDefinePlayerEvent
    {
        public RuntimeAnimatorController animatorController;
        private AnimationMixerPlayable _outputMixerPlayable;
        private AnimatorControllerPlayable _animatorControllerPlayable;
        private ScriptPlayable<MotionTimelinePlayable> _basePlayable;
        private ScriptPlayable<MotionTimelinePlayable> _overridePlayable;
        private bool _dirty;
        [CompilerGenerated]
        private ClipEvent m_onPlayEvent;
        [CompilerGenerated]
        private PrepareFrameEvent m_onPrepareFrameEvent;
        public event ClipEvent onPlayEvent
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public event PrepareFrameEvent onPrepareFrameEvent
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public override void Setup()
        {
        }

        public ILayerAnimationController CreateLayerController(LayerParam param)
        {
            return null;
        }

        public ILayerAnimationController CreateLayerController(OutputType outputType, LayerParam param)
        {
            return null;
        }

        public override IAnimationController GetPlayingBaseController()
        {
            return null;
        }

        public override IAnimationController GetPlayingLayerController(string layerName)
        {
            return null;
        }

        public ILayerAnimationController GetPlayingAnimationController()
        {
            return null;
        }

        public ILayerAnimationController GetPlayingAnimationController(string layerName)
        {
            return null;
        }

        public IEnumerable<ILayerAnimationController> GetPlayingAnimationControllers()
        {
            return null;
        }

        public void Evaluate()
        {
        }

        public void Evaluate(float deltaTime)
        {
        }

        public DirectorUpdateMode GetTimeUpdateMode()
        {
            return default(DirectorUpdateMode);
        }

        public void SetTimeUpdateMode(DirectorUpdateMode mode)
        {
        }

        public ILayerAnimationController Play(LayerParam param)
        {
            return null;
        }

        public ILayerAnimationController Play(OutputType outputType, LayerParam param)
        {
            return null;
        }

        public bool IsPlaying()
        {
            return default(bool);
        }

        public void Stop()
        {
        }

        public void SetAnimatorWeight(float weight)
        {
        }

        public float GetAnimatorWeight()
        {
            return default(float);
        }

        public void SetOverrideWeight(float weight, OutputType outputType = OutputType.Override)
        {
        }

        public float GetOverrideWeight(OutputType outputType = OutputType.Override)
        {
            return default(float);
        }

        public void SetSpeed(OutputType outputType, double speed)
        {
        }

        public double GetSpeed(OutputType outputType)
        {
            return default(double);
        }

        public bool IsValid()
        {
            return default(bool);
        }

        public void InvokePlayEvent(LayerParam layerParam, ClipParam clipParam, in FrameData info)
        {
        }

        public void InvokePrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info)
        {
        }

        public MotionDefinePlayer()
        {
        }

        void VL.Animation.IMotionDefinePlayerEvent.InvokePlayEvent(LayerParam layerParam, ClipParam clipParam, in FrameData info)
        {
        }

        void VL.Animation.IMotionDefinePlayerEvent.InvokePrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info)
        {
        }
    }
}
