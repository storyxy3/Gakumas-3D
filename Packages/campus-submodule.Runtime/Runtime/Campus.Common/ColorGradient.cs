namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public class ColorGradient : ConstantCurveValueBase<Color, Gradient>
    {
        public override float Duration
        {
            get
            {
                return 1f;
            }
        }

        public override Color Evaluate(float time)
        {
            switch (mode)
            {
                case ConstantCurvePairMode.Constant: return constant;
                case ConstantCurvePairMode.Curve: return curve.Evaluate(time);
                default: return Color.black;
            }
        }
    }
}
