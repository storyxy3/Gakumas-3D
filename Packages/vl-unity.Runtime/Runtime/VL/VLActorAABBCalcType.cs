namespace VL
{
    using global::System;

    [Flags]
    public enum VLActorAABBCalcType
    {
        None = 0,
        Default = 3,
        Local = 1,
        Bone = 2
    }
}
