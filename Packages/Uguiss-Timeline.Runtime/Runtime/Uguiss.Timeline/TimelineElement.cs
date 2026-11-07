namespace Uguiss.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public class TimelineElement
    {
        private bool _prevEnabled;
        [CompilerGenerated]
        private TimelineClip _003CClip_003Ek__BackingField;
        [CompilerGenerated]
        private WaitMode _003CWaitMode_003Ek__BackingField;
        [CompilerGenerated]
        private SkipTargets _003CSkipTargets_003Ek__BackingField;
        [CompilerGenerated]
        private ClipCaps _003CClipCaps_003Ek__BackingField;
        [CompilerGenerated]
        private Playable _003CPlayable_003Ek__BackingField;
        [CompilerGenerated]
        private Playable _003CMixer_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CWeight_003Ek__BackingField;
        public TimelineClip Clip
        {
            [CompilerGenerated]
            get
            {
                return _003CClip_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CClip_003Ek__BackingField = value;
            }
        }

        public WaitMode WaitMode
        {
            [CompilerGenerated]
            get
            {
                return _003CWaitMode_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CWaitMode_003Ek__BackingField = value;
            }
        }

        public SkipTargets SkipTargets
        {
            [CompilerGenerated]
            get
            {
                return _003CSkipTargets_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CSkipTargets_003Ek__BackingField = value;
            }
        }

        public ClipCaps ClipCaps
        {
            [CompilerGenerated]
            set
            {
                _003CClipCaps_003Ek__BackingField = value;
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
            set
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
            set
            {
                _003CMixer_003Ek__BackingField = value;
            }
        }

        public float Weight
        {
            [CompilerGenerated]
            get
            {
                return _003CWeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CWeight_003Ek__BackingField = value;
            }
        }

        public virtual void Evaluate(double time, FrameData info)
        {
        }

        protected virtual bool IsEnabled(double time)
        {
            return default(bool);
        }

        public virtual void BeginWait(double waitStartTime)
        {
        }

        public virtual void EndWait(double waitStartTime, double waitEndTime)
        {
        }

        public virtual void OffsetClip(double fromTime, double toTime)
        {
        }

        public virtual void OffsetElapsedTime(double fromTime, double toTime)
        {
        }

        public virtual void ResetClip()
        {
        }

        public T GetPlayableBehaviour<T>()
            where T : PlayableBehaviour, new()
        {
            return null;
        }

        protected virtual float GetWeight(double time)
        {
            return default(float);
        }

        protected float GetMixInWeight(double time)
        {
            return default(float);
        }

        protected float GetMixOutWeight(double time)
        {
            return default(float);
        }

        protected virtual void SetInputWeight(float weight)
        {
        }

        protected virtual void SetTime(double time)
        {
        }

        public TimelineElement()
        {
        }
    }
}
