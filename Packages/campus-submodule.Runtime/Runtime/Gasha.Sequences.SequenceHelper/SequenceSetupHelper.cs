namespace Gasha.Sequences.SequenceHelper
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Timeline;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Gasha.Sequences.SequenceHelper;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public static class SequenceSetupHelper
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public CancellationToken ct;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal UniTask _003CDownloadVideosInChildren_003Eb__0(CampusTimelineCriVideoPlayer videoPlayer)
            {
                return default(UniTask);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CDownloadMarkerSeAndBgm_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public PlayableDirector director;
            public CancellationToken ct;
            private IEnumerator<string> _003C_003E7__wrap1;
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
        private struct _003CDownloadVideosInChildren_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public MonoBehaviour behaviour;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CDownloadVideosInChildren_003Ed__0))]
        public static UniTask DownloadVideosInChildren(MonoBehaviour behaviour, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CDownloadMarkerSeAndBgm_003Ed__1))]
        public static UniTask DownloadMarkerSeAndBgm(PlayableDirector director, CancellationToken ct)
        {
            return default(UniTask);
        }
    }
}
