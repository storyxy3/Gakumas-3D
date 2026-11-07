namespace Uguiss.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public class AudioTimelineElement : TimelineElement
    {
        private bool _prevEnabled;
        [CompilerGenerated]
        private float _003CVolume_003Ek__BackingField;
        public float Volume
        {
            [CompilerGenerated]
            get
            {
                return _003CVolume_003Ek__BackingField;
            }
        }

        public override void Evaluate(double time, FrameData info)
        {
        }

        protected override bool IsEnabled(double time)
        {
            return default(bool);
        }

        protected override void SetTime(double time)
        {
        }

        public AudioTimelineElement()
        {
        }
    }
}
