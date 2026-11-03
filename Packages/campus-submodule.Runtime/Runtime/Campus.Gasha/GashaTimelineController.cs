namespace Campus.Gasha
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
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::VL;

    public class GashaTimelineController : MonoBehaviour
    {
        public class GashaTimelineBindParam
        {
            public CinemachineBrain cinemachineBrain;
            public AudioSource audioSource;
            public Camera uiCamera;
            [CanBeNull]
            public Dictionary<RarityType, Dictionary<GashaId, List<(GashaId gashaId, int weight)>>> gashaAnimationsGraph;
            public GashaCardParam[] cardParams;
            public int contentsSortingLayerId;
            public int contentFrontSortingLayerId;
            public int overlaySortingLayerId;
            public string envBgmAssetName;
            public long envBgmStartTimeMs;
            public int reversalSsrPermil;
            public int reversalPickupSsrPermil;
            public GashaTimelineBindParam()
            {
            }
        }

        public class BindResult
        {
            public IGashaPlayer gashaPlayer;
            public GashaTransitionGraph transitionGraph;
            public GashaTransitionGraph cardGraph;
            public GashaId[] gashaIds;
            public BindResult()
            {
            }
        }

        [Serializable]
        public class ActorMotionDefineKeyValue
        {
            public string characterId;
            public ActorMotionDefine motionDefine;
            public ActorMotionDefineKeyValue()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CBind_003Ed__20 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<BindResult> _003C_003Et__builder;
            public GashaTimelineController _003C_003E4__this;
            public GashaTimelineBindParam bindParam;
            public CancellationToken ct;
            private GashaCardModel _003CcardModel_003E5__2;
            private GashaBgmModel _003CbgmModel_003E5__3;
            private GashaId[] _003CgashaIds_003E5__4;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<GahsaBindUseCase.Result>.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public Canvas uiCanvas;
        public CanvasGroup uiCanvasGroup;
        public CampusButton fullScreenButton;
        public CampusButton skipButton;
        public GashaGlobalEffect globalEffect;
        public CardIdolSequence idolSequenceR;
        public CardIdolSequence idolSequenceSr;
        public CardIdolSequenceSsr idolSequenceSsr;
        public CardIdolSequenceSsr idolSequencePickup;
        public CardIdolBase idolSequenceReversalSsrFromR;
        [FormerlySerializedAs("idolSequenceReversalSsr")]
        public CardIdolBase idolSequenceReversalSsrFromSr;
        public CardSupportSequence supportSequenceR;
        public CardSupportSequence supportSequenceSr;
        public CardSupportSequence supportSequenceSsr;
        public CardSupportSequence supportSequenceReversalSsrFromR;
        [FormerlySerializedAs("supportSequenceReversalSsr")]
        public CardSupportSequence supportSequenceReversalSsrFromSr;
        public ActorMotionDefineKeyValue[] actorMotionDefines;
        [AsyncStateMachine(typeof(_003CBind_003Ed__20))]
        public UniTask<BindResult> Bind(GashaTimelineBindParam bindParam, CancellationToken ct)
        {
            return default(UniTask<BindResult>);
        }

        public GashaTimelineController()
        {
        }
    }
}
