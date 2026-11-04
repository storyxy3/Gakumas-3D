// TODO(qa-recon): CreateBoxMesh uses the recovered index bytes, but the metadata postprocessor renames PrivateImplementationDetails; the raw semantic flag remains open.
namespace VL
{
    using global::System.Runtime.InteropServices;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::UnityEngine.Rendering;
    using global::UnityEngine;

    public static class VLMeshUtility
    {
        public static readonly int g_FirstVert = Shader.PropertyToID("g_FirstVert");
        public static readonly int g_VertCount = Shader.PropertyToID("g_VertCount");
        public static readonly int g_Weight = Shader.PropertyToID("g_Weight");
        public static readonly int inVertices = Shader.PropertyToID("inVertices");
        public static readonly int inoutVertices = Shader.PropertyToID("inoutVertices");
        public static readonly int inSkins = Shader.PropertyToID("inSkins");
        public static readonly int inMatrices = Shader.PropertyToID("inMatrices");
        public static readonly int inBlendShapeVertices = Shader.PropertyToID("inBlendShapeVertices");
        public static uint PackWeightAndIndex(float weight, int index)
        {
            return (uint)((ushort)index | ((ushort)(weight * 65535f) << 16));
        }

        public static unsafe Mesh CopyMesh(Mesh srcMesh, [Optional] NativeSlice<byte> vertexBuffer0)
        {
            var mesh = new Mesh { name = srcMesh.name + "_Copy" };
            using (var readOnly = Mesh.AcquireReadOnlyMeshData(srcMesh))
            {
                var source = readOnly[0];
                var writable = Mesh.AllocateWritableMeshData(1);
                var destination = writable[0];
                var attributes = new NativeArray<VertexAttributeDescriptor>(srcMesh.vertexAttributeCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
                for (int i = 0; i < attributes.Length; i++) attributes[i] = srcMesh.GetVertexAttribute(i);
                destination.SetVertexBufferParams(source.vertexCount, attributes);
                for (int i = 0; i < source.vertexBufferCount; i++)
                {
                    var src = source.GetVertexData<byte>(i);
                    var dst = destination.GetVertexData<byte>(i);
                    int stride = source.GetVertexBufferStride(i);
                    UnsafeUtility.MemCpy(dst.GetUnsafePtr(), src.GetUnsafeReadOnlyPtr(), source.vertexCount * stride);
                    if (i == 0 && vertexBuffer0.Length == src.Length)
                        UnsafeUtility.MemCpy(vertexBuffer0.GetUnsafePtr(), src.GetUnsafeReadOnlyPtr(), source.vertexCount * stride);
                }
                var indices = source.GetIndexData<ushort>();
                destination.SetIndexBufferParams(indices.Length, source.indexFormat);
                var targetIndices = destination.GetIndexData<ushort>();
                UnsafeUtility.MemCpy(targetIndices.GetUnsafePtr(), indices.GetUnsafeReadOnlyPtr(), indices.Length * 2);
                attributes.Dispose();
                destination.subMeshCount = source.subMeshCount;
                for (int i = 0; i < source.subMeshCount; i++) destination.SetSubMesh(i, source.GetSubMesh(i));
                Mesh.ApplyAndDisposeWritableMeshData(writable, mesh);
                mesh.bounds = srcMesh.bounds;
                mesh.bindposes = srcMesh.bindposes;
                mesh.SetBoneWeights(srcMesh.GetBonesPerVertex(), srcMesh.GetAllBoneWeights());
            }
            return mesh;
        }

        public static Mesh CreateBoxMesh()
        {
            var vertices = new[]
            {
                new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f),
                new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f),
                new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f),
                new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f)
            };
            var indices = new[] { 0, 1, 2, 0, 2, 3, 1, 6, 2, 1, 5, 6, 3, 4, 0, 3, 7, 4, 0, 5, 1, 0, 4, 5, 2, 6, 7, 2, 7, 3, 5, 4, 7, 5, 7, 6 };
            var mesh = new Mesh { hideFlags = (HideFlags)52, indexFormat = IndexFormat.UInt16, vertices = vertices, triangles = indices };
            mesh.Optimize();
            mesh.UploadMeshData(true);
            return mesh;
        }
    }
}
