namespace Uguiss.Timeline
{
    using global::System;

    [Flags]
    public enum GetTimeOptions
    {
        None = 0,
        Wait = 1,
        Offset = 2,
        WaitAndOffset = 3
    }
}
