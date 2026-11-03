namespace Campus.Crowd
{
    using global::Campus.AudiencePenlight;
    using global::Campus.Crowd;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class CrowdSystem
    {
        public enum EventType
        {
            PreDepth,
            GBuffer
        }

        private static readonly int LookAtID;
        private static readonly int CameraPositionID;
        private static readonly int CameraForwardID;
        private static readonly int OcclusionSphereID;
        private static readonly ProfilingSampler SetupSampler;
        private static readonly ProfilingSampler ExecuteCullingJobSampler;
        private readonly Camera _camera;
        private readonly Plane[] _planes;
        private readonly MaterialPropertyBlock _materialPropertyBlock;
        private CrowdVolume _crowdVolume;
        private AudiencePenlightVolume _audiencePenlightVolume;
        private CrowdMeshRenderSystem _crowdMeshRenderSystem;
        private BillboardMeshRenderSystem _billboardMeshRenderSystem;
        private PenlightMeshRenderSystem _penlightMeshRenderSystem;
        private CrowdSystemData _crowdSystemData;
        private JobHandle _jobHandle;
        private NativeList<CellSortData> _cells;
        private DefaultAudiencePenlight _defaultAudiencePenlight;
        public CrowdSystem(Camera camera)
        {
        }

        public void Setup(CrowdVolume crowdVolume, AudiencePenlightVolume audiencePenlightVolume, ComputeShader skinningCompute, ComputeShader crowdCompute, ComputeShader penlightCompute)
        {
        }

        public void Setup(CrowdModelData modelData, CrowdData crowdData, bool forceSetup = false)
        {
        }

        public bool IsActive()
        {
            return default(bool);
        }

        public void SetDrawCounts(int count)
        {
        }

        public void SetBillboardResolution(BillboardQuality quality)
        {
        }

        public bool ScheduleJobs(Matrix4x4 viewProjMatrix, Vector3 cameraPos, Vector4 occlusionSphere)
        {
            return default(bool);
        }

        public void CompleteJobs()
        {
        }

        public void ComputeCrowdSkinning(CommandBuffer cmd)
        {
        }

        public void SetupComputeCrowd(CommandBuffer cmd, Vector3 lookAt, float randomLookAtWeight, Vector3 cameraPos, Vector3 cameraForward, Vector4 occlusionSphere)
        {
        }

        public void ComputeCrowd(CommandBuffer cmd)
        {
        }

        private void SetupCompute(ComputeShader skinningCompute, ComputeShader crowdCompute, ComputeShader penlightCompute)
        {
        }

        private void SetComputeParams(CommandBuffer cmd, ComputeShader compute, Vector3 lookAt, float randomLookAtWeight, Vector3 cameraPos, Vector3 cameraForward, Vector4 occlusionSphere)
        {
        }

        private void ComputePenlight(CommandBuffer cmd)
        {
        }

        public void BakeBillboardCrowd(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public void SetupRenderingParameter()
        {
        }

        public void RenderCrowd(CommandBuffer cmd, EventType eventType)
        {
        }

        public void RenderBillboardCrowd(CommandBuffer cmd, Material material, EventType eventType)
        {
        }

        public void Dispose()
        {
        }

        private void DisposeCrowdMeshRenderSystem()
        {
        }

        private void DisposeBillboardMeshRenderSystem()
        {
        }

        private void DisposePenlightMeshRenderSystem()
        {
        }

        private void DisposeCrowdSystemData()
        {
        }
    }
}
