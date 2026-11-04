namespace Campus.Crowd
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public static class CrowdUtility
    {
        public static readonly VertexAttributeDescriptor[] VertexAttributeDescriptors =
        {
            new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3, 0),
            new VertexAttributeDescriptor(VertexAttribute.Normal, VertexAttributeFormat.Float32, 3, 0),
            new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.UNorm8, 4, 1),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float16, 2, 1),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord3, VertexAttributeFormat.UInt32, 4, 3),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord4, VertexAttributeFormat.Float32, 3, 2)
        };
        public static readonly VertexAttributeDescriptor[] PenlightVertexAttributeDescriptors =
        {
            new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3, 0),
            new VertexAttributeDescriptor(VertexAttribute.Normal, VertexAttributeFormat.Float32, 3, 0),
            new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.UNorm8, 4, 1),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float16, 2, 1)
        };
        public static void GetCellFromOctreeAddress(int address, out int x, out int y, out int z)
        {
            x = _003CGetCellFromOctreeAddress_003Eg__BitOffset_007C17_0(address);
            y = _003CGetCellFromOctreeAddress_003Eg__BitOffset_007C17_0(address >> 1);
            z = _003CGetCellFromOctreeAddress_003Eg__BitOffset_007C17_0(address >> 2);
        }

        public static Bounds GetCellBounds(Bounds aabb, int address, Vector4 boundingSphere)
        {
            GetCellFromOctreeAddress(address, out int x, out int y, out int z);
            var size = aabb.size / 16f;
            var center = aabb.min + Vector3.Scale(size, new Vector3(x + 0.5f, y + 0.5f, z + 0.5f)) + (Vector3)boundingSphere;
            var bounds = new Bounds(center, size);
            bounds.Expand(boundingSphere.w * 4f);
            return bounds;
        }

        [CompilerGenerated]
        internal static int _003CGetCellFromOctreeAddress_003Eg__BitOffset_007C17_0(int bit)
        {
            return (bit & 1) | ((bit >> 2) & 2) | ((bit >> 4) & 4) | ((bit >> 6) & 8);
        }
    }
}
