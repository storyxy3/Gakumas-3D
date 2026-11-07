namespace Uguiss.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;

    public class TimelineClipParameter : AbstractJSONParameter<TimelineClip>
    {
        [CompilerGenerated]
        private Action _003COnUpdateValue_003Ek__BackingField;
        public Action OnUpdateValue
        {
            [CompilerGenerated]
            private get
            {
                return _003COnUpdateValue_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnUpdateValue_003Ek__BackingField = value;
            }
        }

        public override void SetValue(TimelineClip value)
        {
        }

        public TimelineClipParameter()
        {
        }
    }
}
