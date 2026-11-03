namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;

    public class BlockingBoardPresenterBase<TBlockingBoardView> : QuaUIBehaviour where TBlockingBoardView : BlockingBoardViewBase
    {
        [SerializeField]
        protected TBlockingBoardView _view;
        public Action onClickedCallback;
        public virtual void Initialize()
        {
        }

        protected virtual void SetEvents()
        {
        }

        public virtual void ShowBlocking()
        {
        }

        public virtual void HideBlocking()
        {
        }

        protected void OnClicked()
        {
        }

        public BlockingBoardPresenterBase()
        {
        }
    }
}
