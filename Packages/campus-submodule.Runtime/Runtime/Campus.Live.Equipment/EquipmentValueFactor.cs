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
            this = default;
        }
    }
}
