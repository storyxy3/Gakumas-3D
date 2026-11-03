namespace Uguiss
{
    using global::System.Collections.Generic;
    using global::Uguiss;
    using global::UnityEngine;

    public class CommandSetting : ScriptableObject
    {
        [SerializeField]
        private List<CommandInfo> _commands;
        [SerializeField]
        private List<CommandAlias> _aliasList;
        [SerializeField]
        private CommandAlias _nothingAlias;
        public List<CommandInfo> Commands
        {
            get
            {
                return null;
            }
        }

        public List<CommandAlias> AliasList
        {
            get
            {
                return null;
            }
        }

        public CommandAlias NothingAlias
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public AbstractCommand CreateCommand(string commandName)
        {
            return null;
        }

        public CommandAlias GetCommandAlias(string commandStr)
        {
            return null;
        }

        public CommandSetting()
        {
        }
    }
}
