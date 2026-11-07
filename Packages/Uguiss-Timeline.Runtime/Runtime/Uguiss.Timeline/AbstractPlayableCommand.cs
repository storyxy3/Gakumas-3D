namespace Uguiss.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Uguiss;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public abstract class AbstractPlayableCommand : AbstractCommand<TimelineEngine>
    {
        [OptionalParameter("Timing", "", HideInInspector = true)]
        public TimelineClipParameter clip;
        [CompilerGenerated]
        private Playable _003CPlayable_003Ek__BackingField;
        [CompilerGenerated]
        private Playable _003CMixer_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CPrevMixerId_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CInputPort_003Ek__BackingField;
        private TimelineClip _clipCache;
        public TimelineClip Clip
        {
            get
            {
                return null;
            }
        }

        public Playable Playable
        {
            [CompilerGenerated]
            get
            {
                return _003CPlayable_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CPlayable_003Ek__BackingField = value;
            }
        }

        public Playable Mixer
        {
            [CompilerGenerated]
            get
            {
                return _003CMixer_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CMixer_003Ek__BackingField = value;
            }
        }

        private string PrevMixerId
        {
            [CompilerGenerated]
            set
            {
                _003CPrevMixerId_003Ek__BackingField = value;
            }
        }

        public int InputPort
        {
            [CompilerGenerated]
            get
            {
                return _003CInputPort_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CInputPort_003Ek__BackingField = value;
            }
        }

        public virtual int Order
        {
            get
            {
                return default(int);
            }
        }

        public virtual DurationType DurationType
        {
            get
            {
                return default(DurationType);
            }
        }

        public virtual ClipCaps ClipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public virtual WaitMode WaitMode
        {
            get
            {
                return default(WaitMode);
            }
        }

        public virtual SkipTargets SkipTargets
        {
            get
            {
                return default(SkipTargets);
            }
        }

        protected override void OnInitialize()
        {
        }

        private void UpdateClip()
        {
        }

        public override UniTask PreExecuteAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public override UniTask ExecuteAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public virtual string GetMixerId()
        {
            return null;
        }

        public virtual TimelineElement CompileCommand(PlayableGraph graph, Playable mixer, string mixerId, int inputPort)
        {
            return null;
        }

        protected virtual Playable CreatePlayable(PlayableGraph graph)
        {
            return default(Playable);
        }

        public virtual Playable CreateMixerPlayable(PlayableGraph graph, int inputCount)
        {
            return default(Playable);
        }

        public virtual PlayableOutput CreatePlayableOutput(PlayableGraph graph)
        {
            return default(PlayableOutput);
        }

        protected virtual TimelineElement CreateTimelineElement()
        {
            return null;
        }

        public virtual void RegisterResource()
        {
        }

        protected virtual void BindParameter()
        {
        }

        public virtual void ResetCommand()
        {
        }

        public virtual bool IsUpdateMixer()
        {
            return default(bool);
        }

        protected AbstractPlayableCommand()
        {
        }
    }
}
