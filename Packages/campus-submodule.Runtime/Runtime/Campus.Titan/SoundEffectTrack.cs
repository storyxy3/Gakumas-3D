namespace Campus.Titan
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::DG.Tweening;
    using global::Qua.Utility;
    using global::Titan;
    using global::UniRx;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(SoundEffectClip))]
    [DisplayName("Titan/SoundEffect")]
    public class SoundEffectTrack : TweenTrackBase, ILoadAssetTrack
    {
        private class PlayingWatcher
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
                public static Func<Action, TweenCallback> _003C_003E9__10_4;
                public _003C_003Ec()
                {
                }

                internal TweenCallback _003CGetPauseObservable_003Eb__10_4(Action x)
                {
                    return null;
                }
            }

            [CompilerGenerated]
            private sealed class _003C_003Ec__DisplayClass10_0
            {
                public PlayingWatcher _003C_003E4__this;
                public TweenCreationContext root;
                public _003C_003Ec__DisplayClass10_0()
                {
                }

                internal void _003CGetPauseObservable_003Eb__0(Action x)
                {
                }

                internal void _003CGetPauseObservable_003Eb__1(Action x)
                {
                }

                internal void _003CGetPauseObservable_003Eb__2(Action<PlayableDirector> x)
                {
                }

                internal void _003CGetPauseObservable_003Eb__3(Action<PlayableDirector> x)
                {
                }

                internal void _003CGetPauseObservable_003Eb__5(TweenCallback x)
                {
                }

                internal void _003CGetPauseObservable_003Eb__6(TweenCallback x)
                {
                }
            }

            [CompilerGenerated]
            private readonly bool _003CIsAdv_003Ek__BackingField;
            private readonly ITitanAdvBridge _advBridge;
            private readonly TweenCreationContext _context;
            public bool IsAdv
            {
                [CompilerGenerated]
                get
                {
                    return _003CIsAdv_003Ek__BackingField;
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

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public ISoundEffectPlayer player;
            public bool isStart;
            public PlayingWatcher playingWatcher;
            public CancellationTokenSource cts;
            public Tween tween;
            public bool isPlaying;
            public TweenCreationContext context;
            public float clipDuration;
            public Action<Unit> _003C_003E9__5;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal void _003CInsertClipTween_003Eb__0(ICampusSoundPlayer x)
            {
            }

            internal void _003CInsertClipTween_003Eb__1(Unit _)
            {
            }

            internal float _003CInsertClipTween_003Eb__2()
            {
                return default(float);
            }

            internal void _003CInsertClipTween_003Eb__5(Unit _)
            {
            }

            internal void _003CInsertClipTween_003Eb__3(float x)
            {
            }

            internal void _003CInsertClipTween_003Eb__6()
            {
            }

            internal void _003CInsertClipTween_003Eg__Stop_007C4()
            {
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
