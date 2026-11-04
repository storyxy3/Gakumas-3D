namespace VL.ActorMesh
{
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    public class VLActorSkinningSystem : VLSkinningSystem<VertexLayoutStreamPNT, Skinning4>
    {
        public static readonly VertexAttributeDescriptor[] VertexAttributeDescriptors =
        {
            new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3, 0),
            new VertexAttributeDescriptor(VertexAttribute.Normal, VertexAttributeFormat.Float32, 3, 0),
            new VertexAttributeDescriptor(VertexAttribute.Tangent, VertexAttributeFormat.Float32, 4, 0),
            new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.UNorm8, 4, 1),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float16, 2, 1),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord1, VertexAttributeFormat.Float16, 2, 1),
            new VertexAttributeDescriptor(VertexAttribute.TexCoord4, VertexAttributeFormat.Float32, 3, 2)
        };
        public VLActorSkinningSystem(Transform parent, Mesh sourceMesh, Transform rootBone, Transform[] bones, Matrix4x4[] bindposes, uint[] boneWeightAndIndices, Bounds localBounds, Material[] materials, uint renderingLayerMask, [Optional] BlendShapeData[] blendShapes) : base(parent, sourceMesh, rootBone, bones, bindposes, boneWeightAndIndices, localBounds, materials, renderingLayerMask, blendShapes)
        {
        }
    }
}
