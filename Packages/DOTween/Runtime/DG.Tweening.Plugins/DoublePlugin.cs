namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;

    public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions>
    {
        public override void Reset(TweenerCore<double, double, NoOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative)
        {
        }

        public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value)
        {
            return default(double);
        }

        public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<double, double, NoOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public DoublePlugin()
        {
        }
    }
}
