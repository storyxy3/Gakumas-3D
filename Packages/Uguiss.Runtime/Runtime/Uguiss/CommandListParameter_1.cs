namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::Uguiss;

    public class CommandListParameter<T> : CommandListParameter where T : AbstractCommand
    {
        public List<T> GetCommandList()
        {
            return null;
        }

        public CommandListParameter()
        {
        }
    }
}
