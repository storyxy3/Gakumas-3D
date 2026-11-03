namespace Uguiss
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class CommandAlias
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private string _command;
        [SerializeField]
        private string _parameter;
        public string Name
        {
            get
            {
                return null;
            }
        }

        public string Command
        {
            get
            {
                return null;
            }
        }

        public string Parameter
        {
            get
            {
                return null;
            }
        }

        public CommandAlias()
        {
        }
    }
}
