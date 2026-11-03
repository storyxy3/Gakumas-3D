namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;

    public class LongPlugin : ABSTweenPlugin<long, long, NoOptions>
    {
        public override void Reset(TweenerCore<long, long, NoOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative)
        {
        }

        public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value)
        {
            return default(long);
        }

        public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<long, long, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public LongPlugin()
        {
        }
    }
}
