namespace Cysharp.Threading.Tasks.Internal
{
    using global::Cysharp.Threading.Tasks.Internal;

    internal readonly struct ValueStopwatch
    {
        private static readonly double TimestampToTicks;
        private readonly long startTimestamp;
        public bool IsInvalid
        {
            get
            {
                return default(bool);
            }
        }

        public long ElapsedTicks
        {
            get
            {
                return default(long);
            }
        }

        public static ValueStopwatch StartNew()
        {
            return default(ValueStopwatch);
        }

        private ValueStopwatch(long startTimestamp)
        {
            this = default;
        }
    }
}
