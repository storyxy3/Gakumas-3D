namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class BlockingPresenterBase<TView, TBoardPresenter, TBoardView> : BlockingPresenterBase, IBlockingPresenter where TView : BlockingViewBase where TBoardPresenter : BlockingBoardPresenterBase<TBoardView> where TBoardView : BlockingBoardViewBase
    {
        [SerializeField]
        protected TView _view;
        [SerializeField]
        protected TBoardPresenter _blockingBoardPresenter;
        [CompilerGenerated]
        private Action _003COnClickedCallback_003Ek__BackingField;
        public Action OnClickedCallback
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

        public override void Initialize()
        {
        }

        public override void SetDepth(int depth)
        {
        }

        public override void ShowBlocking()
        {
        }

        public override void HideBlocking()
        {
        }

        protected void OnClicked()
        {
        }

        public BlockingPresenterBase()
        {
        }
    }
}
