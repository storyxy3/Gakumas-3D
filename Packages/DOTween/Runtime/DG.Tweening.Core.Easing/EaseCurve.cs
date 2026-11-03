namespace DG.Tweening.Core.Easing
{
    using global::UnityEngine;

    public class EaseCurve
    {
        private readonly AnimationCurve _animCurve;
        public EaseCurve(AnimationCurve animCurve)
        {
        }

        public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
        {
            return default(float);
        }
    }
}
