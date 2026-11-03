namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    public static class CancellationTokenSourceExtensions
    {
        private static readonly Action<object> CancelCancellationTokenSourceStateDelegate;
        private static void CancelCancellationTokenSourceState(object state)
        {
        }

        public static IDisposable CancelAfterSlim(this CancellationTokenSource cts, int millisecondsDelay, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update)
        {
            return null;
        }

        public static IDisposable CancelAfterSlim(this CancellationTokenSource cts, TimeSpan delayTimeSpan, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update)
        {
            return null;
        }
    }
}
