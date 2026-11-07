namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;

    public class TransitionParam
    {
        [CompilerGenerated]
        private bool _003CIsTopNode_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsLeafNode_003Ek__BackingField;
        public bool IsTopNode
        {
            [CompilerGenerated]
            get
            {
                return _003CIsTopNode_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CIsTopNode_003Ek__BackingField = value;
            }
        }

        internal bool IsLeafNode
        {
            [CompilerGenerated]
            set
            {
                _003CIsLeafNode_003Ek__BackingField = value;
            }
        }

        public TransitionParam()
        {
        }
    }
}
