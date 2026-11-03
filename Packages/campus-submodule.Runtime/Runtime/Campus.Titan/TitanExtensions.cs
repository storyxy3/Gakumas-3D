namespace Campus.Titan
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;
    using global::Titan;

    public static class TitanExtensions
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass0_0
        {
            public ListPool<UniTask>.ListContainer list;
            public TitanPlayer titanPlayer;
            public CancellationToken ct;
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAllAssetsAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TitanPlayer titanPlayer;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CLoadAllAssetsAsync_003Ed__0))]
        public static UniTask LoadAllAssetsAsync(this TitanPlayer titanPlayer, CancellationToken ct)
        {
            return default(UniTask);
        }
    }
}
