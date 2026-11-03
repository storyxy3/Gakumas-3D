namespace Campus.Common
{
    using global::Campus.Common;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class ThreadPriorityManager : Singleton<ThreadPriorityManager>
    {
        public enum PriorityLayer
        {
            Loading,
            Function
        }

        private const ThreadPriority DefaultPriority = ThreadPriority.BelowNormal;
        private ThreadPriority? [] _layerPriorities;
        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        protected override void OnInitialize()
        {
        }

        public bool SetPriority(PriorityLayer layer, ThreadPriority priority)
        {
            return default(bool);
        }

        public ThreadPriority ResetPriority(PriorityLayer layer)
        {
            return default(ThreadPriority);
        }

        private void ApplyPriority()
        {
        }

        public ThreadPriorityManager()
        {
        }
    }
}
