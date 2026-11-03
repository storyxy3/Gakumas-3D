namespace DG.Tweening.Plugins
{
    using global::System.Collections.Generic;
    using global::System.Text;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Options;

    public class StringPlugin : ABSTweenPlugin<string, string, StringOptions>
    {
        private static readonly StringBuilder _Buffer;
        private static readonly List<char> _OpenedTags;
        public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative)
        {
        }

        public override void Reset(TweenerCore<string, string, StringOptions> t)
        {
        }

        public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value)
        {
            return null;
        }

        public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<string, string, StringOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled)
        {
            return null;
        }

        private char[] ScrambledCharsToUse(StringOptions options)
        {
            return null;
        }

        public StringPlugin()
        {
        }
    }
}
