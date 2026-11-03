namespace Uguiss.Timeline
{
    using global::System;

    [Flags]
    public enum ClipCaps
    {
        None = 0,
        Looping = 1,
        ClipIn = 2,
        SpeedMultiplier = 4,
        Blending = 8,
        All = -1
    }
}
