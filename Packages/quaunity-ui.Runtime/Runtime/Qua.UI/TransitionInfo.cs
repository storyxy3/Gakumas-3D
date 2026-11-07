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
                return _003CCloseCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CCloseCount_003Ek__BackingField = value;
            }
        }

        public IWindowNodeState StateForClose
        {
            [CompilerGenerated]
            get
            {
                return _003CStateForClose_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CStateForClose_003Ek__BackingField = value;
            }
        }

        private IWindowNodeState StartTopNodeState
        {
            [CompilerGenerated]
            set
            {
                _003CStartTopNodeState_003Ek__BackingField = value;
            }
        }

        public WindowNode StartTopNode
        {
            [CompilerGenerated]
            get
            {
                return _003CStartTopNode_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CStartTopNode_003Ek__BackingField = value;
            }
        }

        public IWindowNodeState StartTopScreenState
        {
            [CompilerGenerated]
            get
            {
                return _003CStartTopScreenState_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CStartTopScreenState_003Ek__BackingField = value;
            }
        }

        public ScreenPresenterBase StartTopScreen
        {
            [CompilerGenerated]
            get
            {
                return _003CStartTopScreen_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CStartTopScreen_003Ek__BackingField = value;
            }
        }

        public TransitionTree Tree
        {
            [CompilerGenerated]
            get
            {
                return _003CTree_003Ek__BackingField;
            }

            [CompilerGenerated]
            internal set
            {
                _003CTree_003Ek__BackingField = value;
            }
        }

        public TransitionOptionalData OptionalData
        {
            [CompilerGenerated]
            get
            {
                return _003COptionalData_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COptionalData_003Ek__BackingField = value;
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
