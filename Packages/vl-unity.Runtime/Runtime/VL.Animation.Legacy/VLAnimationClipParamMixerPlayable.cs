namespace VL.Animation.Legacy
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation.Legacy;

    public class VLAnimationClipParamMixerPlayable : PlayableBehaviour
    {
        public delegate void PrepareFrameEvent(VLAnimationClipParam currentParam, VLAnimationClipParamMixerPlayable playable, float currentTime, FrameData info);
        public delegate void PlayEvent(VLAnimationClipParam currentParam, VLAnimationClipParam prevParam, VLAnimationClipParamMixerPlayable playable);
        public struct LayerPlayables
        {
            public AnimationMixerPlayable mixer;
            public AnimationClipPlayable currentPlayable;
            public AnimationClipPlayable prevPlayable;
            public void ConnectToLayerMixer(int index, Playable layerMixerPlayable)
            {
            }

            public void ConnectClip(AnimationClip currentClip, AnimationClip prevClip, Playable playable, bool applyFootIK, float currentOffset = 0f, float prevOffset = 0f)
            {
            }

            public void Destroy()
            {
            }

            public void SetTime(float currentTime, float prevTime)
            {
            }

            public void SetInputWeight(float weight)
            {
            }
        }

        public const int LAYER_MAX = 4;
        public float delay;
        public bool applyFootIK;
        private AnimationLayerMixerPlayable _layerPlayable;
        private LayerPlayables[] _playables;
        private int _mixerCount;
        private List<float> _passTimes;
        private int _stepCount;
        [SerializeField]
        private VLAnimationClipPlayerParam _param;
        private VLAnimationClipPlayerParam.LayerParam _layerParam;
        private VLAnimationClipParam _prevClipParam;
        private int _currentParamIndex;
        private float _currentParamTime;
        private bool _isUpdatedParam;
        [CompilerGenerated]
        private PrepareFrameEvent m_onPrepareFrameEvent;
        [CompilerGenerated]
        private PlayEvent m_onPlayEvent;
        public int stepCount
        {
            get
            {
                return default(int);
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

        public event PlayEvent onPlayEvent
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

        public VLAnimationClipPlayerParam GetParam()
        {
            return null;
        }

        private void Initialize(Playable owner, PlayableGraph graph)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        private void ConnectAnimationClip(int index, Playable playable, float currentOffset = 0f, float prevOffset = 0f)
        {
        }

        private static AnimationClip GetAnimationClip(VLAnimationClipParam clipParam, int index)
        {
            return null;
        }

        private void GetCurrentIndexTime(float time, out int currentIndex, out int prevIndex, out float currentTime, out float prevTime)
        {
            throw null;
        }

        public void ResetParam()
        {
        }

        public void SetAnimationClipPlayerParam(VLAnimationClipPlayerParam param, [Optional] VLAnimationClipPlayerParam.LayerParam layer)
        {
        }

        public float GetNextAnimationTime()
        {
            return default(float);
        }

        public void SetAnimationWeight(float weight)
        {
        }

        public void SetAnimationWeight(float weight, float time, MotionDefine motion)
        {
        }

        private void UpdatePassTimes()
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

        public static ScriptPlayable<VLAnimationClipParamMixerPlayable> Create(PlayableGraph graph)
        {
            return default(ScriptPlayable<VLAnimationClipParamMixerPlayable>);
        }

        public VLAnimationClipParamMixerPlayable()
        {
        }
    }
}
