namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>
    {
        public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative)
        {
        }

        public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value)
        {
            return default(Vector3);
        }

        public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public QuaternionPlugin()
        {
        }
    }
}
