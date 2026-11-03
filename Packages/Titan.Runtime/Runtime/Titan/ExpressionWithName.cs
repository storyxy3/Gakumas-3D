namespace Titan
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ExpressionWithName
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private string _expression;
        public string Name
        {
            get
            {
                return null;
            }
        }

        public string Expression
        {
            get
            {
                return null;
            }
        }

        public ExpressionWithName()
        {
        }
    }
}
