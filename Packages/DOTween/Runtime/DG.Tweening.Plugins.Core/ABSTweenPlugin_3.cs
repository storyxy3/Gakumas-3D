namespace DG.Tweening.Plugins.Core
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;

    public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin where TPlugOptions : struct, IPlugOptions
    {
        public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t);
        public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
        public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value);
        public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t);
        public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t);
        public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
        public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
        protected ABSTweenPlugin()
        {
        }
    }
}
