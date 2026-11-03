namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    public struct SwitchToThreadPoolAwaitable
    {
        public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private static readonly WaitCallback switchToCallback;
            public bool IsCompleted
            {
                get
                {
                    return default(bool);
                }
            }

            public void GetResult()
            {
            }

            public void OnCompleted(Action continuation)
            {
            }

            public void UnsafeOnCompleted(Action continuation)
            {
            }

            private static void Callback(object state)
            {
            }
        }

        public Awaiter GetAwaiter()
        {
            return default(Awaiter);
        }
    }
}
