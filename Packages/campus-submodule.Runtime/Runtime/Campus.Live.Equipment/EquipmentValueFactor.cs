namespace Campus.Live.Equipment
{
    using global::System;
    using global::Campus.Live.Equipment;

    [Serializable]
    public struct EquipmentValueFactor
    {
        public float v0;
        public float v1;
        public float v2;
        public float v3;
        public EquipmentValueFactor(EquipmentValueFlags reverseFlags)
        {
            v0 = reverseFlags.v0 ? -1f : 1f;
            v1 = reverseFlags.v1 ? -1f : 1f;
            v2 = reverseFlags.v2 ? -1f : 1f;
            v3 = reverseFlags.v3 ? -1f : 1f;
        }
    }
}
