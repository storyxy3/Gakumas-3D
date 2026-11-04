namespace VL.Animation
{
    using global::UnityEngine;
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
            _mixerPlayable = AnimationMixerPlayable.Create(playable.GetGraph(), 2);
            _playables = new ScriptPlayable<MotionLayerPlayable>[2];
            playable.AddInput(_mixerPlayable, 0, 1f);
        }

        public override void OnPlayableDestroy(Playable playable)
        {
            _mixerPlayable.Destroy();
        }

        public bool Disconnected()
        {
            return !_playables[0].IsValid() && !_playables[1].IsValid();
        }

        public ScriptPlayable<MotionLayerPlayable> SetupLayer(LayerParam param)
        {
            int nextIndex = (_currentIndex + 1) % 2;
            if (_playables[nextIndex].IsValid())
            {
                _mixerPlayable.DisconnectInput(nextIndex);
                _playables[nextIndex].Destroy();
            }
            var playable = ScriptPlayable<MotionLayerPlayable>.Create(_mixerPlayable.GetGraph(), new MotionLayerPlayable
            {
                playerEvent = playerEvent,
                layerParam = param
            });
            _playables[nextIndex] = playable;
            _mixerPlayable.ConnectInput(nextIndex, playable, 0, 0f);
            if (_playables[_currentIndex].IsValid())
                _mixerPlayable.SetInputWeight(_currentIndex, 1f);
            _currentIndex = nextIndex;
            return playable;
        }

        private void UpdateMixerPlayable()
        {
            int otherIndex = (_currentIndex + 1) % 2;
            var current = _playables[_currentIndex];
            var other = _playables[otherIndex];
            if (!current.IsValid())
                return;
            ClipParam firstClip = current.GetBehaviour().firstClipParam;
            if (firstClip == null)
                return;
            double time = current.GetTime();
            float weight = other.IsValid() && time < firstClip.transitionTime ? firstClip.EvaluateWeight((float)time) : 1f;
            _mixerPlayable.SetInputWeight(_currentIndex, weight);
            if (other.IsValid())
            {
                _mixerPlayable.SetInputWeight(otherIndex, 1f - weight);
                if (Mathf.Approximately(weight, 1f))
                {
                    _mixerPlayable.DisconnectInput(otherIndex);
                    _playables[otherIndex].Destroy();
                }
            }
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            UpdateMixerPlayable();
        }

        public MotionLayerMixerPlayable()
        {
        }
    }
}
