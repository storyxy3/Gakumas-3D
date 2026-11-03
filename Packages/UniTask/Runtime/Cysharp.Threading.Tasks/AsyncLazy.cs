namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::Cysharp.Threading.Tasks;

    public class AsyncLazy
    {
        private static Action<object> continuation;
        private Func<UniTask> taskFactory;
        private UniTaskCompletionSource completionSource;
        private UniTask.Awaiter awaiter;
        private object syncLock;
        private bool initialized;
        public UniTask Task
        {
            get
            {
                return default(UniTask);
            }
        }

        public AsyncLazy(Func<UniTask> taskFactory)
        {
        }

        public UniTask.Awaiter GetAwaiter()
        {
            return default(UniTask.Awaiter);
        }

        private void EnsureInitialized()
        {
        }

        private void EnsureInitializedCore()
        {
        }

        private void SetCompletionSource(in UniTask.Awaiter awaiter)
        {
        }

        private static void SetCompletionSource(object state)
        {
        }
    }
}
