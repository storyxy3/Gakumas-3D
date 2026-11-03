namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public class BlockingBoardViewBase : QuaUIBehaviour
    {
        [SerializeField]
        protected Transform _blockingRoot;
        [SerializeField]
        protected ButtonBase _blockingButton;
        public ButtonBase BlockingButton
        {
            get
            {
                return null;
            }
        }

        public virtual void Initialize()
        {
        }

        public virtual void ShowBlocking()
        {
        }

        public virtual void HideBlocking()
        {
        }

        public BlockingBoardViewBase()
        {
        }
    }
}
