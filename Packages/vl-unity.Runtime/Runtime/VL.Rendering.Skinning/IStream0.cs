namespace VL.Rendering.Skinning
{
    using global::Unity.Mathematics;

    public interface IStream0
    {
        float3 Position { get; set; }

        void MultiplySkinMatrix(float4x4 matrix);
    }
}
