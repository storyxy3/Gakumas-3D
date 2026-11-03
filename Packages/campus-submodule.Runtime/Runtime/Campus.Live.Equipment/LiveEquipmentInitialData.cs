namespace Campus.Live.Equipment
{
    using global::System;
    using global::Unity.Mathematics;

    [Serializable]
    public struct LiveEquipmentInitialData
    {
        public int count;
        public float3 position;
        public float4 v0;
        public float4 v1;
        public int4 valueInt;
    }
}
