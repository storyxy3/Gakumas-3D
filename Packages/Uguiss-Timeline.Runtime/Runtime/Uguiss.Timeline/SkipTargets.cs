namespace Uguiss.Timeline
{
    using global::System;

    [Flags]
    public enum SkipTargets
    {
        None = 0,
        ClipIn = 1,
        Duration = 2,
        ClipOut = 4,
        ClipInOut = 5,
        All = 7
    }
}
