namespace Campus.Gasha.Sequences
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::UnityEngine;

    public abstract class GashaSequenceBase : MonoBehaviour
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetup_003Ed__5 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public string characterId;
        public GashaId[] gashaIds;
        [CanBeNull]
        public GashaGlobalEffect globalEffect;
        public string CharacterId
        {
            get
            {
                return null;
            }
        }

        [AsyncStateMachine(typeof(_003CSetup_003Ed__5))]
        public virtual UniTask Setup([Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual void OnClicked()
        {
        }

        public virtual void OnSkipped()
        {
        }

        public abstract UniTask Play();
        public abstract void Stop();
        public abstract void Pause();
        public abstract void UnPause();
        protected GashaSequenceBase()
        {
        }
    }
}
