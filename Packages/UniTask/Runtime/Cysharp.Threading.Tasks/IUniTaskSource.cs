namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    public interface IUniTaskSource : IValueTaskSource
    {
        new UniTaskStatus GetStatus(short token);
        void OnCompleted(Action<object> continuation, object state, short token);
        new void GetResult(short token);
        UniTaskStatus UnsafeGetStatus();
        ValueTaskSourceStatus System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(short token)
        {
            return default(ValueTaskSourceStatus);
        }

        void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token)
        {
        }

        void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
        {
        }
    }
}
