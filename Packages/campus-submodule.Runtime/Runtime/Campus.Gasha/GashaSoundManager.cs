namespace Campus.Gasha
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    public static class GashaSoundManager
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CDownloadAsync_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public string assetName;
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

        public static void PlaySe(string assetName, CancellationToken ct, float volume = 1f)
        {
        }

        public static void PlayBgm(string assetName, long startTimeMs)
        {
        }

        public static void StopBgm()
        {
        }

        public static void PlayVoice(string assetName, CancellationToken ct)
        {
        }

        [AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__6))]
        public static UniTask DownloadAsync(string assetName, CancellationToken ct)
        {
            return default(UniTask);
        }
    }
}
