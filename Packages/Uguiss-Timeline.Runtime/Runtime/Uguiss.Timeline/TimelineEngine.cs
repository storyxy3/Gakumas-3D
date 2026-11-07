namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss;
    using global::Uguiss.Timeline;

    public class TimelineEngine : Engine
    {
        [CompilerGenerated]
        private Action _003COnTimelineReady_003Ek__BackingField;
        [CompilerGenerated]
        private Action _003COnTimelineStart_003Ek__BackingField;
        [CompilerGenerated]
        private Action _003COnTimelineComplete_003Ek__BackingField;
        public TimelineManager Timeline
        {
            get
            {
                return null;
            }
        }

        public Action OnTimelineReady
        {
            [CompilerGenerated]
            get
            {
                return _003COnTimelineReady_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnTimelineReady_003Ek__BackingField = value;
            }
        }

        public Action OnTimelineStart
        {
            [CompilerGenerated]
            get
            {
                return _003COnTimelineStart_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnTimelineStart_003Ek__BackingField = value;
            }
        }

        public Action OnTimelineComplete
        {
            [CompilerGenerated]
            get
            {
                return _003COnTimelineComplete_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnTimelineComplete_003Ek__BackingField = value;
            }
        }

        public TimelineEngine()
        {
        }
    }
}
