namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;

    internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions>
    {
        public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative)
        {
        }

        public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value)
        {
            return default(Color2);
        }

        public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public Color2Plugin()
        {
        }
    }
}
