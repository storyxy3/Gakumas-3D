namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public class SimpleBlockingManager : BlockingManagerBase<SimpleBlockingManager, SimpleBlockingEnum.SimpleBlockingType>
    {
        protected override Transform GetRoot(SimpleBlockingEnum.SimpleBlockingType blockingType)
        {
            return null;
        }

        public void ShowDisplayBlocking()
        {
        }

        public void HideDisplayBlocking()
        {
        }

        public SimpleBlockingManager()
        {
        }
    }
}
