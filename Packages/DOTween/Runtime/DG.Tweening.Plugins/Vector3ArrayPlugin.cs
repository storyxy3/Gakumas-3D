namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions>
    {
        public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative)
        {
        }

        public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value)
        {
            return null;
        }

        public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public Vector3ArrayPlugin()
        {
        }
    }
}
