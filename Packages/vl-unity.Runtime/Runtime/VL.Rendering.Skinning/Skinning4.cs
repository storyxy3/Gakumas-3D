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
            return default(float4x4);
        }
    }
}
