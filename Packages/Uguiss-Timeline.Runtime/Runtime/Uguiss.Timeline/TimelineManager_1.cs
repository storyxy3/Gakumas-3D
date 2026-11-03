namespace Uguiss.Timeline
{
    using global::Uguiss.Timeline;

    public class TimelineManager<T> : TimelineManager where T : TimelineEngine
    {
        public new T Engine
        {
            get
            {
                return null;
            }
        }

        protected override void SetEngine(MixerPlayableBase mixerBehaviour)
        {
        }

        public TimelineManager()
        {
        }
    }
}
