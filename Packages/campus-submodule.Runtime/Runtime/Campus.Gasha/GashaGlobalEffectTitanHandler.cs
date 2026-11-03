namespace Campus.Gasha
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Titan;
    using global::UnityEngine;

    public class GashaGlobalEffectTitanHandler : MonoBehaviour
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaGlobalEffectTitanHandler _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<ITimelineTween>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public CanvasGroup rootCanvasGroup;
        public TitanPlayer titanPlayer;
        private bool IsValid()
        {
            return default(bool);
        }

        private void OnEnable()
        {
        }

        [AsyncStateMachine(typeof(_003CPlayAsync_003Ed__4))]
        public UniTask PlayAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public GashaGlobalEffectTitanHandler()
        {
        }
    }
}
