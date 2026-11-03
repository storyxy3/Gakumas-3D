namespace CriWare
{
    using global::System.Collections.Generic;
    using global::CriWare;

    internal class CriWareProfilerReporter
    {
        public enum TargetReporterName
        {
            Atom,
            Mana,
            Fs,
            Total
        }

        private List<CriWareMemoryReporter> memoryReporters;
        private CriWareMemoryReporter totalReporter;
        public CriWareProfilerReporter()
        {
        }

        public void UpdateMeasure()
        {
        }
    }
}
