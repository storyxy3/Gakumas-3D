namespace DG.Tweening.Core
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;

    public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct, IPlugOptions
    {
        public T2 startValue;
        public T2 endValue;
        public T2 changeValue;
        public TPlugOptions plugOptions;
        public DOGetter<T1> getter;
        public DOSetter<T1> setter;
        internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
        private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";
        internal TweenerCore()
        {
        }

        public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue)
        {
            return null;
        }

        public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false)
        {
            return null;
        }

        public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f)
        {
            return null;
        }

        public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f, bool snapStartValue = false)
        {
            return null;
        }

        internal override Tweener SetFrom(bool relative)
        {
            return null;
        }

        internal sealed override void Reset()
        {
        }

        internal override float UpdateDelay(float elapsed)
        {
            return default(float);
        }

        internal override bool Startup()
        {
            return default(bool);
        }

        internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
        {
            return default(bool);
        }
    }
}
