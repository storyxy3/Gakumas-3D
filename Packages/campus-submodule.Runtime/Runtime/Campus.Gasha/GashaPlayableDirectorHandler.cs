namespace Campus.Gasha
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::JetBrains.Annotations;
    using global::UnityEngine.Playables;

    public class GashaPlayableDirectorHandler
    {
        public interface IPlayableDirector
        {
            double duration { get; }

            double currentTime { get; }

            void Play(double initialTime);
            void Pause();
            void Resume();
            void Stop();
            void RebuildGraph();
            void Seek(double time);
        }

        public class Director : IPlayableDirector
        {
            [CanBeNull]
            private PlayableDirector _director;
            public double duration
            {
                get
                {
                    return default(double);
                }
            }

            public double currentTime
            {
                get
                {
                    return default(double);
                }
            }

            public Director(PlayableDirector d)
            {
            }

            public void Play(double initialTime = 0.0)
            {
            }

            public void Pause()
            {
            }

            public void Resume()
            {
            }

            public void Stop()
            {
            }

            public void RebuildGraph()
            {
            }

            public void Seek(double time)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayAsync_003Ed__13 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public GashaPlayableDirectorHandler _003C_003E4__this;
            public double duration;
            public CancellationToken ct;
            public double initialTime;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private IPlayableDirector _director;
        private CancellationTokenSource _playCts;
        [CompilerGenerated]
        private bool _003CIsPlaying_003Ek__BackingField;
        public double CurrentTime
        {
            get
            {
                return default(double);
            }
        }

        public double Duration
        {
            get
            {
                return default(double);
            }
        }

        private bool IsPlaying
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public GashaPlayableDirectorHandler(IPlayableDirector director)
        {
        }

        [AsyncStateMachine(typeof(_003CPlayAsync_003Ed__13))]
        public UniTask PlayAsync(CancellationToken ct, double duration = 1.7976931348623157E+308, double initialTime = 0.0)
        {
            return default(UniTask);
        }

        public void Pause()
        {
        }

        public void Resume()
        {
        }

        public void Seek(double time)
        {
        }

        public void RebuildGraph()
        {
        }
    }
}
