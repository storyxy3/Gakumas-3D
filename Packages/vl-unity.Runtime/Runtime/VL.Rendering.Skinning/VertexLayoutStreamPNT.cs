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
                return position;
            }

            set
            {
                position = value;
            }
        }

        public void MultiplySkinMatrix(float4x4 blendedMatrix)
        {
            position = math.mul(blendedMatrix, new float4(position, 1f)).xyz;
            normal = math.mul(blendedMatrix, new float4(normal, 0f)).xyz;
            tangent.xyz = math.mul(blendedMatrix, new float4(tangent.xyz, 0f)).xyz;
        }
    }
}
