namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class BillboardMeshRenderSystem : IDisposable
    {
        private static readonly int _BillboardTexture = Shader.PropertyToID("_BillboardTexture");
        private static readonly int _BillboardMatrices = Shader.PropertyToID("_BillboardMatrices");
        private static readonly int _BillboardOffset = Shader.PropertyToID("_BillboardOffset");
        private static readonly Matrix4x4 BillboardProjMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-0.5f, 0.5f, -0.5f, 0.5f, -10f, 10f), false);
        private static readonly int RenderBillboardGBufferPass = 0;
        private static readonly int RenderBillboardPreDepthPass = 1;
        private readonly Mesh _mesh;
        private readonly Matrix4x4[] _objToWorldMatricesArrayBuffer;
        private readonly Matrix4x4[] _billboardMatricesArrayBuffer;
        private NativeArray<Matrix4x4> _billboardRotateMatrices;
        private NativeArray<Matrix4x4> _objToWorldMatrices;
        private NativeArray<Matrix4x4> _billboardMatrices;
        private RTHandle _billboardColorBuffer;
        private RTHandle _billboardDepthBuffer;
        private int _width;
        private int _height;
        private CustomRenderPassData _renderPass;
        private CustomSubPassData[] _subPasses;
        private Mesh _crowdMesh;
        private CrowdModelData.SubMeshData[] _subMeshes;
        public NativeArray<Matrix4x4> BillboardRotateMatrices
        {
            get { return _billboardRotateMatrices; }
        }

        public NativeArray<Matrix4x4> ObjToWorldMatrices
        {
            get { return _objToWorldMatrices; }
        }

        public NativeArray<Matrix4x4> BillboardMatrices
        {
            get { return _billboardMatrices; }
        }

        public BillboardMeshRenderSystem()
        {
            _mesh = CreateBillboardMesh();
            _objToWorldMatricesArrayBuffer = new Matrix4x4[4];
            _billboardMatricesArrayBuffer = new Matrix4x4[32];
            _billboardRotateMatrices = new NativeArray<Matrix4x4>(4, Allocator.Persistent);
            for (int i = 0; i < _billboardRotateMatrices.Length; i++)
                _billboardRotateMatrices[i] = Matrix4x4.Rotate(Quaternion.Euler(0f, 180 - 90 * i, 0f));
            _objToWorldMatrices = new NativeArray<Matrix4x4>(32, Allocator.Persistent);
            _billboardMatrices = new NativeArray<Matrix4x4>(32, Allocator.Persistent);
            _renderPass = new CustomRenderPassData
            {
                attachmentDescriptors = new[]
                {
                    new AttachmentDescriptor(global::UnityEngine.Experimental.Rendering.GraphicsFormat.R8G8B8A8_UNorm)
                    {
                        loadAction = RenderBufferLoadAction.Clear,
                        storeAction = RenderBufferStoreAction.Store,
                        clearColor = Color.clear
                    },
                    new AttachmentDescriptor(global::UnityEngine.Experimental.Rendering.GraphicsFormat.D24_UNorm_S8_UInt)
                    {
                        loadAction = RenderBufferLoadAction.Clear,
                        storeAction = RenderBufferStoreAction.DontCare
                    }
                },
                depthAttachmentIndex = 1,
                memoryless = new[] { false, true }
            };
            _subPasses = new[]
            {
                new CustomSubPassData
                {
                    colors = new[] { 0 },
                    profilingSampler = new ProfilingSampler("Bake Billboard"),
                    renderAction = OnBakeBillboard
                }
            };
        }

        public void SetBillboardResolution(int w, int h)
        {
            _width = w;
            _height = h;
        }

        public bool IsValid()
        {
            return _width > 0 && _height > 0;
        }

        public void BakeBillboard(ScriptableRenderContext context, ref RenderingData renderingData, Mesh crowdMesh, CrowdModelData.SubMeshData[] subMeshes)
        {
            if (crowdMesh == null || subMeshes == null || _width < 1 || _height < 1) return;
            var descriptor = new RenderTextureDescriptor(32 * _width, _height, global::UnityEngine.Experimental.Rendering.GraphicsFormat.R8G8B8A8_UNorm, 0);
            RenderingUtils.ReAllocateIfNeeded(ref _billboardColorBuffer, descriptor, FilterMode.Point, TextureWrapMode.Clamp, name: "_BillboardColorBuffer");
            descriptor.graphicsFormat = global::UnityEngine.Experimental.Rendering.GraphicsFormat.None;
            descriptor.depthStencilFormat = global::UnityEngine.Experimental.Rendering.GraphicsFormat.D24_UNorm_S8_UInt;
            RenderingUtils.ReAllocateIfNeeded(ref _billboardDepthBuffer, descriptor, FilterMode.Point, TextureWrapMode.Clamp, name: "_BillboardDepthBuffer");
            _crowdMesh = crowdMesh;
            _subMeshes = subMeshes;
            _renderPass.width = 32 * _width;
            _renderPass.height = _height;
            _renderPass.attachmentDescriptors[0].loadStoreTarget = _billboardColorBuffer.nameID;
            CustomRenderPassUtility.Execute(context, ref renderingData, _renderPass, _subPasses);
        }

        private void OnBakeBillboard(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            cmd.SetViewProjectionMatrices(Matrix4x4.identity, BillboardProjMatrix);
            cmd.SetGlobalTexture(_BillboardTexture, _billboardColorBuffer.nameID);
            for (int i = 0; i < _subMeshes.Length; i++)
            {
                var material = _subMeshes[i]?.material;
                if (material == null) continue;
                for (int view = 0; view < _objToWorldMatricesArrayBuffer.Length; view++)
                    _objToWorldMatricesArrayBuffer[view] = _objToWorldMatrices[4 * i + view];
                cmd.DrawMeshInstanced(_crowdMesh, i, material, 0, _objToWorldMatricesArrayBuffer);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        public void RenderBillboard(CommandBuffer cmd, Material material, MaterialPropertyBlock mpb, int billboardOffset, int billboardInstanceCount, CrowdSystem.EventType eventType)
        {
            if (cmd == null || mpb == null || billboardInstanceCount < 1 || _width < 1 || _height < 1) return;
            int pass = eventType == CrowdSystem.EventType.GBuffer ? RenderBillboardGBufferPass : eventType == CrowdSystem.EventType.PreDepth ? RenderBillboardPreDepthPass : -1;
            _billboardMatrices.CopyTo(_billboardMatricesArrayBuffer);
            mpb.SetInt(_BillboardOffset, billboardOffset);
            mpb.SetMatrixArray(_BillboardMatrices, _billboardMatricesArrayBuffer);
            cmd.DrawMeshInstancedProcedural(_mesh, 0, material, pass, billboardInstanceCount, mpb);
        }

        public void Dispose()
        {
            CoreUtils.Destroy(_mesh);
            _billboardColorBuffer?.Release();
            _billboardDepthBuffer?.Release();
            if (_billboardRotateMatrices.IsCreated) _billboardRotateMatrices.Dispose();
            if (_objToWorldMatrices.IsCreated) _objToWorldMatrices.Dispose();
            if (_billboardMatrices.IsCreated) _billboardMatrices.Dispose();
        }

        private Mesh CreateBillboardMesh()
        {
            var vertices = new[]
            {
                new Vector3(0.5f, -0.5f, 0f), new Vector3(0.5f, 0.5f, 0f),
                new Vector3(-0.5f, 0.5f, 0f), new Vector3(-0.5f, -0.5f, 0f)
            };
            var indices = new[] { 0, 1, 3, 1, 2, 3 };
            var uv = new[] { Vector2.zero, new Vector2(0f, 1f), Vector2.one, new Vector2(1f, 0f) };
            var mesh = new Mesh { name = "Crowd Billboard Mesh", hideFlags = HideFlags.DontSave };
            mesh.SetVertices(vertices);
            mesh.SetIndices(indices, MeshTopology.Triangles, 0);
            mesh.SetUVs(0, uv);
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();
            mesh.UploadMeshData(true);
            return mesh;
        }
    }
}
