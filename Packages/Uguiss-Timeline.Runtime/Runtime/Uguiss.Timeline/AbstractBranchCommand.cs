namespace Uguiss.Timeline
{
    using global::Uguiss;
    using global::Uguiss.Timeline;

    public abstract class AbstractBranchCommand : AbstractCommand<TimelineEngine>
    {
        public override bool IsGroupCommand
        {
            get
            {
                return default(bool);
            }
        }

        public BranchData GetBranchData()
        {
            return null;
        }

        protected AbstractBranchCommand()
        {
        }
    }
}
