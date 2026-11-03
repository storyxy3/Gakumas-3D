namespace Uguiss.Timeline
{
    using global::Uguiss.Timeline;

    public abstract class AbstractBranchCommand<T> : AbstractBranchCommand where T : TimelineEngine
    {
        protected AbstractBranchCommand()
        {
        }
    }
}
