namespace ActorAnimation
{
    using global::System;

    [Serializable]
    [Flags]
    public enum ActorSwingJobCollisionMask
    {
        None = 0,
        Skirt0 = 1,
        Skirt1 = 2,
        Skirt2 = 4,
        Hair0 = 8,
        Hair1 = 0x10,
        Hair2 = 0x20,
        Hair3 = 0x10000,
        Hair4 = 0x20000,
        Hair5 = 0x40000,
        Hair6 = 0x80000,
        Hair7 = 0x100000,
        Tops0 = 0x40,
        Tops1 = 0x80,
        Custm0 = 0x100,
        Custm1 = 0x200,
        Custm2 = 0x400,
        Custm3 = 0x800,
        Custm4 = 0x1000,
        Custm5 = 0x2000,
        Custm6 = 0x4000,
        Custm7 = 0x8000,
        Everything = -1
    }
}
