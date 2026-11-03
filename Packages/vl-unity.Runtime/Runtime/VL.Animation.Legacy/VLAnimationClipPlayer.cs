namespace VL.Animation.Legacy
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Animation.Legacy;
    using global::VL.Timeline.Legacy;

    [ExecuteAlways]
    [DefaultExecutionOrder(-1000)]
    public class VLAnimationClipPlayer : AnimationPlayerBase, IVLAnimationClipPlayer, IAnimationPlayer
    {
        [CompilerGenerated]
        private sealed class _003CPlayCoroutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public VLAnimationClipPlayer _003C_003E4__this;
            public VLAnimationPlayerController controller;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CPlayCoroutine_003Ed__40(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        public const int LAYER_MAX = 8;
        public RuntimeAnimatorController animatorController;
        [SerializeField]
        private float _delay;
        private ScriptPlayable<VLAnimationClipParamMixerPlayable> _animationClipParamMixer;
        private AnimationMixerPlayable _baseAnimationMixer;
        private AnimatorControllerPlayable _animatorControllerPlayable;
        private VLAnimationPlayerController _controller;
        private AnimationLayerMixerPlayable _layerMixer;
        private ScriptPlayable<VLAnimationClipParamMixerPlayable>[] _layerAnimationPlayables;
        private Dictionary<string, VLAnimationPlayerController> _layerAnimationTable;
        private int _layerAdditiveStartIndex;
        private int _layerAdditiveCount;
        [CompilerGenerated]
        private VLAnimationClipParamMixerPlayable.PrepareFrameEvent m_onLayerPrepareFrameEvent;
        [CompilerGenerated]
        private VLAnimationClipParamMixerPlayable.PlayEvent m_onLayerPlayEvent;
        private ScriptPlayable<VLAnimationClipPlayerTimelineMixerPlayable> _timelinePlayable;
        private Dictionary<string, VLAnimationPlayerController> layerAnimationTable
        {
            get
            {
                return null;
            }
        }

        public event VLAnimationClipParamMixerPlayable.PrepareFrameEvent onPrepareFrameEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event VLAnimationClipParamMixerPlayable.PlayEvent onPlayEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent
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

        public event VLAnimationClipParamMixerPlayable.PlayEvent onLayerPlayEvent
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

        private void OnLayerPrepareFrameEvent(VLAnimationClipParam currentParam, VLAnimationClipParamMixerPlayable playable, float currentTime, FrameData info)
        {
        }

        private void OnLayerPlayEvent(VLAnimationClipParam currentParam, VLAnimationClipParam prevParam, VLAnimationClipParamMixerPlayable playable)
        {
        }

        public override void Setup()
        {
        }

        public IVLAnimationPlayerController GetAnimationController(VLAnimationClipPlayerParam param)
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

        public void SetDelay(float time)
        {
        }

        private void UpdateDelay()
        {
        }

        private void SetBaseDelay(float time)
        {
        }

        public bool GetApplyFootIK()
        {
            return default(bool);
        }

        public void SetApplyFootIK(bool applyFootIK)
        {
        }

        private ScriptPlayable<VLAnimationClipParamMixerPlayable> GetPlayable(VLAnimationPlayerController controller)
        {
            return default(ScriptPlayable<VLAnimationClipParamMixerPlayable>);
        }

        internal void Evaluate(float deltaTime = 0f)
        {
        }

        internal YieldInstruction Play(VLAnimationPlayerController controller)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CPlayCoroutine_003Ed__40))]
        internal IEnumerator PlayCoroutine(VLAnimationPlayerController controller)
        {
            return null;
        }

        internal void Stop(VLAnimationPlayerController controller)
        {
        }

        internal void SkipCurrentAnimation(VLAnimationPlayerController controller)
        {
        }

        internal bool IsPlaying(VLAnimationPlayerController controller)
        {
            return default(bool);
        }

        private bool IsPlaying(ScriptPlayable<VLAnimationClipParamMixerPlayable> playable)
        {
            return default(bool);
        }

        internal bool IsPauseMixer()
        {
            return default(bool);
        }

        internal bool IsPause(VLAnimationPlayerController controller)
        {
            return default(bool);
        }

        private bool IsPause(ScriptPlayable<VLAnimationClipParamMixerPlayable> playable)
        {
            return default(bool);
        }

        internal void PauseMixer()
        {
        }

        internal void Pause(VLAnimationPlayerController controller)
        {
        }

        internal void ResumeMixer()
        {
        }

        internal void Resume(VLAnimationPlayerController controller)
        {
        }

        internal void SetWeight(float weight, VLAnimationPlayerController controller)
        {
        }

        internal float GetWeight(VLAnimationPlayerController controller)
        {
            return default(float);
        }

        internal void SetTime(double time, VLAnimationPlayerController controller)
        {
        }

        internal float GetTime(VLAnimationPlayerController controller)
        {
            return default(float);
        }

        internal float GetSpeed(VLAnimationPlayerController controller)
        {
            return default(float);
        }

        internal void SetSpeed(double speed, VLAnimationPlayerController controller)
        {
        }

        internal int GetCompletedLoops(VLAnimationPlayerController controller)
        {
            return default(int);
        }

        private ScriptPlayable<VLAnimationClipParamMixerPlayable> GetLayerPlayable(VLAnimationPlayerController controller)
        {
            return default(ScriptPlayable<VLAnimationClipParamMixerPlayable>);
        }

        private void MoveLayerMixerInput(int fromIndex, int toIndex)
        {
        }

        private bool TryGetLayerPlayable(VLAnimationPlayerController controller, out ScriptPlayable<VLAnimationClipParamMixerPlayable> playable)
        {
            throw null;
        }

        private int GetMixerIndexFromLayerIndex(int layerIndex)
        {
            return default(int);
        }

        public bool IsUsedLayer(string layerName)
        {
            return default(bool);
        }

        public bool IsPlayingLayer(string layerName)
        {
            return default(bool);
        }

        public IEnumerable<string> GetPlayingLayerList()
        {
            return null;
        }

        public bool IsPauseLayer(string layerName)
        {
            return default(bool);
        }

        public double GetLayerTime(string layerName)
        {
            return default(double);
        }

        public float GetLayerWeight(string layerName)
        {
            return default(float);
        }

        public double GetLayerSpeed(string layerName)
        {
            return default(double);
        }

        internal void RegisterPlayEvent(VLAnimationPlayerController controller, VLAnimationClipParamMixerPlayable.PlayEvent onLayerPlayEvent)
        {
        }

        internal void UnregisterPlayEvent(VLAnimationPlayerController controller, VLAnimationClipParamMixerPlayable.PlayEvent onLayerPlayEvent)
        {
        }

        internal void RegisterPrepareFrameEvent(VLAnimationPlayerController controller, VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent)
        {
        }

        internal void UnregisterPrepareFrameEvent(VLAnimationPlayerController controller, VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent)
        {
        }

        public Playable GetTimelinePlayable()
        {
            return default(Playable);
        }

        public ScriptPlayable<VLAnimationClipPlayerTimelineMixerPlayable> CreateTimelineMixer(Playable trackPlayable)
        {
            return default(ScriptPlayable<VLAnimationClipPlayerTimelineMixerPlayable>);
        }

        public Playable CreateTimelineClip(Playable clipPlayable, MotionDefine motion, bool applyFootIK)
        {
            return default(Playable);
        }

        public void DestroyTimelineMixer()
        {
        }

        public float GetTimelineWeight()
        {
            return default(float);
        }

        public void SetTimelineWeight(float weight)
        {
        }

        private void SetTimelineDelay(float time)
        {
        }

        public VLAnimationClipPlayer()
        {
        }
    }
}
