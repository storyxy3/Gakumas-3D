namespace Campus.Titan
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;
    using global::Titan;
    using global::UniRx;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(SoundEffectClip))]
    [DisplayName("Titan/SoundEffect")]
    public class SoundEffectTrack : TweenTrackBase, ILoadAssetTrack
    {
        private class PlayingWatcher
        {
            [CompilerGenerated]
            private readonly bool _003CIsAdv_003Ek__BackingField;
            private readonly ITitanAdvBridge _advBridge;
            private readonly TweenCreationContext _context;
            public bool IsAdv
            {
                [CompilerGenerated]
                get
                {
                    return default(bool);
                }
            }

            private TweenCreationContext Root
            {
                get
                {
                    return null;
                }
            }

            public bool IsPlaying
            {
                get
                {
                    return default(bool);
                }
            }

            public PlayingWatcher(TweenCreationContext context)
            {
            }

            public IObservable<Unit> GetPauseObservable()
            {
                return null;
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SoundEffectTrack _003C_003E4__this;
            public CancellationToken ct;
            private ListPool<UniTask>.ListContainer _003Ctasks_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        protected override void InsertTween(TweenCreationContext context)
        {
        }

        private void InsertClipTween(TweenCreationContext context, SoundEffectClip clipAsset, float clipStart, float clipDuration, PlayingWatcher playingWatcher)
        {
        }

        [AsyncStateMachine(typeof(_003CLoadAsync_003Ed__3))]
        public UniTask LoadAsync(TitanPlayer titanPlayer, CancellationToken ct)
        {
            return default(UniTask);
        }

        public SoundEffectTrack()
        {
        }
    }
}
