namespace CriWare
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<uint> _003C_003E9__3_0;
            public static Func<uint> _003C_003E9__3_1;
            public static Func<uint> _003C_003E9__3_2;
            public _003C_003Ec()
            {
            }

            internal uint _003C_002Ector_003Eb__3_0()
            {
                return default(uint);
            }

            internal uint _003C_002Ector_003Eb__3_1()
            {
                return default(uint);
            }

            internal uint _003C_002Ector_003Eb__3_2()
            {
                return default(uint);
            }
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
