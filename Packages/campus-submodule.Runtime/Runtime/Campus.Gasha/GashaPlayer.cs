namespace Campus.Gasha
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    public class GashaPlayer : IGashaPlayer, IDisposable
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayAsync_003Ed__11 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaPlayer _003C_003E4__this;
            private GashaTransitionNode _003Cnode_003E5__2;
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
        private struct _003CPlaySequence_003Ed__16 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaTransitionNode node;
            public GashaPlayer _003C_003E4__this;
            private GashaSequenceBase _003Csequence_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public Action onPlayStart;
        public Action onDispose;
        public Action<GashaTransitionNode> OnPlayNode;
        private GashaTransitionGraph _sequenceTransitionGraph;
        private GashaTransitionGraph _cardTransitionGraph;
        private GashaGlobalEffect _globalEffect;
        private bool _skipRequest;
        private GashaTransitionNode _currentNode;
        private CampusButton _fullscreenButton;
        private CampusButton _skipButton;
        public GashaPlayer(GashaTransitionGraph sequenceGraph, GashaTransitionGraph cardGraph, GashaGlobalEffect globalEffect, CampusButton fullscreenButton, CampusButton skipButton)
        {
        }

        [AsyncStateMachine(typeof(_003CPlayAsync_003Ed__11))]
        public UniTask PlayAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Skip()
        {
        }

        public bool TryGetActiveIdolCardSubNameTextTopWorldY(out float worldY)
        {
            throw null;
        }

        [AsyncStateMachine(typeof(_003CPlaySequence_003Ed__16))]
        private UniTask PlaySequence(GashaTransitionNode node)
        {
            return default(UniTask);
        }

        public void Dispose()
        {
        }
    }
}
