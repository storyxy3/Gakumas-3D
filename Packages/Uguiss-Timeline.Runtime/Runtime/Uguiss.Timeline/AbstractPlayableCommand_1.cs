namespace Uguiss.Timeline
{
    using global::Uguiss.Timeline;

    public abstract class AbstractPlayableCommand<T> : AbstractPlayableCommand where T : TimelineEngine
    {
        public new T Engine
        {
            get
            {
                return null;
            }
        }

        protected AbstractPlayableCommand()
        {
        }
    }
}
