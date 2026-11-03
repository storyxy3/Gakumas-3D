namespace Campus.Gasha.Sequences
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha.Sequences;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    internal class FadeOutVoicePlayer
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public string assetName;
            public CancellationToken ct;
            public FadeOutVoicePlayer _003C_003E4__this;
            public float fadeTime;
            private UniTask<ICampusSoundPlayer>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private ICampusSoundPlayer _currentPlaying;
        [AsyncStateMachine(typeof(_003CPlay_003Ed__1))]
        public UniTask Play(string assetName, float fadeTime, CancellationToken ct)
        {
            return default(UniTask);
        }

        public FadeOutVoicePlayer()
        {
        }
    }
}
