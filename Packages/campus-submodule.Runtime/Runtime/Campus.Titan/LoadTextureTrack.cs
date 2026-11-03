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
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(RawImage))]
    [TrackColor(0.8f, 0.2f, 0.6f)]
    [DisplayName("Titan/Load/Texture")]
    public class LoadTextureTrack : TweenTrackBase, ILoadAssetTrack
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public LoadTextureTrack _003C_003E4__this;
            public TitanPlayer titanPlayer;
            public CancellationToken ct;
            private RawImage _003Ccomponent_003E5__2;
            private TaskAwaiter<Texture2D> _003C_003Eu__1;
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

        public LoadTextureTrack()
        {
        }
    }
}
