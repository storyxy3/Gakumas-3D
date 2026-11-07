namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;

    public static class TF
    {
        [CompilerGenerated]
        private static IDefaultStateProvider _003CDefaultProvider_003Ek__BackingField;
        public static IDefaultStateProvider DefaultProvider
        {
            [CompilerGenerated]
            private get
            {
                return _003CDefaultProvider_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CDefaultProvider_003Ek__BackingField = value;
            }
        }

        public static TransitionTree Tree(IWindowNodeState state)
        {
            return null;
        }

        public static TransitionTree Tree(IWindowNodeState state, TransitionParam param)
        {
            return null;
        }

        public static TransitionTree Tree(params TransitionNode[] children)
        {
            return null;
        }

        public static TransitionNode Node(IWindowNodeState state, params TransitionNode[] children)
        {
            return null;
        }

        public static TransitionNode Node(IWindowNodeState state, TransitionParam param, params TransitionNode[] children)
        {
            return null;
        }
    }
}
