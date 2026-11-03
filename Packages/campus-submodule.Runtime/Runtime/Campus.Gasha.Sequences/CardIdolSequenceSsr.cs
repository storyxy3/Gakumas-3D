namespace Campus.Gasha.Sequences
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Campus.Live.Equipment;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Serialization;

    public class CardIdolSequenceSsr : CardIdolBase, ISequenceDirector, INotificationReceiver
    {
        public class CardIdolSsrBindParam : CardIdolSequence.CardIdolBindParam
        {
            public string liveVideoAssetName;
            public string idolVoiceAssetName;
            public string idolCardMovieAssetName;
            public string idolCardMovieLoopAssetName;
            public string skinName;
            public string rainbowSignAssetName;
            public float idolCardSsrAnimationStartMilliseconds;
            public Func<CancellationToken, UniTask> onProduceCardSkinCutIn;
            public bool IsAnotherIdol
            {
                get
                {
                    return default(bool);
                }
            }

            public CardIdolSsrBindParam()
            {
            }
        }

        private enum MovieType
        {
            Live,
            Card,
            CardLoop
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnClickedAsync_003Ed__45 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardIdolSequenceSsr _003C_003E4__this;
            private int _003CmovieIndex_003E5__2;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            private UniTask.Awaiter _003C_003Eu__2;
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
        private struct _003CPlay_003Ed__37 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardIdolSequenceSsr _003C_003E4__this;
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
        private struct _003CPlayTitanAnimationLoopAsync_003Ed__38 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardIdolSequenceSsr _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<ITimelineTween> _003CssrAnimation_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<ITimelineTween>.Awaiter _003C_003Eu__2;
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
        private struct _003CSetup_003Ed__36 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CardIdolSequenceSsr _003C_003E4__this;
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
        public TextMeshProUGUI idolSkinName;
        public GashaResourceView[] rainbowSigns;
        public CanvasGroup videoRoot;
        [FormerlySerializedAs("videoPlayer")]
        public CampusVideoPlayer liveVideoPlayer;
        public ABLoopVideoPlayer cardVideoPlayer;
        [CanBeNull]
        public GameObject anotherNameRoot;
        [CanBeNull]
        public GameObject anotherGlow;
        public GameObject backgroundCanvasRoot;
        public CampusCanvas blurCanvas;
        public GameObject blackBackgroundImageRoot;
        [CanBeNull]
        public LiveEquipmentController equipmentController;
        [CanBeNull]
        public LiveEquipmentReceiver equipmentReceiver;
        public TitanPlayer titanSignAnimation;
        public TitanPlayer titanSsrAnimation;
        public double newLabelDisplayDelayMilliSeconds;
        public float tapDelay;
        public float onLiveVideoTapRestriction;
        private GashaVideoPlayerHandler _cardVideoHandler;
        private CancellationTokenSource _cardAnimationCts;
        private CancellationTokenSource _sequenceCts;
        private GashaPlayableDirectorHandler _directorHandler;
        private CardIdolSsrBindParam _param;
        private (bool hasVoice, string assetName) _characterVoice;
        private bool _videoPlayStarted;
        private bool _playCompleted;
        private bool _isTitanAnimationLoopPlayed;
        private CancellationTokenSource _cardAnimationDelayCts;
        private List<(MovieType movieType, string movieAsset)> _movieTable;
        private bool _isProcessingOnClicked;
        private bool _showNewLabel;
        public PlayableDirector Director
        {
            get
            {
                return null;
            }
        }

        public void Bind(CardIdolSsrBindParam bindParam)
        {
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__36))]
        public override UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__37))]
        public override UniTask Play()
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlayTitanAnimationLoopAsync_003Ed__38))]
        private UniTask PlayTitanAnimationLoopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private double GetIdolMovieStartTime()
        {
            return default(double);
        }

        private void SetVisibleSkipButton(bool isVisible)
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

        [AsyncStateMachine(typeof(_003COnClickedAsync_003Ed__45))]
        private UniTask OnClickedAsync()
        {
            return default(UniTask);
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        public CardIdolSequenceSsr()
        {
        }
    }
}
