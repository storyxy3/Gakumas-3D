namespace VL.Animation
{
    using global::System;
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
                return _003CfirstClipParam_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CfirstClipParam_003Ek__BackingField = value;
            }
        }

        public bool isCompleted
        {
            get
            {
                return _isCompleted;
            }
        }

        public override void OnPlayableCreate(Playable playable)
        {
            _mixerPlayable = AnimationMixerPlayable.Create(playable.GetGraph(), layerParam.clipCount);
            playable.AddInput(_mixerPlayable, 0, 1f);
            _playables = new ScriptPlayable<MotionClipPlayable>[layerParam.clipCount];
            for (int i = 0; i < layerParam.clipCount; ++i)
            {
                ClipParam clip = layerParam.GetClipParam(i);
                var input = ScriptPlayable<MotionClipPlayable>.Create(playable.GetGraph(), new MotionClipPlayable
                {
                    playerEvent = playerEvent,
                    layerParam = layerParam,
                    clipParam = clip
                });
                _mixerPlayable.ConnectInput(i, input, 0, 0f);
                _playables[i] = input;
                if (i == 0)
                    firstClipParam = clip;
            }
            _isCompleted = false;
        }

        public override void OnPlayableDestroy(Playable playable)
        {
            playable.DisconnectInput(0);
            _mixerPlayable.Destroy();
            for (int i = 0; i < _playables.Length; ++i)
                _playables[i].Destroy();
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            _mixerPlayable.Play();
            layerParam?.onPlay?.Invoke(layerParam, null, in info);
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            _mixerPlayable.Pause();
            if (layerParam.externalControl)
                return;
            for (int i = 0; i < _playables.Length; ++i)
                _playables[i].Pause();
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
            if (layerParam == null || layerParam.externalControl)
                return;
            double time = playable.GetTime();
            layerParam.onPrepareFrame?.Invoke(layerParam, null, time, in info);
            if (time >= layerParam.length)
            {
                if (layerParam.isLoop)
                {
                    time -= layerParam.length;
                    playable.SetTime(time);
                }
                else
                {
                    _isCompleted = true;
                    layerParam.onComplete?.Invoke(layerParam, null, in info);
                }
            }
            _mixerPlayable.SetTime(time);
            double startTime = 0;
            for (int i = 0; i < _playables.Length; ++i)
            {
                ClipParam clip = layerParam.GetClipParam(i);
                ClipParam nextClip = i + 1 < _playables.Length ? layerParam.GetClipParam(i + 1) : null;
                double nextTransition = nextClip?.transitionTime ?? 0;
                double clipTime = time - startTime;
                if ((clipTime >= 0 && clipTime < clip.length) || time >= layerParam.length)
                {
                    if (_playables[i].GetPlayState() == PlayState.Paused)
                        _playables[i].Play();
                    _playables[i].SetTime(clipTime);
                    float weight;
                    if (clipTime > clip.length - nextTransition)
                        weight = 1f - (nextClip?.EvaluateWeight((float)(nextTransition + clipTime - clip.length)) ?? 0f);
                    else if (i > 0 && clipTime < clip.transitionTime)
                        weight = clip.EvaluateWeight((float)clipTime);
                    else
                        weight = 1f;
                    _mixerPlayable.SetInputWeight(i, weight);
                }
                else
                {
                    if (_playables[i].GetPlayState() == PlayState.Playing)
                        _playables[i].Pause();
                    _mixerPlayable.SetInputWeight(i, 0f);
                }
                startTime += clip.length - nextTransition;
            }
        }

        private void CheckExternalControl()
        {
            if (layerParam == null)
                throw new NullReferenceException("layerParam");
            if (!layerParam.externalControl)
                throw new InvalidOperationException("externalControlがオフになっていますLayerParam.SwitchToExternalControlを呼び出してから使用してください");
        }

        public int GetPlayableCount()
        {
            return _playables?.Length ?? 0;
        }

        public PlayState GetPlayablePlayState(int index)
        {
            return _playables != null && _playables[index].IsValid() ? _playables[index].GetPlayState() : PlayState.Paused;
        }

        public void PlayPlayable(int index)
        {
            CheckExternalControl();
            if (_playables != null && _playables[index].IsValid())
                _playables[index].Play();
        }

        public void PausePlayable(int index)
        {
            CheckExternalControl();
            if (_playables != null && _playables[index].IsValid())
                _playables[index].Pause();
        }

        public void SetPlayableTime(int index, double time)
        {
            CheckExternalControl();
            if (_playables != null && _playables[index].IsValid())
            {
                _playables[index].SetTime(time);
                _playables[index].GetBehaviour()?.SetTime(time);
            }
        }

        public void SetPlayableWeight(int index, float weight)
        {
            CheckExternalControl();
            _mixerPlayable.SetInputWeight(index, weight);
        }

        public MotionLayerPlayable()
        {
        }
    }
}
