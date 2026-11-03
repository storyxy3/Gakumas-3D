namespace Uguiss.Timeline
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Uguiss;
    using global::Uguiss.Timeline;

    public abstract class AbstractBranchGroupCommand : AbstractCommand<TimelineEngine>
    {
        private BranchGroupData _branchGroupData;
        public override bool IsGroupCommand
        {
            get
            {
                return default(bool);
            }
        }

        public BranchGroupData GetBranchGroupData()
        {
            return null;
        }

        public void ResetBranchGroupData()
        {
        }

        public override UniTask PreExecuteAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        protected AbstractBranchGroupCommand()
        {
        }
    }
}
