namespace Campus.Crowd
{
    using global::Campus.Crowd;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    internal class CrowdAnimationBehaviour : PlayableBehaviour
    {
        public CrowdAnimationJob jobTemplate;
        private ClipData[] _clips;
        private ClipData[] _overrideClips;
        private AnimationScriptPlayable _animationPlayable;
        private AnimationMixerPlayable[] _animationMixerPlayables;
        private AnimationMixerPlayable[] _overrideMixerPlayables;
        private const int OverrideMixerNum = 4;
        public override void OnPlayableCreate(Playable playable)
        {
            _animationPlayable = AnimationScriptPlayable.Create(playable.GetGraph(), jobTemplate, 8);
            _animationPlayable.SetProcessInputs(false);
            _animationPlayable.SetPropagateSetTime(true);
            _animationMixerPlayables = new AnimationMixerPlayable[8];
            _overrideMixerPlayables = new AnimationMixerPlayable[4];
            for (int i = 0; i < _animationMixerPlayables.Length; i++)
            {
                _animationMixerPlayables[i] = AnimationMixerPlayable.Create(playable.GetGraph());
                _animationPlayable.ConnectInput(i, _animationMixerPlayables[i], 0, 1f);
            }
            for (int i = 0; i < _overrideMixerPlayables.Length; i++)
            {
                _overrideMixerPlayables[i] = AnimationMixerPlayable.Create(playable.GetGraph());
                _animationMixerPlayables[i + 4].SetInputCount(1);
                _animationMixerPlayables[i + 4].ConnectInput(0, _overrideMixerPlayables[i], 0, 1f);
            }
            playable.SetInputCount(1);
            playable.ConnectInput(0, _animationPlayable, 0, 1f);
            playable.SetPropagateSetTime(true);
        }

        public override void OnPlayableDestroy(Playable playable)
        {
            if (_animationPlayable.IsValid()) playable.GetGraph().DestroySubgraph(_animationPlayable);
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            _animationPlayable.Play();
            for (int i = 0; i < _animationMixerPlayables.Length; i++) _animationMixerPlayables[i].Play();
            for (int i = 0; i < _overrideMixerPlayables.Length; i++)
            {
                if (_overrideMixerPlayables[i].IsValid()) _overrideMixerPlayables[i].Play();
            }
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            _animationPlayable.Pause();
            for (int i = 0; i < _animationMixerPlayables.Length; i++) _animationMixerPlayables[i].Pause();
            for (int i = 0; i < _overrideMixerPlayables.Length; i++)
            {
                if (_overrideMixerPlayables[i].IsValid()) _overrideMixerPlayables[i].Pause();
            }
        }

        public void SetAnimationCount(int count)
        {
            for (int i = 0; i < _animationMixerPlayables.Length; i++) _animationMixerPlayables[i].SetInputCount(count + 1);
            if (_clips != null)
            {
                foreach (var clip in _clips) clip?.Dispose();
                _clips = null;
            }
            _clips = new ClipData[count];
        }

        public void ConnectAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
            if (motionDefine == null || index < 0 || _clips == null || index >= _clips.Length) return;
            _clips[index] = new ClipData(_animationMixerPlayables, index + 1, motionDefine, skipDuration, delay, seed, false);
        }

        public void SetAnimationWeight(int index, float weight)
        {
            for (int i = 0; i < _animationMixerPlayables.Length; i++)
            {
                if (_animationMixerPlayables[i].GetInputCount() > index && _animationMixerPlayables[i].GetInput(index + 1).IsValid())
                    _animationMixerPlayables[i].SetInputWeight(index + 1, weight);
            }
        }

        public void SetAnimationTime(int index, double time)
        {
            if (index >= 0 && _clips != null && index < _clips.Length) _clips[index]?.SetTime(time);
        }

        public void ConnectOverrideAnimation(int index, CrowdMotionDefine motionDefine, double skipDuration, float delay, int seed)
        {
            if (motionDefine == null || index < 0 || _overrideClips == null || index >= _overrideClips.Length) return;
            _overrideClips[index] = new ClipData(_overrideMixerPlayables, index, motionDefine, skipDuration, delay, seed, true);
        }

        public void SetOverrideAnimationCount(int count)
        {
            for (int i = 0; i < _overrideMixerPlayables.Length; i++) _overrideMixerPlayables[i].SetInputCount(count);
            if (_overrideClips != null)
            {
                foreach (var clip in _overrideClips) clip?.Dispose();
                _overrideClips = null;
            }
            _overrideClips = new ClipData[count];
        }

        public void SetOverrideAnimationWeight(int index, float inputWeight)
        {
            for (int i = 0; i < _overrideMixerPlayables.Length; i++)
            {
                if (_overrideMixerPlayables[i].GetInputCount() > index)
                {
                    _overrideMixerPlayables[i].SetInputWeight(index, inputWeight);
                    if (inputWeight > 0f)
                    {
                        for (int input = 1; input < _animationMixerPlayables[i + 4].GetInputCount(); input++)
                            _animationMixerPlayables[i + 4].SetInputWeight(input, 0f);
                    }
                }
            }
        }

        public void SetOverrideAnimationTime(int index, double time)
        {
            if (index >= 0 && _overrideClips != null && index < _overrideClips.Length) _overrideClips[index]?.SetTime(time);
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public CrowdAnimationBehaviour()
        {
        }
    }
}
