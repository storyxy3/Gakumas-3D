namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Cysharp.Threading.Tasks;

    public readonly struct YieldAwaitable
    {
        public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private readonly PlayerLoopTiming timing;
            public bool IsCompleted
            {
                get
                {
                    return default(bool);
                }
            }

            public Awaiter(PlayerLoopTiming timing)
            {
                this = default;
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
        }

        private readonly PlayerLoopTiming timing;
        public YieldAwaitable(PlayerLoopTiming timing)
        {
            this = default;
        }

        public Awaiter GetAwaiter()
        {
            return default(Awaiter);
        }
    }
}
