namespace Uguiss
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class CommandInfo
    {
        [SerializeField]
        private string _category;
        [SerializeField]
        private string _name;
        [SerializeField]
        private string _typeString;
        private Type _type;
        public string Name
        {
            get
            {
                return null;
            }
        }

        public string TypeString
        {
            get
            {
                return null;
            }
        }

        public Type Type
        {
            get
            {
                return null;
            }
        }

        public CommandInfo()
        {
        }
    }
}
