namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    public struct SwitchToMainThreadAwaitable
    {
        public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private readonly PlayerLoopTiming playerLoopTiming;
            private readonly CancellationToken cancellationToken;
            public bool IsCompleted
            {
                get
                {
                    return default(bool);
                }
            }

            public Awaiter(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken)
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

        private readonly PlayerLoopTiming playerLoopTiming;
        private readonly CancellationToken cancellationToken;
        public SwitchToMainThreadAwaitable(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken)
        {
            this = default;
        }

        public Awaiter GetAwaiter()
        {
            return default(Awaiter);
        }
    }
}
