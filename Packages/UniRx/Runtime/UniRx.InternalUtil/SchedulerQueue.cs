namespace UniRx.InternalUtil
{
    using global::UniRx.InternalUtil;

    internal class SchedulerQueue
    {
        private readonly PriorityQueue<ScheduledItem> _queue;
        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public SchedulerQueue(int capacity)
        {
        }

        public void Enqueue(ScheduledItem scheduledItem)
        {
        }

        public ScheduledItem Dequeue()
        {
            return null;
        }
    }
}
