namespace VL.Animation
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public class MotionLayerPlayable : PlayableBehaviour
    {
        public IMotionDefinePlayerEvent playerEvent;
        public LayerParam layerParam;
        private AnimationMixerPlayable _mixerPlayable;
        private ScriptPlayable<MotionClipPlayable>[] _playables;
        private bool _isCompleted;
        private float[] _clipCompleteTime;
        [CompilerGenerated]
        private ClipParam _003CfirstClipParam_003Ek__BackingField;
        public ClipParam firstClipParam
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool isCompleted
        {
            get
            {
                return default(bool);
            }
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

        private void CheckExternalControl()
        {
        }

        public int GetPlayableCount()
        {
            return default(int);
        }

        public PlayState GetPlayablePlayState(int index)
        {
            return default(PlayState);
        }

        public void PlayPlayable(int index)
        {
        }

        public void PausePlayable(int index)
        {
        }

        public void SetPlayableTime(int index, double time)
        {
        }

        public void SetPlayableWeight(int index, float weight)
        {
        }

        public MotionLayerPlayable()
        {
        }
    }
}
