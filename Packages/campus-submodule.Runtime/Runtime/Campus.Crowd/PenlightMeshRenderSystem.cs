namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.AudiencePenlight;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class PenlightMeshRenderSystem : IDisposable
    {
        private static readonly string UpdatePenlightKernel;
        private static readonly int TargetPenlightTypeID;
        private static readonly int PenlightInfoBytesBufferID;
        private static readonly int PenlightColorsID;
        private static readonly int PenlightProjectionParamsID;
        private static readonly int PenlightProjectionUvID;
        public static readonly string UseColorTableKeyword;
        private static readonly int RenderPenlightGBufferPass;
        private static readonly int RenderPenlightPreDepthPass;
        private readonly CrowdModelData.MeshData _meshData;
        private readonly Mesh _mesh;
        private readonly int _subMeshCount;
        private readonly GraphicsBuffer _indirectArgsBuffer;
        private readonly GraphicsBuffer[] _penlightInfoBytesBuffers;
        [CompilerGenerated]
        private ComputeShader _003CPenlightCompute_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CUpdatePenlightKernelIndex_003Ek__BackingField;
        public ComputeShader PenlightCompute
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public int UpdatePenlightKernelIndex
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

        public PenlightMeshRenderSystem(CrowdModelData.MeshData meshData, int personCount)
        {
        }

        public void SetupCompute(ComputeShader computeShader)
        {
        }

        public void ComputeUpdatePenlight(CommandBuffer cmd, int visiblePersonCount)
        {
        }

        public void Render(CommandBuffer cmd, MaterialPropertyBlock mpb, Bounds bounds, IAudiencePenlight penlight, CrowdSystem.EventType evetType)
        {
        }

        public void Dispose()
        {
        }

        private void InitializedArgsBuffer(out GraphicsBuffer buffer)
        {
            throw null;
        }

        private void InitializeAppendBuffer(int personCount, out GraphicsBuffer bufferA, out GraphicsBuffer bufferB)
        {
            throw null;
        }

        private GraphicsBuffer GetPenlightInfoBytesBuffer(int index)
        {
            return null;
        }
    }
}
