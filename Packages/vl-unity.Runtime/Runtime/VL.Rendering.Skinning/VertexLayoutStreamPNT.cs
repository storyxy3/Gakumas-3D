namespace VL.Rendering.Skinning
{
    using global::Unity.Mathematics;
    using global::VL.Rendering.Skinning;

    public struct VertexLayoutStreamPNT : IStream0
    {
        public float3 position;
        public float3 normal;
        public float4 tangent;
        public float3 Position
        {
            get
            {
                return default(float3);
            }

            set
            {
            }
        }

        public void MultiplySkinMatrix(float4x4 blendedMatrix)
        {
        }
    }
}
