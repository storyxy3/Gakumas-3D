namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;

    public class TransitionInfo
    {
        [CompilerGenerated]
        private int _003CCloseCount_003Ek__BackingField;
        [CompilerGenerated]
        private IWindowNodeState _003CStateForClose_003Ek__BackingField;
        [CompilerGenerated]
        private IWindowNodeState _003CStartTopNodeState_003Ek__BackingField;
        [CompilerGenerated]
        private WindowNode _003CStartTopNode_003Ek__BackingField;
        [CompilerGenerated]
        private IWindowNodeState _003CStartTopScreenState_003Ek__BackingField;
        [CompilerGenerated]
        private ScreenPresenterBase _003CStartTopScreen_003Ek__BackingField;
        [CompilerGenerated]
        private TransitionTree _003CTree_003Ek__BackingField;
        [CompilerGenerated]
        private TransitionOptionalData _003COptionalData_003Ek__BackingField;
        public int CloseCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        public IWindowNodeState StateForClose
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        private IWindowNodeState StartTopNodeState
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public WindowNode StartTopNode
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public IWindowNodeState StartTopScreenState
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public ScreenPresenterBase StartTopScreen
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public TransitionTree Tree
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            internal set
            {
            }
        }

        public TransitionOptionalData OptionalData
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool WillOpen
        {
            get
            {
                return default(bool);
            }
        }

        public bool WillClose
        {
            get
            {
                return default(bool);
            }
        }

        internal TransitionInfo()
        {
        }

        internal void SetStartNodeInfo(WindowPresenterBase startWindow)
        {
        }
    }
}
