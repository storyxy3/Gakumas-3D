namespace Uguiss.Timeline
{
    using global::Uguiss.Timeline;

    public abstract class AbstractCommandPlayableCommand<TEngine, TCommand> : AbstractCommandPlayableCommand where TEngine : TimelineEngine where TCommand : AbstractCommandPlayableCommand<TEngine, TCommand>
    {
        protected AbstractCommandPlayableCommand()
        {
        }
    }
}
