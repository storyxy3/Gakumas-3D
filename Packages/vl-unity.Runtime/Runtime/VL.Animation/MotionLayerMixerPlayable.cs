namespace VL.Animation
{
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public class MotionLayerMixerPlayable : PlayableBehaviour
    {
        public IMotionDefinePlayerEvent playerEvent;
        public string layerName;
        private AnimationMixerPlayable _mixerPlayable;
        private ScriptPlayable<MotionLayerPlayable>[] _playables;
        private int _currentIndex;
        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public bool Disconnected()
        {
            return default(bool);
        }

        public ScriptPlayable<MotionLayerPlayable> SetupLayer(LayerParam param)
        {
            return default(ScriptPlayable<MotionLayerPlayable>);
        }

        private void UpdateMixerPlayable()
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public MotionLayerMixerPlayable()
        {
        }
    }
}
