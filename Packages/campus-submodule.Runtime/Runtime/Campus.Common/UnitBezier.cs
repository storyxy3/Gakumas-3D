namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::DG.Tweening;

    public struct UnitBezier
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0
        {
            public UnitBezier bezier;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal float _003CToEaseFunction_003Eb__0(float time, float duration, float overshootOrAmplitude, float period)
            {
                return default(float);
            }
        }

        private double _ax;
        private double _bx;
        private double _cx;
        private double _ay;
        private double _by;
        private double _cy;
        public UnitBezier(double p1x, double p1y, double p2x, double p2y)
        {
            this = default;
        }

        private double SampleCurveX(double t)
        {
            return default(double);
        }

        private double SampleCurveY(double t)
        {
            return default(double);
        }

        private double SampleCurveDerivativeX(double t)
        {
            return default(double);
        }

        private double SolveCurveX(double x, double epsilon)
        {
            return default(double);
        }

        public double Solve(double x, double epsilon)
        {
            return default(double);
        }

        public EaseFunction ToEaseFunction()
        {
            return null;
        }

        private static double GetEpsilon(double duration)
        {
            return default(double);
        }
    }
}
