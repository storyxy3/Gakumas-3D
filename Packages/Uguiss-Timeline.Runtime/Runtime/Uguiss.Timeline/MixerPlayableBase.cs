namespace Uguiss.Timeline
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Uguiss.Timeline;
    using global::UnityEngine.Playables;

    public class MixerPlayableBase : PlayableBehaviour
    {
        [CompilerGenerated]
        private readonly List<TimelineElement> _003CElements_003Ek__BackingField;
        public List<TimelineElement> Elements
        {
            [CompilerGenerated]
            get
            {
                return _003CElements_003Ek__BackingField;
            }
        }

        public void AddElement(TimelineElement element)
        {
        }

        public virtual void ResetMixer()
        {
        }

        protected TimelineElement GetActiveElement()
        {
            return null;
        }

        protected TimelineElement GetLatestElement(double time)
        {
            return null;
        }

        public MixerPlayableBase()
        {
        }
    }
}
