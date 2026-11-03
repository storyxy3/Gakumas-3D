namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    public interface IUniTaskSource<out T> : IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
    {
        new T GetResult(short token);
        new UniTaskStatus GetStatus(short token)
        {
            return default(UniTaskStatus);
        }

        new void OnCompleted(Action<object> continuation, object state, short token)
        {
        }

        ValueTaskSourceStatus System.Threading.Tasks.Sources.IValueTaskSource<T>.GetStatus(short token)
        {
            return default(ValueTaskSourceStatus);
        }

        T System.Threading.Tasks.Sources.IValueTaskSource<T>.GetResult(short token)
        {
            return default(T);
        }

        void System.Threading.Tasks.Sources.IValueTaskSource<T>.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
        {
        }
    }
}
