namespace Campus.Live.Equipment
{
    using global::System;

    [Flags]
    public enum EquipmentValueType
    {
        None = 0,
        Position = 1,
        Transform = 1,
        Intensity = 0x10,
        Color = 0x20,
        Bpm = 0x40,
        Yow = 0x80,
        Pitch = 0x100,
        V2 = 0x200,
        V3 = 0x400,
        Rotate = 0x800,
        RotateIgnoreInitialRoll = 0x1000,
        Everything = -1
    }
}
