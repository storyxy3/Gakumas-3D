namespace CriWare
{
    using global::System;
    using global::Unity.Profiling;

    internal class CriWareMemoryReporter
    {
        private ProfilerCounterValue<uint> profilerCounter;
        private Func<uint> updateFunc;
        public CriWareMemoryReporter(string profilerLabel, Func<uint> profileUpdateFunc)
        {
        }

        public uint UpdateValue()
        {
            return default(uint);
        }

        public void UpdateValue(uint value)
        {
        }
    }
}
