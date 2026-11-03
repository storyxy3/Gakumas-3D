namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(CharacterDearnessReport))]
    [TrackColor(0.8f, 0.2f, 0.6f)]
    [DisplayName("Titan/Load/CharacterDearnessReport")]
    public class LoadCharacterDearnessReportTrack : TweenTrackBase, ILoadAssetTrack
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TitanPlayer titanPlayer;
            public LoadCharacterDearnessReportTrack _003C_003E4__this;
            public CancellationToken ct;
            private CharacterDearnessReport _003Ccomponent_003E5__2;
            private UniTask<(Texture2D, Texture2D, Texture2D, Texture2D)>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadTextureAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<Texture2D> _003C_003Et__builder;
            public string assetName;
            public LoadCharacterDearnessReportTrack _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<Texture2D>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private ReusableAssetKeeper _reusableAssetKeeper;
        private const int AssetKeeperCapacity = 4;
        [AsyncStateMachine(typeof(_003CLoadAsync_003Ed__2))]
        public UniTask LoadAsync(TitanPlayer titanPlayer, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadTextureAsync_003Ed__3))]
        private UniTask<Texture2D> LoadTextureAsync(string assetName, CancellationToken ct)
        {
            return default(UniTask<Texture2D>);
        }

        public LoadCharacterDearnessReportTrack()
        {
        }
    }
}
