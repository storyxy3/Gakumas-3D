namespace Uguiss.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;

    public class MixerPlayableBase<T> : MixerPlayableBase where T : TimelineEngine
    {
        [CompilerGenerated]
        private T _003CEngine_003Ek__BackingField;
        protected T Engine
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public void SetEngine(T engine)
        {
        }

        public MixerPlayableBase()
        {
        }
    }
}
