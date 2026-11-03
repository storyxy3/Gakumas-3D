namespace CriWare
{
    using global::System;
    using global::Unity.Profiling;

    internal struct CriDurationMeasurementScope : IDisposable
    {
        private ProfilerMarker.AutoScope scope;
        public CriDurationMeasurementScope(string name)
        {
            this = default;
        }

        public void Dispose()
        {
        }
    }
}
