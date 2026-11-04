namespace VL.Animation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
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
                ClipEvent previous = m_onPlayEvent;
                ClipEvent current;
                do
                {
                    current = previous;
                    var updated = (ClipEvent)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onPlayEvent, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                ClipEvent previous = m_onPlayEvent;
                ClipEvent current;
                do
                {
                    current = previous;
                    var updated = (ClipEvent)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onPlayEvent, updated, current);
                }
                while ((object)previous != current);
            }
        }

        public event PrepareFrameEvent onPrepareFrameEvent
        {
            [CompilerGenerated]
            add
            {
                PrepareFrameEvent previous = m_onPrepareFrameEvent;
                PrepareFrameEvent current;
                do
                {
                    current = previous;
                    var updated = (PrepareFrameEvent)Delegate.Combine(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onPrepareFrameEvent, updated, current);
                }
                while ((object)previous != current);
            }

            [CompilerGenerated]
            remove
            {
                PrepareFrameEvent previous = m_onPrepareFrameEvent;
                PrepareFrameEvent current;
                do
                {
                    current = previous;
                    var updated = (PrepareFrameEvent)Delegate.Remove(current, value);
                    previous = System.Threading.Interlocked.CompareExchange(ref m_onPrepareFrameEvent, updated, current);
                }
                while ((object)previous != current);
            }
        }

        public override void Setup()
        {
            if (!_dirty && initialized)
                return;
            _dirty = false;
            PlayableGraph graph = CreatePlayableGraph();
            AnimationPlayableOutput output = AnimationPlayableOutput.Create(graph, "Animation", animator);
            _outputMixerPlayable = AnimationMixerPlayable.Create(graph, 3);
            if (animatorController != null)
            {
                _animatorControllerPlayable = AnimatorControllerPlayable.Create(graph, animatorController);
                _outputMixerPlayable.ConnectInput(2, _animatorControllerPlayable, 0, 0f);
            }
            _basePlayable = ScriptPlayable<MotionTimelinePlayable>.Create(graph, new MotionTimelinePlayable { playerEvent = this });
            _outputMixerPlayable.ConnectInput(0, _basePlayable, 0, 1f);
            _overridePlayable = ScriptPlayable<MotionTimelinePlayable>.Create(graph, new MotionTimelinePlayable());
            _outputMixerPlayable.ConnectInput(1, _overridePlayable, 0, 0f);
            output.SetSourcePlayable(_outputMixerPlayable);
            graph.Play();
            graph.SetTimeUpdateMode(DirectorUpdateMode.GameTime);
        }

        public ILayerAnimationController CreateLayerController(LayerParam param)
        {
            return CreateLayerController(OutputType.Base, param);
        }

        public ILayerAnimationController CreateLayerController(OutputType outputType, LayerParam param)
        {
            if ((uint)outputType >= 2)
                throw new ArgumentOutOfRangeException(nameof(outputType), outputType, null);
            Setup();
            return new LayerController(outputType == OutputType.Base ? _basePlayable : _overridePlayable, param);
        }

        public override IAnimationController GetPlayingBaseController()
        {
            return GetPlayingAnimationController();
        }

        public override IAnimationController GetPlayingLayerController(string layerName)
        {
            return GetPlayingAnimationController(layerName);
        }

        public ILayerAnimationController GetPlayingAnimationController()
        {
            return _basePlayable.IsValid() ? _basePlayable.GetBehaviour().GetPlayingBaseController() : null;
        }

        public ILayerAnimationController GetPlayingAnimationController(string layerName)
        {
            return _basePlayable.IsValid() ? _basePlayable.GetBehaviour().GetPlayingLayerController(layerName) : null;
        }

        public IEnumerable<ILayerAnimationController> GetPlayingAnimationControllers()
        {
            return _basePlayable.IsValid() ? _basePlayable.GetBehaviour().GetPlayingLayerControllers() : Enumerable.Empty<ILayerAnimationController>();
        }

        public void Evaluate()
        {
            Evaluate(0f);
        }

        public void Evaluate(float deltaTime)
        {
            if (initialized)
                GetPlayableGraph().Evaluate(deltaTime);
        }

        public DirectorUpdateMode GetTimeUpdateMode()
        {
            return initialized ? GetPlayableGraph().GetTimeUpdateMode() : DirectorUpdateMode.GameTime;
        }

        public void SetTimeUpdateMode(DirectorUpdateMode mode)
        {
            if (initialized)
                GetPlayableGraph().SetTimeUpdateMode(mode);
        }

        public ILayerAnimationController Play(LayerParam param)
        {
            return Play(OutputType.Base, param);
        }

        public ILayerAnimationController Play(OutputType outputType, LayerParam param)
        {
            ILayerAnimationController controller = CreateLayerController(outputType, param);
            controller?.Play();
            return controller;
        }

        public bool IsPlaying()
        {
            PlayableGraph graph = GetPlayableGraph();
            return graph.IsValid() && graph.IsPlaying();
        }

        public void Stop()
        {
            PlayableGraph graph = GetPlayableGraph();
            if (graph.IsValid())
                graph.Stop();
        }

        public void SetAnimatorWeight(float weight)
        {
            if (_animatorControllerPlayable.IsValid())
                _outputMixerPlayable.SetInputWeight(2, weight);
        }

        public float GetAnimatorWeight()
        {
            return _animatorControllerPlayable.IsValid() ? _outputMixerPlayable.GetInputWeight(2) : 0f;
        }

        public void SetOverrideWeight(float weight, OutputType outputType = OutputType.Override)
        {
            if (_overridePlayable.IsValid())
                _outputMixerPlayable.SetInputWeight((int)outputType, weight);
        }

        public float GetOverrideWeight(OutputType outputType = OutputType.Override)
        {
            return _overridePlayable.IsValid() ? _outputMixerPlayable.GetInputWeight((int)outputType) : 0f;
        }

        public void SetSpeed(OutputType outputType, double speed)
        {
            switch (outputType)
            {
                case OutputType.Base:
                    if (_basePlayable.IsValid())
                        _basePlayable.SetSpeed(speed);
                    break;
                case OutputType.Override:
                    if (_outputMixerPlayable.IsValid())
                        _overridePlayable.SetSpeed(speed);
                    break;
                case OutputType.Animator:
                    if (_animatorControllerPlayable.IsValid())
                        _animatorControllerPlayable.SetSpeed(speed);
                    break;
            }
        }

        public double GetSpeed(OutputType outputType)
        {
            switch (outputType)
            {
                case OutputType.Base:
                    if (_basePlayable.IsValid())
                        return _basePlayable.GetSpeed();
                    break;
                case OutputType.Override:
                    if (_outputMixerPlayable.IsValid())
                        return _overridePlayable.GetSpeed();
                    break;
                case OutputType.Animator:
                    if (_animatorControllerPlayable.IsValid())
                        return _animatorControllerPlayable.GetSpeed();
                    break;
            }
            return 1;
        }

        public bool IsValid()
        {
            return GetPlayableGraph().IsValid();
        }

        public void InvokePlayEvent(LayerParam layerParam, ClipParam clipParam, in FrameData info)
        {
            m_onPlayEvent?.Invoke(layerParam, clipParam, in info);
        }

        public void InvokePrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info)
        {
            m_onPrepareFrameEvent?.Invoke(layerParam, clipParam, currentTime, in info);
        }

        public MotionDefinePlayer()
        {
        }

        void VL.Animation.IMotionDefinePlayerEvent.InvokePlayEvent(LayerParam layerParam, ClipParam clipParam, in FrameData info)
        {
            InvokePlayEvent(layerParam, clipParam, in info);
        }

        void VL.Animation.IMotionDefinePlayerEvent.InvokePrepareFrameEvent(LayerParam layerParam, ClipParam clipParam, double currentTime, in FrameData info)
        {
            InvokePrepareFrameEvent(layerParam, clipParam, currentTime, in info);
        }
    }
}
