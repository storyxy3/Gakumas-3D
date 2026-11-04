// TODO(qa-recon): Execute still has an APK/native semantic flag around half packing and native-array metadata; exact emitted-code correspondence is unresolved (TASK_D_REPORT.md).
namespace VL.ActorMesh
{
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::Unity.Mathematics;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering.Skinning;

    public struct CombineMeshJob : IJob
    {
        private int _maxVertexCount;
        [ReadOnly]
        private Mesh.MeshDataArray _readMeshArray;
        private Mesh.MeshData _writeMesh;
        public void Execute()
        {
            using (var positions = new NativeArray<float3>(_maxVertexCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory))
            using (var normals = new NativeArray<float3>(_maxVertexCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory))
            using (var tangents = new NativeArray<float4>(_maxVertexCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory))
            using (var colors = new NativeArray<Color32>(_maxVertexCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory))
            using (var uv0 = new NativeArray<float2>(_maxVertexCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory))
            using (var uv1 = new NativeArray<float2>(_maxVertexCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory))
            {
                var stream0 = _writeMesh.GetVertexData<VertexLayoutStreamPNT>(0);
                var stream1 = _writeMesh.GetVertexData<VertexLayoutStream1>(1);
                var stream2 = _writeMesh.GetVertexData<VertexLayoutStream2>(2);
                var indices = _writeMesh.GetIndexData<ushort>();
                int vertexOffset = 0, indexOffset = 0, subMeshOffset = 0;
                for (int meshIndex = 0; meshIndex < _readMeshArray.Length; meshIndex++)
                {
                    var source = _readMeshArray[meshIndex];
                    source.GetVertices(positions.Reinterpret<Vector3>());
                    source.GetNormals(normals.Reinterpret<Vector3>());
                    bool hasTangents = source.HasVertexAttribute(VertexAttribute.Tangent);
                    if (hasTangents) source.GetTangents(tangents.Reinterpret<Vector4>());
                    source.GetColors(colors);
                    source.GetUVs(0, uv0.Reinterpret<Vector2>());
                    bool hasUv1 = source.HasVertexAttribute(VertexAttribute.TexCoord1);
                    if (hasUv1) source.GetUVs(1, uv1.Reinterpret<Vector2>());
                    for (int i = 0; i < source.vertexCount; i++)
                    {
                        // APK 0xe12ac5c copies tangent.x into both x and z, with w fixed to one.
                        var tangent = hasTangents ? new float4(tangents[i].x, tangents[i].y, tangents[i].x, 1f) : new float4(normals[i], 1f);
                        stream0[vertexOffset + i] = new VertexLayoutStreamPNT { position = positions[i], normal = normals[i], tangent = tangent };
                        stream1[vertexOffset + i] = new VertexLayoutStream1 { color = colors[i], texcoord0 = new half2(uv0[i]), texcoord1 = hasUv1 ? new half2(uv1[i]) : half2.zero };
                        stream2[vertexOffset + i] = new VertexLayoutStream2 { prevPosition = float3.zero };
                    }
                    var sourceIndices = source.GetIndexData<ushort>();
                    for (int i = 0; i < sourceIndices.Length; i++) indices[indexOffset + i] = (ushort)(sourceIndices[i] + vertexOffset);
                    for (int i = 0; i < source.subMeshCount; i++)
                    {
                        var subMesh = source.GetSubMesh(i);
                        _writeMesh.SetSubMesh(subMeshOffset + i, new SubMeshDescriptor(subMesh.indexStart + indexOffset, subMesh.indexCount), (MeshUpdateFlags)5);
                    }
                    indexOffset += sourceIndices.Length;
                    vertexOffset += source.vertexCount;
                    subMeshOffset += source.subMeshCount;
                }
            }
        }
    }
}
