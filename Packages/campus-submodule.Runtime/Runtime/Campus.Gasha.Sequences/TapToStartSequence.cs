namespace Campus.Gasha.Sequences
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Campus.Live.Equipment;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class TapToStartSequence : GashaSequenceBase, ISequenceDirector, INotificationReceiver
    {
        public class TapToStartSequenceBindParam
        {
            public CinemachineBrain cinemachineBrain;
            public Camera uiCamera;
            public string envBgmAssetName;
            public long envBgmStartTimeMs;
            public string pickupBgmAssetName;
            public long pickupBgmStartTimeMs;
            public TapToStartSequenceBindParam()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003COnClickAsync_003Eg__Haptic_007C29_0_003Ed : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TapToStartSequence _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnClickAsync_003Ed__29 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TapToStartSequence _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__23 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TapToStartSequence _003C_003E4__this;
            private UniTask _003CplayDirector_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetup_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TapToStartSequence _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<string>.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public PlayableDirector director;
        public CampusVideoPlayer videoPlayer;
        public TitanPlayer titanPlayer;
        public string moviePath;
        public string tapEffectTitanName;
        private GashaVideoPlayerHandler _videoPlayerHandler;
        private CancellationTokenSource _sequenceCts;
        private GashaPlayableDirectorHandler _directorHandler;
        private string _pickupBgmAssetName;
        private long _pickupBgmStartTimeMs;
        private string _envBgmAssetName;
        private long _envBgmStartTimeMs;
        public Canvas canvas;
        [CanBeNull]
        public LiveEquipmentController equipmentController;
        [CanBeNull]
        public LiveEquipmentReceiver equipmentReceiver;
        public float transitionDelay;
        public bool hapticOnTap;
        private bool _processingClick;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }
        }

        public void Bind(TapToStartSequenceBindParam param)
        {
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__22))]
        public override UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__23))]
        public override UniTask Play()
        {
            return default(UniTask);
        }

        private void SetActive(bool active)
        {
        }

        public override void Stop()
        {
        }

        public override void Pause()
        {
        }

        public override void UnPause()
        {
        }

        public override void OnClicked()
        {
        }

        [AsyncStateMachine(typeof(_003COnClickAsync_003Ed__29))]
        private UniTask OnClickAsync()
        {
            return default(UniTask);
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        private void OnDestroy()
        {
        }

        public TapToStartSequence()
        {
        }
    }
}
