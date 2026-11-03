namespace DG.Tweening.Core
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Options;

    public static class Extensions
    {
        public static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode)
            where T : Tween
        {
            return null;
        }

        public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
            where TPlugOptions : struct, IPlugOptions
        {
            return null;
        }
    }
}
