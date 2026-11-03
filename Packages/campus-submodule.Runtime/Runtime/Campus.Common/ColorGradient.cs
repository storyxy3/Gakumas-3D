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
                return default(float);
            }
        }

        public override Color Evaluate(float time)
        {
            return default(Color);
        }
    }
}
