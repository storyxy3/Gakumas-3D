namespace Campus.Crowd
{
    using global::System;
    using global::Unity.Mathematics;

    [Serializable]
    public struct PersonInfo
    {
        public uint flags;
        public float3 position;
        public float2 rotation;
        public float scale;
        public float intensity;
    }
}
