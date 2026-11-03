namespace Campus.Gasha.Sequences
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Campus.Live.Equipment;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Gasha.Sequences;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [RequireComponent(typeof(PlayableDirector))]
    public class GashaSequence : GashaSequenceBase, INotificationReceiver, ISequenceDirector, IGashaFadeOut, IGashaFreeze
    {
        public class GashaSequenceBindParam
        {
            public CinemachineBrain cinemachineBrain;
            public Camera uiCamera;
            public string envBgmAssetName;
            public long envBgmStartTimeMs;
            public string pickupBgmAssetName;
            public long pickupBgmStartTimeMs;
            public GashaSequenceBindParam()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<IMarker, bool> _003C_003E9__32_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CGetFreezeTime_003Eb__32_0(IMarker x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__24 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaSequence _003C_003E4__this;
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
        private struct _003CSetup_003Ed__23 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaSequence _003C_003E4__this;
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

        public PlayableDirector director;
        [CanBeNull]
        public LiveEquipmentController equipmentController;
        [CanBeNull]
        public LiveEquipmentReceiver equipmentReceiver;
        [CompilerGenerated]
        private bool _003CDoFreeze_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CFadeOut_003Ek__BackingField;
        private string _envBgmAssetName;
        private long _envBgmStartTimeMs;
        private string _pickupBgmAssetName;
        private long _pickupBgmStartTimeMs;
        private GashaPlayableDirectorHandler _directorHandler;
        private CancellationTokenSource _sequenceCts;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }
        }

        public bool CanFreeze
        {
            get
            {
                return default(bool);
            }
        }

        public bool DoFreeze
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool FadeOut
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public void Bind(GashaSequenceBindParam param)
        {
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__23))]
        public override UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__24))]
        public override UniTask Play()
        {
            return default(UniTask);
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

        private void SetActive(bool active)
        {
        }

        public override void OnClicked()
        {
        }

        public override void OnSkipped()
        {
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        private double GetFreezeTime()
        {
            return default(double);
        }

        public GashaSequence()
        {
        }
    }
}
