namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
    {
        public override void Reset(TweenerCore<Color, Color, ColorOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative)
        {
        }

        public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value)
        {
            return default(Color);
        }

        public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public ColorPlugin()
        {
        }
    }
}
