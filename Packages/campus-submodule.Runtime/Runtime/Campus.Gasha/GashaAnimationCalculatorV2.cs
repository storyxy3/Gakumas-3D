namespace Campus.Gasha
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::Campus.Gasha.Sequences;

    public static class GashaAnimationCalculatorV2
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<(GashaId gashaId, int weight), int> _003C_003E9__0_0;
            public _003C_003Ec()
            {
            }

            internal int _003CCalcurate_003Eb__0_0((GashaId gashaId, int weight) x)
            {
                return default(int);
            }
        }

        public static GashaId[] Calcurate(Dictionary<GashaId, List<(GashaId gashaId, int weight)>> animationGraph)
        {
            return null;
        }
    }
}
