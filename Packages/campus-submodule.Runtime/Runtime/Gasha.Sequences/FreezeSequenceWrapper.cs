namespace Gasha.Sequences
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Gasha.Sequences;
    using global::UnityEngine;

    public class FreezeSequenceWrapper : GashaSequenceBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlay_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public FreezeSequenceWrapper _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        private GashaFreezeEffect _freezeEffect;
        public void Initialize(GashaFreezeEffect freezeEffect, GashaGlobalEffect globalEffect)
        {
        }

        [AsyncStateMachine(typeof(_003CPlay_003Ed__2))]
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

        public FreezeSequenceWrapper()
        {
        }
    }
}
