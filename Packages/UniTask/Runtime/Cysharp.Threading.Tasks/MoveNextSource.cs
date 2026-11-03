namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    public abstract class MoveNextSource : IUniTaskSource<bool>, IUniTaskSource, IValueTaskSource, IValueTaskSource<bool>
    {
        protected UniTaskCompletionSourceCore<bool> completionSource;
        public bool GetResult(short token)
        {
            return default(bool);
        }

        public UniTaskStatus GetStatus(short token)
        {
            return default(UniTaskStatus);
        }

        public void OnCompleted(Action<object> continuation, object state, short token)
        {
        }

        public UniTaskStatus UnsafeGetStatus()
        {
            return default(UniTaskStatus);
        }

        void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
        {
        }

        protected MoveNextSource()
        {
        }
    }
}
