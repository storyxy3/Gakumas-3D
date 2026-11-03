namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.UI;
    using global::UnityEngine;

    public class TransitionTreeSetting : ScriptableObject
    {
        [Serializable]
        public class Node
        {
            [SerializeReference]
            public IWindowNodeState state;
            [SerializeReference]
            public TransitionParam param;
            [SerializeReference]
            public List<Node> children;
            public Node()
            {
            }
        }

        [SerializeReference]
        public List<Node> children;
        public TransitionTree GetTree()
        {
            return null;
        }

        private TransitionNode ParseNode(Node n)
        {
            return null;
        }

        protected virtual TransitionParam GetParam(Node n)
        {
            return null;
        }

        public TransitionTreeSetting()
        {
        }
    }
}
