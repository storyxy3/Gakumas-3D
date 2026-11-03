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
        private static readonly int _BillboardTexture;
        private static readonly int _BillboardMatrices;
        private static readonly int _BillboardOffset;
        private static readonly Matrix4x4 BillboardProjMatrix;
        private static readonly int RenderBillboardGBufferPass;
        private static readonly int RenderBillboardPreDepthPass;
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
            get
            {
                return default(NativeArray<Matrix4x4>);
            }
        }

        public NativeArray<Matrix4x4> ObjToWorldMatrices
        {
            get
            {
                return default(NativeArray<Matrix4x4>);
            }
        }

        public NativeArray<Matrix4x4> BillboardMatrices
        {
            get
            {
                return default(NativeArray<Matrix4x4>);
            }
        }

        public BillboardMeshRenderSystem()
        {
        }

        public void SetBillboardResolution(int w, int h)
        {
        }

        public bool IsValid()
        {
            return default(bool);
        }

        public void BakeBillboard(ScriptableRenderContext context, ref RenderingData renderingData, Mesh crowdMesh, CrowdModelData.SubMeshData[] subMeshes)
        {
        }

        private void OnBakeBillboard(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public void RenderBillboard(CommandBuffer cmd, Material material, MaterialPropertyBlock mpb, int billboardOffset, int billboardInstanceCount, CrowdSystem.EventType eventType)
        {
        }

        public void Dispose()
        {
        }

        private Mesh CreateBillboardMesh()
        {
            return null;
        }
    }
}
