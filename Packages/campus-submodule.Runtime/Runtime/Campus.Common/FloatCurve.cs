namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public class FloatCurve : ConstantCurveValueBase<float, AnimationCurve>
    {
        public override float Duration
        {
            get
            {
                return default(float);
            }
        }

        public FloatCurve(float f)
        {
        }

        [MethodImpl(256)]
        public override float Evaluate(float time)
        {
            return default(float);
        }
    }
}
