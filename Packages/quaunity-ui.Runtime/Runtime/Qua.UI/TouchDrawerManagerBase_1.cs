namespace Qua.UI
{
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class TouchDrawerManagerBase<T> : Singleton<T> where T : TouchDrawerManagerBase<T>
    {
        [SerializeField]
        private TouchResultDrawer _touchResultDrawer;
        [SerializeField]
        private TouchRectDrawer _touchRectDrawer;
        public void SetTouchResultDrawerEnabled(bool enable)
        {
        }

        public void SetTouchResultDumpEnabled(bool enable)
        {
        }

        public void SetTouchRectDrawerEnabled(bool enable)
        {
        }

        public void AddExcludeCanvas(Canvas canvas)
        {
        }

        public void RemoveExcludeCanvas(Canvas canvas)
        {
        }

        public TouchDrawerManagerBase()
        {
        }
    }
}
