namespace Gasha.Sequences
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;
    using global::Campus.Gasha.Sequences;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Gasha.Sequences;
    using global::Titan;

    public class GashaFreezeEffect : GashaSequenceBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaFreezeEffect _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public CampusButton tapButton;
        public TitanPlayer titanPlayer;
        public float tapDelay;
        [AsyncStateMachine(typeof(_003CPlay_003Ed__3))]
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

        public GashaFreezeEffect()
        {
        }
    }
}
