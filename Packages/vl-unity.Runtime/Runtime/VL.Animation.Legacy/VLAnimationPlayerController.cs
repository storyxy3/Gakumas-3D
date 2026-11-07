namespace VL.Animation.Legacy
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::VL.Animation;
    using global::VL.Animation.Legacy;

    internal class VLAnimationPlayerController : IVLAnimationPlayerController, IAnimationController
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitForCompletionAsync_003Ed__31 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public VLAnimationPlayerController _003C_003E4__this;
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

        [CompilerGenerated]
        private VLAnimationClipPlayerParam _003Cparam_003Ek__BackingField;
        [CompilerGenerated]
        private VLAnimationClipPlayerParam.LayerParam _003Clayer_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CplayingLayerIndex_003Ek__BackingField;
        [CompilerGenerated]
        private VLAnimationClipPlayer _003Cplayer_003Ek__BackingField;
        public VLAnimationClipPlayerParam param
        {
            [CompilerGenerated]
            get
            {
                return _003Cparam_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003Cparam_003Ek__BackingField = value;
            }
        }

        public VLAnimationClipPlayerParam.LayerParam layer
        {
            [CompilerGenerated]
            get
            {
                return _003Clayer_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003Clayer_003Ek__BackingField = value;
            }
        }

        public int playingLayerIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CplayingLayerIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CplayingLayerIndex_003Ek__BackingField = value;
            }
        }

        private VLAnimationClipPlayer player
        {
            [CompilerGenerated]
            get
            {
                return _003Cplayer_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003Cplayer_003Ek__BackingField = value;
            }
        }

        public string layerName
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

        public VLAnimationPlayerController(VLAnimationClipPlayerParam param, VLAnimationClipPlayer player)
        {
        }

        public void Play()
        {
        }

        [AsyncStateMachine(typeof(_003CWaitForCompletionAsync_003Ed__31))]
        public UniTask WaitForCompletionAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public bool IsPlaying()
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

        public void SetWeight(float weight)
        {
        }

        public float GetWeight()
        {
            return default(float);
        }

        public void SetTime(double time)
        {
        }

        public double GetTime()
        {
            return default(double);
        }

        public bool IsPlayingLayer(string otherLayerName)
        {
            return default(bool);
        }

        public float GetLayerWeight(string otherLayerName)
        {
            return default(float);
        }

        public void RegisterPrepareFrameEvent(VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent)
        {
        }

        public void UnregisterPrepareFrameEvent(VLAnimationClipParamMixerPlayable.PrepareFrameEvent onLayerPrepareFrameEvent)
        {
        }

        public bool IsValid()
        {
            return default(bool);
        }
    }
}
