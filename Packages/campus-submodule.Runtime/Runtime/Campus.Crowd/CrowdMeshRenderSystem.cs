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
        private static readonly string SkinningKernel;
        private static readonly int VertexCountID;
        private static readonly int BoneCountID;
        private static readonly int InVerticesID;
        private static readonly int InSkinsID;
        private static readonly int InMatricesID;
        private static readonly int OutVerticesID;
        private static readonly int MeshInfoID;
        private static readonly int HandMatricesID;
        private static readonly ProfilingSampler CreateCrowdMeshRenderSystemSampler;
        private static readonly int RenderGBufferPass;
        private static readonly int RenderPreDepthPass;
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
                return null;
            }
        }

        public CrowdModelData.SubMeshData[] SubMeshes
        {
            get
            {
                return null;
            }
        }

        public int MaxInstanceCountsPerSubMesh
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CrowdMeshRenderSystem(CrowdModelData modelData)
        {
        }

        public void SetupCompute(ComputeShader computeShader)
        {
        }

        public void SetMaxInstanceCounts(int totalMaxInstanceCount)
        {
        }

        public void ComputeSkinning(CommandBuffer cmd, GraphicsBuffer inMatricesBuffer)
        {
        }

        public void SetHandMatrices(MaterialPropertyBlock mpb, in NativeArray<Matrix4x4> boneMatrices)
        {
        }

        public void Render(CommandBuffer cmd, MaterialPropertyBlock mpb, NativeArray<int> instanceCountsPerSubMesh, CrowdSystem.EventType eventType)
        {
        }

        public bool EqualData(CrowdModelData.MeshData crowdMeshData)
        {
            return default(bool);
        }

        public void Dispose()
        {
        }

        private GraphicsBuffer GetVertexBuffer(VertexStreamType streamType)
        {
            return null;
        }

        private int GetVertexCount()
        {
            return default(int);
        }
    }
}
