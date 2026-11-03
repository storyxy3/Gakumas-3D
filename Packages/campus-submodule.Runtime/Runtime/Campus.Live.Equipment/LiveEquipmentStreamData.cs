namespace Campus.Live.Equipment
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public struct LiveEquipmentStreamData
    {
        public float intensity;
        public Color color;
        public float time;
        public int4 valueInt;
        public float4 valueFloat;
        public float3 position;
        public float4 lightParam;
        public float4 rotationYaw;
        public float4 rotationPitch;
        public float4 rotationRoll;
    }
}
