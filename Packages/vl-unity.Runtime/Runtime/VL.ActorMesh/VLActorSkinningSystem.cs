namespace VL.ActorMesh
{
    using global::System.Runtime.InteropServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    public class VLActorSkinningSystem : VLSkinningSystem<VertexLayoutStreamPNT, Skinning4>
    {
        public static readonly VertexAttributeDescriptor[] VertexAttributeDescriptors;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public VLActorSkinningSystem(Transform parent, Mesh sourceMesh, Transform rootBone, Transform[] bones, Matrix4x4[] bindposes, uint[] boneWeightAndIndices, Bounds localBounds, Material[] materials, uint renderingLayerMask, [Optional] BlendShapeData[] blendShapes) : base(default, default, default, default, default, default, default, default, default)
        {
        }
    }
}
