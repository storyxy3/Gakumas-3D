namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public class BlockingPresenterBase : QuaUIBehaviour, IBlockingPresenter
    {
        public virtual void Initialize()
        {
        }

        public virtual void SetCamera(Camera blockingCamera)
        {
        }

        public virtual void SetDepth(int depth)
        {
        }

        public virtual void ShowBlocking()
        {
        }

        public virtual void HideBlocking()
        {
        }

        public BlockingPresenterBase()
        {
        }
    }
}
