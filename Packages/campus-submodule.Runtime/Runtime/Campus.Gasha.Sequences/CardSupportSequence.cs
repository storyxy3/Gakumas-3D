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
    using global::TMPro;
    using global::UnityEngine.Playables;

    public class CardSupportSequence : GashaSequenceBase, INotificationReceiver, ISequenceDirector
    {
        public class CardSupportBindParam
        {
            public CinemachineBrain cinemachineBrain;
            public string supportCardAssetName;
            public string supportCardName;
            public string[] flavorTexts;
            public string[] flavorVoices;
            public bool isNew;
            public int gashaAnimationNumber;
            public CardSupportBindParam()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass26_0
        {
            public CancellationToken ct;
            public _003C_003Ec__DisplayClass26_0()
            {
            }

            internal UniTask _003CSetup_003Eb__0(string voice)
            {
                return default(UniTask);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnClickedAsync_003Ed__32 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardSupportSequence _003C_003E4__this;
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
        private struct _003CPlay_003Ed__27 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardSupportSequence _003C_003E4__this;
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
        private struct _003CSetup_003Ed__26 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public CardSupportSequence _003C_003E4__this;
            private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;
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
        public GashaResourceView supportCard;
        public GashaResourceView[] backgroundCards;
        [CanBeNull]
        public LiveEquipmentController equipmentController;
        [CanBeNull]
        public LiveEquipmentReceiver equipmentReceiver;
        [CanBeNull]
        public TextMeshProUGUI supportCardName;
        [CanBeNull]
        public TitanPlayer isNewTitanPlayer;
        [CanBeNull]
        public TitanPlayer supportCardTitanPlayer;
        [CanBeNull]
        public string supportCardTitanAnimationParamName;
        public TextMeshProUGUI[] flavorTexts;
        public float voiceFadeOutTime;
        public float onStartTapRestriction;
        public float onSkippedTapRestriction;
        private CardSupportBindParam _param;
        private string[] _flavorVoices;
        private ICampusSoundPlayer _soundPlayer;
        private GashaPlayableDirectorHandler _directorHandler;
        private CancellationTokenSource _sequenceCts;
        private bool _showNewLabel;
        private readonly FadeOutVoicePlayer _fadeOutVoicePlayer;
        private bool _isProcessingOnClicked;
        private Stopwatch _playingStopwatch;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }
        }

        public void Bind(CardSupportBindParam param)
        {
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__26))]
        public override UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__27))]
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

        [AsyncStateMachine(typeof(_003COnClickedAsync_003Ed__32))]
        private UniTask OnClickedAsync()
        {
            return default(UniTask);
        }

        private void PlayVoice(int index, CancellationToken ct)
        {
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        public CardSupportSequence()
        {
        }
    }
}
