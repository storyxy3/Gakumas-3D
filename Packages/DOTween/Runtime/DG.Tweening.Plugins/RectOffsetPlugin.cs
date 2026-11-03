namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
    {
        private static RectOffset _r;
        public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative)
        {
        }

        public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value)
        {
            return null;
        }

        public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public RectOffsetPlugin()
        {
        }
    }
}
