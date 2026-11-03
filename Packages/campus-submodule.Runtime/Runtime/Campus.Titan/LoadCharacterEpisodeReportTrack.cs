namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(CharacterDearnessReportView))]
    [TrackColor(0.8f, 0.2f, 0.6f)]
    [DisplayName("Titan/Load/LoadCharacterEpisodeReportTrack")]
    public class LoadCharacterEpisodeReportTrack : TweenTrackBase, ILoadAssetTrack
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TitanPlayer titanPlayer;
            public LoadCharacterEpisodeReportTrack _003C_003E4__this;
            public CancellationToken ct;
            private CharacterDearnessReportView _003Ccomponent_003E5__2;
            private EpisodeReportData _003CbeforeEpisodeReportData_003E5__3;
            private int[] _003CredPenNumbers_003E5__4;
            private UniTask<(Texture2D, Texture2D, Texture2D, Texture2D, Texture2D, Texture2D[], Texture2D)>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadRedPenTextureAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<Texture2D[]> _003C_003Et__builder;
            public int[] redPenNumbers;
            public string characterId;
            public CharacterDearnessReportView component;
            public CancellationToken ct;
            private UniTask<Texture2D[]>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CLoadAsync_003Ed__0))]
        public UniTask LoadAsync(TitanPlayer titanPlayer, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadRedPenTextureAsync_003Ed__1))]
        private UniTask<Texture2D[]> LoadRedPenTextureAsync(CharacterDearnessReportView component, string characterId, int[] redPenNumbers, CancellationToken ct)
        {
            return default(UniTask<Texture2D[]>);
        }

        public LoadCharacterEpisodeReportTrack()
        {
        }
    }
}
