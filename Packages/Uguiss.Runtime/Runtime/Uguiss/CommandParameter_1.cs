namespace Uguiss
{
    using global::Uguiss;

    public class CommandParameter<T> : CommandParameter where T : AbstractCommand
    {
        public T GetCommand()
        {
            return null;
        }

        public CommandParameter()
        {
        }
    }
}
