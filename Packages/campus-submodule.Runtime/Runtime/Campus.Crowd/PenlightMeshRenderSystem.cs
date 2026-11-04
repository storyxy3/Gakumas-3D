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
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Action<GraphicsBuffer> _003C_003E9__26_0;
            public _003C_003Ec()
            {
            }

            internal void _003CDispose_003Eb__26_0(GraphicsBuffer b)
            {
            b?.Dispose();
        }
        }

        private static readonly string UpdatePenlightKernel = "UpdatePenlight";
        private static readonly int TargetPenlightTypeID = Shader.PropertyToID("_TargetPenlightType");
        private static readonly int PenlightInfoBytesBufferID = Shader.PropertyToID("_PenlightInfoBytesBuffer");
        private static readonly int PenlightColorsID = Shader.PropertyToID("_PenlightColors");
        private static readonly int PenlightProjectionParamsID = Shader.PropertyToID("_PenlightProjectionParams");
        private static readonly int PenlightProjectionUvID = Shader.PropertyToID("_PenlightProjectionUV");
        public static readonly string UseColorTableKeyword = "_USE_COLOR_TABLE";
        private static readonly int RenderPenlightGBufferPass = 1;
        private static readonly int RenderPenlightPreDepthPass = 2;
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
                return _003CPenlightCompute_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CPenlightCompute_003Ek__BackingField = value;
            }
        }

        public int UpdatePenlightKernelIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CUpdatePenlightKernelIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CUpdatePenlightKernelIndex_003Ek__BackingField = value;
            }
        }

        public PenlightMeshRenderSystem(CrowdModelData.MeshData meshData, int personCount)
        {
            _meshData = meshData;
            _mesh = global::VL.VLMeshUtility.CopyMesh(_meshData.mesh);
            _mesh.vertexBufferTarget |= GraphicsBuffer.Target.Raw;
            _subMeshCount = _meshData.subMeshes.Length;
            if (_mesh.vertexBufferCount != 2)
            {
                Debug.LogError("頂点バッファのレイアウトが違います");
                return;
            }
            InitializedArgsBuffer(out _indirectArgsBuffer);
            _penlightInfoBytesBuffers = new GraphicsBuffer[_subMeshCount];
            for (int i = 0; i < _subMeshCount; i++)
            {
                InitializeAppendBuffer(personCount, out var bufferA, out var bufferB);
                _penlightInfoBytesBuffers[i] = bufferA;
                // The APK discards the second scratch buffer. Release its unused allocation.
                bufferB.Dispose();
            }
        }

        public void SetupCompute(ComputeShader computeShader)
        {
            PenlightCompute = computeShader;
            UpdatePenlightKernelIndex = PenlightCompute.FindKernel(UpdatePenlightKernel);
        }

        public void ComputeUpdatePenlight(CommandBuffer cmd, int visiblePersonCount)
        {
            if (PenlightCompute == null || visiblePersonCount < 1 || UpdatePenlightKernelIndex < 0) return;
            int groups = (visiblePersonCount + 255) / 256;
            for (int i = 0; i < _subMeshCount; i++)
            {
                var buffer = GetPenlightInfoBytesBuffer(i);
                if (buffer == null) continue;
                buffer.SetCounterValue(0);
                cmd.SetComputeIntParam(PenlightCompute, TargetPenlightTypeID, i + 1);
                cmd.SetComputeBufferParam(PenlightCompute, UpdatePenlightKernelIndex, PenlightInfoBytesBufferID, buffer);
                cmd.DispatchCompute(PenlightCompute, UpdatePenlightKernelIndex, groups, 1, 1);
                cmd.CopyCounterValue(buffer, _indirectArgsBuffer, (uint)((5 * i + 1) * sizeof(uint)));
            }
        }

        public void Render(CommandBuffer cmd, MaterialPropertyBlock mpb, Bounds bounds, IAudiencePenlight penlight, CrowdSystem.EventType evetType)
        {
            if (_meshData == null || _mesh == null || mpb == null || penlight == null) return;
            if (penlight.UseColorProjection)
            {
                var inverseSize = new Vector2(1f / bounds.size.x, 1f / bounds.size.z);
                mpb.SetVector(PenlightProjectionParamsID, new Vector4(bounds.min.x * inverseSize.x, bounds.min.z * inverseSize.y, inverseSize.x, inverseSize.y));
                var min = penlight.ProjectionUvRectMin;
                var size = penlight.ProjectionUvRectMax - min;
                mpb.SetVector(PenlightProjectionUvID, new Vector4(size.x, size.y, min.x, min.y));
            }
            else mpb.SetVectorArray(PenlightColorsID, penlight.ColorTable);
            int pass = evetType == CrowdSystem.EventType.GBuffer ? RenderPenlightGBufferPass : evetType == CrowdSystem.EventType.PreDepth ? RenderPenlightPreDepthPass : -1;
            for (int i = 0; i < _subMeshCount; i++)
            {
                var material = _meshData.subMeshes[i]?.material;
                if (material == null) continue;
                var buffer = GetPenlightInfoBytesBuffer(i);
                if (buffer == null) continue;
                mpb.SetBuffer(PenlightInfoBytesBufferID, buffer);
                cmd.DrawMeshInstancedIndirect(_mesh, i, material, pass, _indirectArgsBuffer, i * 5 * sizeof(uint), mpb);
            }
        }

        public void Dispose()
        {
            _indirectArgsBuffer?.Dispose();
            if (_penlightInfoBytesBuffers != null)
                global::Campus.Common.Extensions.EnumerableExtensions.ForEach(_penlightInfoBytesBuffers,
                    _003C_003Ec._003C_003E9__26_0 ?? (_003C_003Ec._003C_003E9__26_0 = _003C_003Ec._003C_003E9._003CDispose_003Eb__26_0));
            if (_mesh != null) UnityEngine.Object.DestroyImmediate(_mesh);
        }

        private void InitializedArgsBuffer(out GraphicsBuffer buffer)
        {
            buffer = new GraphicsBuffer(GraphicsBuffer.Target.IndirectArguments, 5 * _subMeshCount, sizeof(uint));
            var args = new uint[5 * _subMeshCount];
            for (int i = 0; i < _subMeshCount; i++)
            {
                args[5 * i] = _mesh.GetIndexCount(i);
                args[5 * i + 2] = _mesh.GetIndexStart(i);
                args[5 * i + 3] = _mesh.GetBaseVertex(i);
            }
            buffer.SetData(args);
        }

        private void InitializeAppendBuffer(int personCount, out GraphicsBuffer bufferA, out GraphicsBuffer bufferB)
        {
            int count = personCount * 8;
            bufferA = new GraphicsBuffer(GraphicsBuffer.Target.Append | GraphicsBuffer.Target.CopyDestination, count, sizeof(uint));
            bufferB = new GraphicsBuffer(GraphicsBuffer.Target.Append | GraphicsBuffer.Target.CopySource, count, sizeof(uint));
            var data = new global::Unity.Collections.NativeArray<uint>(count, global::Unity.Collections.Allocator.Temp);
            bufferA.SetData(data);
            bufferB.SetData(data);
            data.Dispose();
            bufferA.SetCounterValue(0);
            bufferB.SetCounterValue(0);
        }

        private GraphicsBuffer GetPenlightInfoBytesBuffer(int index)
        {
            return _penlightInfoBytesBuffers[index];
        }
    }
}
