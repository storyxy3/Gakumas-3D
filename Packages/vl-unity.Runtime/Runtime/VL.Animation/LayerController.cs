namespace VL.Animation
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public class LayerController : ILayerAnimationController, IAnimationController, IDisposable
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitForCompletionAsync_003Ed__12 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public LayerController _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            public void MoveNext()
            {
                int state = _003C_003E1__state;
                try
                {
                    UniTask.Awaiter awaiter;
                    if (state != 0)
                    {
                        awaiter = UniTask.WaitWhile(_003C_003E4__this.IsPlaying, PlayerLoopTiming.Update, ct).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    }
                    awaiter.GetResult();
                }
                catch (Exception exception)
                {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                    return;
                }
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetResult();
            }

            [DebuggerHidden]
            public void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
        }

        private ScriptPlayable<MotionTimelinePlayable> _timelinePlayable;
        private ScriptPlayable<MotionLayerPlayable> _playable;
        private int _layerIndex;
        private readonly LayerParam _param;
        public LayerParam layerParam
        {
            get
            {
                return _param;
            }
        }

        public double length
        {
            get
            {
                return _param?.length ?? 0;
            }
        }

        public LayerController(ScriptPlayable<MotionTimelinePlayable> timelinePlayable, LayerParam param)
        {
            _timelinePlayable = timelinePlayable;
            _param = param;
        }

        public void Dispose()
        {
            if (_playable.IsValid())
            {
                _playable.Destroy();
                _playable = ScriptPlayable<MotionLayerPlayable>.Null;
            }
        }

        public void Play()
        {
            if (_timelinePlayable.IsValid() && _timelinePlayable.GetBehaviour().TryGetLayerPlayable(this, out _playable, out _layerIndex))
                _playable.Play();
        }

        [AsyncStateMachine(typeof(_003CWaitForCompletionAsync_003Ed__12))]
        public UniTask WaitForCompletionAsync(CancellationToken ct)
        {
            var stateMachine = new _003CWaitForCompletionAsync_003Ed__12();
            stateMachine._003C_003Et__builder = AsyncUniTaskMethodBuilder.Create();
            stateMachine._003C_003E4__this = this;
            stateMachine.ct = ct;
            stateMachine._003C_003E1__state = -1;
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
            return stateMachine._003C_003Et__builder.Task;
        }

        public bool IsPlaying()
        {
            return _playable.IsValid() && !_playable.GetBehaviour().isCompleted;
        }

        public bool IsPause()
        {
            return _playable.IsValid() && _playable.GetPlayState() == PlayState.Paused;
        }

        public void Pause()
        {
            if (_playable.IsValid())
                _playable.Pause();
        }

        public void Resume()
        {
            if (_playable.IsValid())
                _playable.Play();
        }

        public void Stop()
        {
            Dispose();
        }

        public void SetTime(double time)
        {
            if (_playable.IsValid())
            {
                _playable.SetTime(time);
                if (IsPause())
                {
                    _playable.Play();
                    _playable.GetGraph().Evaluate();
                    _playable.Pause();
                }
            }
        }

        public double GetTime()
        {
            return _playable.IsValid() ? _playable.GetTime() : 0;
        }

        public void SetWeight(float weight)
        {
            if (_timelinePlayable.IsValid())
                _timelinePlayable.GetBehaviour().SetLayerWeight(_layerIndex, weight);
        }

        public float GetWeight()
        {
            return _timelinePlayable.IsValid() ? _timelinePlayable.GetBehaviour().GetLayerWeight(_layerIndex) : 0f;
        }

        private ScriptPlayable<MotionLayerMixerPlayable> GetLayerPlayable(string otherLayerName)
        {
            return _timelinePlayable.IsValid() ? _timelinePlayable.GetBehaviour().GetLayerMixerPlayable(otherLayerName) : ScriptPlayable<MotionLayerMixerPlayable>.Null;
        }

        public bool IsPlayingLayer(string otherLayerName)
        {
            return GetLayerPlayable(otherLayerName).IsValid();
        }

        public float GetLayerWeight(string otherLayerName)
        {
            return _timelinePlayable.IsValid() ? _timelinePlayable.GetBehaviour().GetLayerWeight(otherLayerName) : 1f;
        }

        public bool IsValid()
        {
            return _playable.IsValid();
        }

        public int GetPlayableCount()
        {
            return _playable.IsValid() ? _playable.GetBehaviour()?.GetPlayableCount() ?? 0 : 0;
        }

        public PlayState GetPlayablePlayState(int index)
        {
            return _playable.IsValid() && _playable.GetBehaviour() != null ? _playable.GetBehaviour().GetPlayablePlayState(index) : PlayState.Paused;
        }

        public void PlayPlayable(int index)
        {
            if (_playable.IsValid())
                _playable.GetBehaviour()?.PlayPlayable(index);
        }

        public void PausePlayable(int index)
        {
            if (_playable.IsValid())
                _playable.GetBehaviour()?.PausePlayable(index);
        }

        public void SetPlayableTime(int index, double time)
        {
            if (_playable.IsValid())
                _playable.GetBehaviour()?.SetPlayableTime(index, time);
        }

        public void SetPlayableWeight(int index, float weight)
        {
            if (_playable.IsValid())
                _playable.GetBehaviour()?.SetPlayableWeight(index, weight);
        }
    }
}
