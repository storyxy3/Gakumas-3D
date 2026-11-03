namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
    {
        public override void Reset(TweenerCore<Rect, Rect, RectOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative)
        {
        }

        public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value)
        {
            return default(Rect);
        }

        public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public RectPlugin()
        {
        }
    }
}
