namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions>
    {
        public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative)
        {
        }

        public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value)
        {
            return default(Vector4);
        }

        public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public Vector4Plugin()
        {
        }
    }
}
