namespace VL.Rendering.Skinning
{
    using global::Unity.Collections;
    using global::Unity.Mathematics;

    public interface ISkinning
    {
        float4x4 GetBlendedSkinMatrix(ref NativeArray<float4x4> matricesArray);
    }
}
