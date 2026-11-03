namespace Campus.Gasha
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::UnityEngine;

    public class GashaBinder
    {
        public class BindParams
        {
            public CinemachineBrain cinemachineBrain;
            public AudioSource audioSource;
            public GashaTimelineController gashaTimelineController;
            [CanBeNull]
            public GashaEnvironment gashaEnvironment;
            public Camera uiCamera;
            public GashaCardParam[] cardParams;
            public Dictionary<RarityType, Dictionary<GashaId, List<(GashaId gashaId, int weight)>>> gashaAnimationsGraph;
            public int contentsSortingLayerId;
            public int contentFrontSortingLayerId;
            public int overlaySortingLayerId;
            public int reversalSsrPermil;
            public int reversalPickupSsrPermil;
            public BindParams()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CBind_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<IGashaPlayer> _003C_003Et__builder;
            public BindParams bindParams;
            public CancellationToken ct;
            private UniTask<GashaTimelineController.BindResult>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CBind_003Ed__1))]
        public UniTask<IGashaPlayer> Bind(BindParams bindParams, [Optional] CancellationToken ct)
        {
            return default(UniTask<IGashaPlayer>);
        }

        public GashaBinder()
        {
        }
    }
}
