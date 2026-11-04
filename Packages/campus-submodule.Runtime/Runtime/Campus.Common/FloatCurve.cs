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
                return mode == ConstantCurvePairMode.Constant || curve == null || curve.length == 0 ? 1f : curve[curve.length - 1].time;
            }
        }

        public FloatCurve(float f)
        {
            mode = ConstantCurvePairMode.Constant;
            constant = f;
            curve = new AnimationCurve();
            isValid = true;
        }

        [MethodImpl(256)]
        public override float Evaluate(float time)
        {
            switch (mode)
            {
                case ConstantCurvePairMode.Constant: return constant;
                case ConstantCurvePairMode.Curve: return curve.Evaluate(time);
                default: return -1f;
            }
        }
    }
}
