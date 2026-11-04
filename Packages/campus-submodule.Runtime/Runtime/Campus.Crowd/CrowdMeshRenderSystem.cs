namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CrowdMeshRenderSystem : IDisposable
    {
        private static readonly string SkinningKernel = "Skinning";
        private static readonly int VertexCountID = Shader.PropertyToID("_VertexCount");
        private static readonly int BoneCountID = Shader.PropertyToID("_BoneCount");
        private static readonly int InVerticesID = Shader.PropertyToID("_InVertices");
        private static readonly int InSkinsID = Shader.PropertyToID("_InSkins");
        private static readonly int InMatricesID = Shader.PropertyToID("_InMatrices");
        private static readonly int OutVerticesID = Shader.PropertyToID("_OutVertices");
        private static readonly int MeshInfoID = Shader.PropertyToID("_MeshInfo");
        private static readonly int HandMatricesID = Shader.PropertyToID("_HandMatrices");
        private static readonly ProfilingSampler CreateCrowdMeshRenderSystemSampler = new ProfilingSampler("CrowdMeshRenderSystem.Create");
        private static readonly int RenderGBufferPass = 2;
        private static readonly int RenderPreDepthPass = 3;
        private readonly CrowdModelData.MeshData _meshData;
        private readonly int _boneCount;
        private readonly int _rightHandBoneIndex;
        private readonly int _leftHandBoneIndex;
        private readonly Mesh _mesh;
        private readonly GraphicsBuffer _sourceVertexBuffer;
        private readonly GraphicsBuffer[] _vertexBuffers;
        private readonly Matrix4x4[] _handMatrices;
        private Matrix4x4 _rightHandRotateMatrix;
        private ComputeShader _computeShader;
        private int _skinningKernelIndex;
        [CompilerGenerated]
        private int _003CMaxInstanceCountsPerSubMesh_003Ek__BackingField;
        public Mesh Mesh
        {
            get
            {
                return _mesh;
            }
        }

        public CrowdModelData.SubMeshData[] SubMeshes
        {
            get
            {
                return _meshData?.subMeshes;
            }
        }

        public int MaxInstanceCountsPerSubMesh
        {
            [CompilerGenerated]
            get
            {
                return _003CMaxInstanceCountsPerSubMesh_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CMaxInstanceCountsPerSubMesh_003Ek__BackingField = value;
            }
        }

        public CrowdMeshRenderSystem(CrowdModelData modelData)
        {
            using (new ProfilingScope(null, CreateCrowdMeshRenderSystemSampler))
            {
                _meshData = modelData.crowdMeshData;
                _boneCount = modelData.Bones.Length;
                _rightHandBoneIndex = modelData.rightHandBoneIndex;
                _leftHandBoneIndex = modelData.leftHandBoneIndex;
                _mesh = global::VL.VLMeshUtility.CopyMesh(_meshData.mesh);
                _mesh.vertexBufferTarget |= GraphicsBuffer.Target.Raw;
                if (_mesh.vertexBufferCount != 4)
                {
                    Debug.LogError("頂点バッファのレイアウトが違います");
                    return;
                }
                _vertexBuffers = new GraphicsBuffer[4];
                for (int i = 0; i < _vertexBuffers.Length; i++) _vertexBuffers[i] = _mesh.GetVertexBuffer(i);
                _sourceVertexBuffer = new GraphicsBuffer(GraphicsBuffer.Target.Vertex | GraphicsBuffer.Target.CopyDestination | GraphicsBuffer.Target.Raw,
                    _mesh.vertexCount, _mesh.GetVertexBufferStride(0));
                Graphics.CopyBuffer(GetVertexBuffer((VertexStreamType)0), _sourceVertexBuffer);
                _handMatrices = new Matrix4x4[16];
                _rightHandRotateMatrix = Matrix4x4.Rotate(Quaternion.Euler(0f, 180f, 0f));
            }
        }

        public void SetupCompute(ComputeShader computeShader)
        {
            _computeShader = computeShader;
            _skinningKernelIndex = _computeShader.FindKernel(SkinningKernel);
        }

        public void SetMaxInstanceCounts(int totalMaxInstanceCount)
        {
            if (_meshData?.subMeshes != null && _meshData.subMeshes.Length > 0)
                MaxInstanceCountsPerSubMesh = Mathf.Max(0, totalMaxInstanceCount) / _meshData.subMeshes.Length;
        }

        public void ComputeSkinning(CommandBuffer cmd, GraphicsBuffer inMatricesBuffer)
        {
            int count = GetVertexCount();
            if (count < 1 || _computeShader == null || _skinningKernelIndex < 0) return;
            cmd.SetComputeIntParam(_computeShader, VertexCountID, count);
            cmd.SetComputeIntParam(_computeShader, BoneCountID, _boneCount);
            var vertices = GetVertexBuffer((VertexStreamType)0);
            var skins = GetVertexBuffer((VertexStreamType)3);
            cmd.SetComputeBufferParam(_computeShader, _skinningKernelIndex, InVerticesID, _sourceVertexBuffer);
            cmd.SetComputeBufferParam(_computeShader, _skinningKernelIndex, InSkinsID, skins);
            cmd.SetComputeBufferParam(_computeShader, _skinningKernelIndex, InMatricesID, inMatricesBuffer);
            cmd.SetComputeBufferParam(_computeShader, _skinningKernelIndex, OutVerticesID, vertices);
            cmd.DispatchCompute(_computeShader, _skinningKernelIndex, count / 64 + 1, 1, 1);
        }

        public void SetHandMatrices(MaterialPropertyBlock mpb, in NativeArray<Matrix4x4> boneMatrices)
        {
            if (mpb == null) return;
            for (int i = 0; i < 8; i++)
            {
                _handMatrices[2 * i] = boneMatrices[i * _boneCount + _rightHandBoneIndex] * _rightHandRotateMatrix;
                _handMatrices[2 * i + 1] = boneMatrices[i * _boneCount + _leftHandBoneIndex];
            }
            mpb.SetMatrixArray(HandMatricesID, _handMatrices);
        }

        public void Render(CommandBuffer cmd, MaterialPropertyBlock mpb, NativeArray<int> instanceCountsPerSubMesh, CrowdSystem.EventType eventType)
        {
            if (_meshData == null || _mesh == null || _meshData.subMeshes == null) return;
            int pass = eventType == CrowdSystem.EventType.GBuffer ? RenderGBufferPass : eventType == CrowdSystem.EventType.PreDepth ? RenderPreDepthPass : -1;
            int offset = 0;
            for (int i = 0; i < _meshData.subMeshes.Length; i++)
            {
                var subMesh = _meshData.subMeshes[i];
                var material = subMesh?.material;
                if (material == null) continue;
                int count = instanceCountsPerSubMesh[i];
                if (count < 1) continue;
                mpb.SetVector(MeshInfoID, new Vector4(subMesh.vertexCount, count, subMesh.vertexStart, offset));
                cmd.DrawMeshInstancedProcedural(_mesh, i, material, pass, count, mpb);
                offset += count;
            }
        }

        public bool EqualData(CrowdModelData.MeshData crowdMeshData)
        {
            return _meshData == crowdMeshData;
        }

        public void Dispose()
        {
            _sourceVertexBuffer?.Dispose();
            foreach (var buffer in _vertexBuffers) buffer?.Dispose();
            if (_mesh != null) UnityEngine.Object.DestroyImmediate(_mesh);
        }

        private GraphicsBuffer GetVertexBuffer(VertexStreamType streamType)
        {
            return _vertexBuffers[(int)streamType];
        }

        private int GetVertexCount()
        {
            return _mesh != null ? _mesh.vertexCount : 0;
        }
    }
}
