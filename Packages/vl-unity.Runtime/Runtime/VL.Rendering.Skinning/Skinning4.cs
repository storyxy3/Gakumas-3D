namespace VL.Rendering.Skinning
{
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::VL.Rendering.Skinning;

    public struct Skinning4 : ISkinning
    {
        public uint4 skin;
        public float4x4 GetBlendedSkinMatrix(ref NativeArray<float4x4> matricesArray)
        {
            uint4 indices = skin & 65535;
            float4 weights = (float4)(skin >> 16) * (1f / 65535f);
            return matricesArray[(int)indices.x] * weights.x + matricesArray[(int)indices.y] * weights.y
                + matricesArray[(int)indices.z] * weights.z + matricesArray[(int)indices.w] * weights.w;
        }
    }
}
