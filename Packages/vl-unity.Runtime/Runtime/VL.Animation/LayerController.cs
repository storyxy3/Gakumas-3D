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
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
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
                return null;
            }
        }

        public double length
        {
            get
            {
                return default(double);
            }
        }

        public LayerController(ScriptPlayable<MotionTimelinePlayable> timelinePlayable, LayerParam param)
        {
        }

        public void Dispose()
        {
        }

        public void Play()
        {
        }

        [AsyncStateMachine(typeof(_003CWaitForCompletionAsync_003Ed__12))]
        public UniTask WaitForCompletionAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public bool IsPlaying()
        {
            return default(bool);
        }

        public bool IsPause()
        {
            return default(bool);
        }

        public void Pause()
        {
        }

        public void Resume()
        {
        }

        public void Stop()
        {
        }

        public void SetTime(double time)
        {
        }

        public double GetTime()
        {
            return default(double);
        }

        public void SetWeight(float weight)
        {
        }

        public float GetWeight()
        {
            return default(float);
        }

        private ScriptPlayable<MotionLayerMixerPlayable> GetLayerPlayable(string otherLayerName)
        {
            return default(ScriptPlayable<MotionLayerMixerPlayable>);
        }

        public bool IsPlayingLayer(string otherLayerName)
        {
            return default(bool);
        }

        public float GetLayerWeight(string otherLayerName)
        {
            return default(float);
        }

        public bool IsValid()
        {
            return default(bool);
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
    }
}
