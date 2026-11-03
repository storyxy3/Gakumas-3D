namespace Campus.Gasha.Sequences
{
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
    using global::JetBrains.Annotations;
    using global::UnityEngine.Playables;

    public class CardIdolSequence : CardIdolBase, INotificationReceiver, ISequenceDirector
    {
        public class CardIdolBindParam
        {
            public CinemachineBrain cinemachineBrain;
            public string idolCardAssetName;
            public string idolNameAssetName;
            public string signAssetName;
            public string subName;
            public bool isNew;
            public CardIdolBindParam()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__12 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardIdolSequence _003C_003E4__this;
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
        private struct _003CSetup_003Ed__11 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardIdolSequence _003C_003E4__this;
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
        private GashaPlayableDirectorHandler _directorHandler;
        private CancellationTokenSource _sequenceCts;
        private CardIdolBindParam _param;
        private bool _showNewLabel;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }
        }

        public void Bind(CardIdolBindParam param)
        {
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__11))]
        public override UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__12))]
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

        public override void OnClicked()
        {
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        public CardIdolSequence()
        {
        }
    }
}
