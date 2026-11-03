namespace Campus.Gasha
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    public class GashaVideoPlayerHandler : IDisposable
    {
        public interface IGashaVideoPlayer : IDisposable
        {
            bool IsPlaying { get; }

            bool IsEnd { get; }

            double ElapsedTime { get; }

            UniTask<bool> InitializeAsync(CancellationToken ct);
            void Play();
            void Stop();
        }

        public class CampusVideoPlayer : IGashaVideoPlayer, IDisposable
        {
            [StructLayout((LayoutKind)3)]
            [CompilerGenerated]
            private struct _003CInitializeAsync_003Ed__9 : IAsyncStateMachine
            {
                public int _003C_003E1__state;
                public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
                public CampusVideoPlayer _003C_003E4__this;
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

            private Campus.Common.CampusVideoPlayer _videoPlayer;
            private string _resourceName;
            public double ElapsedTime
            {
                get
                {
                    return default(double);
                }
            }

            public bool IsPlaying
            {
                get
                {
                    return default(bool);
                }
            }

            public bool IsEnd
            {
                get
                {
                    return default(bool);
                }
            }

            public CampusVideoPlayer(Campus.Common.CampusVideoPlayer videoPlayer, string resourceName)
            {
            }

            [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__9))]
            public UniTask<bool> InitializeAsync(CancellationToken ct)
            {
                return default(UniTask<bool>);
            }

            public void Play()
            {
            }

            public void Stop()
            {
            }

            public void Dispose()
            {
            }
        }

        public class ABLoopVideoPlayer : IGashaVideoPlayer, IDisposable
        {
            [StructLayout((LayoutKind)3)]
            [CompilerGenerated]
            private struct _003CInitializeAsync_003Ed__10 : IAsyncStateMachine
            {
                public int _003C_003E1__state;
                public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;
                public ABLoopVideoPlayer _003C_003E4__this;
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

            private Campus.Common.ABLoopVideoPlayer _videoPlayer;
            private IReadOnlyList<string> _resources;
            private Stopwatch _elapsedStopwatch;
            public double ElapsedTime
            {
                get
                {
                    return default(double);
                }
            }

            public bool IsPlaying
            {
                get
                {
                    return default(bool);
                }
            }

            public bool IsEnd
            {
                get
                {
                    return default(bool);
                }
            }

            public ABLoopVideoPlayer(Campus.Common.ABLoopVideoPlayer videoPlayer, IReadOnlyList<string> resources)
            {
            }

            [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__10))]
            public UniTask<bool> InitializeAsync(CancellationToken ct)
            {
                return default(UniTask<bool>);
            }

            public void Play()
            {
            }

            public void Stop()
            {
            }

            public void Dispose()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__9 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaVideoPlayerHandler _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
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
        private struct _003CPlayAsync_003Ed__10 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaVideoPlayerHandler _003C_003E4__this;
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

        private IGashaVideoPlayer _videoPlayer;
        private CancellationTokenSource _playCts;
        private bool _initialized;
        public bool IsPlaying
        {
            get
            {
                return default(bool);
            }
        }

        public GashaVideoPlayerHandler(IGashaVideoPlayer videoPlayer)
        {
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__9))]
        public UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlayAsync_003Ed__10))]
        public UniTask PlayAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Dispose()
        {
        }

        public double GetElapsedTime()
        {
            return default(double);
        }

        [CompilerGenerated]
        private bool _003CPlayAsync_003Eb__10_0()
        {
            return default(bool);
        }
    }
}
