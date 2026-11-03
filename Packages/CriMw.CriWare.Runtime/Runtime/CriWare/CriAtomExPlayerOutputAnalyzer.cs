namespace CriWare
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::CriWare;

    [Obsolete("Use CriWare.CriAtomExOutputAnalyzer")]
    public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer
    {
        public enum Type
        {
            LevelMeter,
            SpectrumAnalyzer,
            PcmCapture
        }

        public new struct Config
        {
            public int num_spectrum_analyzer_bands;
            public int num_stored_output_data;
            public Config(int num_spectrum_analyzer_bands = 8, int num_stored_output_data = 4096)
            {
                this = default;
            }
        }

        public CriAtomExPlayerOutputAnalyzer(Type[] types, [Optional] Config[] configs)
        {
        }
    }
}
