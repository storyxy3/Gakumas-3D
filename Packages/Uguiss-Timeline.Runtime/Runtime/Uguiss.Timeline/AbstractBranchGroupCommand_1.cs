namespace Uguiss.Timeline
{
    using global::Uguiss.Timeline;

    public abstract class AbstractBranchGroupCommand<T> : AbstractBranchGroupCommand where T : TimelineEngine
    {
        protected AbstractBranchGroupCommand()
        {
        }
    }
}
