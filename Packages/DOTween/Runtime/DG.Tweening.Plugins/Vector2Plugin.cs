namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions>
    {
        public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative)
        {
        }

        public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value)
        {
            return default(Vector2);
        }

        public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public Vector2Plugin()
        {
        }
    }
}
