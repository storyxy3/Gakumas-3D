namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.UI;

    public class TransitionNode
    {
        [CompilerGenerated]
        private IWindowNodeState _003CState_003Ek__BackingField;
        [CompilerGenerated]
        private TransitionParam _003CParam_003Ek__BackingField;
        [CompilerGenerated]
        private TransitionNode[] _003CChildren_003Ek__BackingField;
        public IWindowNodeState State
        {
            [CompilerGenerated]
            get
            {
                return _003CState_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CState_003Ek__BackingField = value;
            }
        }

        public TransitionParam Param
        {
            [CompilerGenerated]
            get
            {
                return _003CParam_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CParam_003Ek__BackingField = value;
            }
        }

        public TransitionNode[] Children
        {
            [CompilerGenerated]
            get
            {
                return _003CChildren_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CChildren_003Ek__BackingField = value;
            }
        }

        private TransitionNode()
        {
        }

        internal static TransitionNode Create(IWindowNodeState state, [Optional] TransitionParam param, params TransitionNode[] children)
        {
            return null;
        }
    }
}
