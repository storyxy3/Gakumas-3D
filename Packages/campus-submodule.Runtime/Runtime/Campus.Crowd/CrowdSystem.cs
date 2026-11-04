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

        private static readonly int LookAtID = Shader.PropertyToID("_LookAt");
        private static readonly int CameraPositionID = Shader.PropertyToID("_CameraPosition");
        private static readonly int CameraForwardID = Shader.PropertyToID("_CameraForward");
        private static readonly int OcclusionSphereID = Shader.PropertyToID("_OcclusionSphere");
        private static readonly ProfilingSampler SetupSampler = new ProfilingSampler("CrowdSystem.Setup");
        private static readonly ProfilingSampler ExecuteCullingJobSampler = new ProfilingSampler("CrowdSystem.ExecuteCullingJob");
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
            _camera = camera;
            _planes = new Plane[6];
            _materialPropertyBlock = new MaterialPropertyBlock();
            _defaultAudiencePenlight = new DefaultAudiencePenlight(System.Array.Empty<Color>());
        }

        public void Setup(CrowdVolume crowdVolume, AudiencePenlightVolume audiencePenlightVolume, ComputeShader skinningCompute, ComputeShader crowdCompute, ComputeShader penlightCompute)
        {
            bool forceSetup = false;
            if (_crowdVolume != crowdVolume || _crowdVolume == null)
            {
                _crowdVolume = crowdVolume;
                forceSetup = true;
            }
            if (_audiencePenlightVolume != audiencePenlightVolume)
            {
                _audiencePenlightVolume = audiencePenlightVolume;
                forceSetup = true;
            }
            Setup(_crowdVolume.modelData, _crowdVolume.crowdData, forceSetup);
            SetupCompute(skinningCompute, crowdCompute, penlightCompute);
        }

        public void Setup(CrowdModelData modelData, CrowdData crowdData, bool forceSetup = false)
        {
            using (new ProfilingScope(null, SetupSampler))
            {
                if (modelData.crowdMeshData == null || global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(modelData.crowdMeshData.subMeshes)) return;
                int subMeshCount = modelData.crowdMeshData.subMeshes.Length;
                int boneCount = modelData.Bones.Length;
                int personCount = crowdData.personInfos.Length;
                if (forceSetup || _crowdMeshRenderSystem == null || !_crowdMeshRenderSystem.EqualData(modelData.crowdMeshData))
                {
                    DisposeCrowdMeshRenderSystem();
                    _crowdMeshRenderSystem = new CrowdMeshRenderSystem(modelData);
                }
                if (forceSetup || _billboardMeshRenderSystem == null)
                {
                    DisposeBillboardMeshRenderSystem();
                    _billboardMeshRenderSystem = new BillboardMeshRenderSystem();
                }
                if (modelData.penlightMeshData?.mesh != null && (forceSetup || _penlightMeshRenderSystem == null))
                {
                    DisposePenlightMeshRenderSystem();
                    _penlightMeshRenderSystem = new PenlightMeshRenderSystem(modelData.penlightMeshData, personCount);
                }
                if (forceSetup || _crowdSystemData == null || !_crowdSystemData.EqualData(crowdData))
                {
                    DisposeCrowdSystemData();
                    _crowdSystemData = new CrowdSystemData(crowdData, subMeshCount, boneCount, modelData.penlightTypeWeights,
                        modelData.penlightAmountWeights, modelData.BoundingSphere);
                }
            }
        }

        public bool IsActive()
        {
            if (_crowdVolume == null || _crowdVolume.modelData == null || _crowdSystemData == null) return false;
            GeometryUtility.CalculateFrustumPlanes(_camera, _planes);
            return GeometryUtility.TestPlanesAABB(_planes, _crowdSystemData.Bounds);
        }

        public void SetDrawCounts(int count)
        {
            _crowdMeshRenderSystem?.SetMaxInstanceCounts(count);
        }

        public void SetBillboardResolution(BillboardQuality quality)
        {
            switch (quality)
            {
                case BillboardQuality.None: _billboardMeshRenderSystem.SetBillboardResolution(0, 0); break;
                case BillboardQuality.RES_16: _billboardMeshRenderSystem.SetBillboardResolution(16, 32); break;
                case BillboardQuality.RES_32: _billboardMeshRenderSystem.SetBillboardResolution(32, 64); break;
                case BillboardQuality.RES_64: _billboardMeshRenderSystem.SetBillboardResolution(64, 128); break;
            }
        }

        public bool ScheduleJobs(Matrix4x4 viewProjMatrix, Vector3 cameraPos, Vector4 occlusionSphere)
        {
            if (!_jobHandle.IsCompleted) _jobHandle.Complete();
            if (_crowdVolume == null || _crowdVolume.modelData == null || _crowdSystemData == null ||
                !_crowdSystemData.OctreeInfos.IsCreated || !_crowdSystemData.PersonInfos.IsCreated || !_crowdSystemData.PersonIndexes.IsCreated ||
                _crowdMeshRenderSystem == null || global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_crowdMeshRenderSystem.SubMeshes)) return false;
            using (new ProfilingScope(null, ExecuteCullingJobSampler))
            {
                var sphere = _crowdVolume.modelData.BoundingSphere;
                var planes = new global::VL.Rendering.CameraPlanes(in viewProjMatrix);
                int cellCount = _crowdSystemData.OctreeInfos.Length;
                if (_cells.IsCreated && _cells.Capacity < cellCount) _cells.Dispose();
                if (!_cells.IsCreated) _cells = new NativeList<CellSortData>(cellCount, Allocator.Persistent);
                _cells.Clear();
                var cullHandle = new CrowdCullJob
                {
                    OctreeInfos = _crowdSystemData.OctreeInfos,
                    Cells = _cells.AsParallelWriter(),
                    Planes = planes,
                    Bounds = _crowdSystemData.BaseCellBounds,
                    BoundingSphere = sphere,
                    CameraPos = cameraPos
                }.Schedule(cellCount, 32);
                var sortHandle = new CrowdSortJob
                {
                    Cells = _cells.AsDeferredJobArray(),
                    PersonInfos = _crowdSystemData.PersonInfos,
                    PersonIndexes = _crowdSystemData.PersonIndexes,
                    InstanceCountsPerSubMesh = _crowdSystemData.InstanceCountsPerSubMesh,
                    BillboardInstanceCount = _crowdSystemData.BillboardInstanceCount,
                    Planes = planes,
                    BoundingSphere = sphere,
                    OcclusionSphereCenter = new global::Unity.Mathematics.float3(occlusionSphere.x, occlusionSphere.y, occlusionSphere.z),
                    OcclusionSphereRadius = occlusionSphere.w,
                    MaxInstanceCountsPerSubMesh = _crowdMeshRenderSystem.MaxInstanceCountsPerSubMesh
                }.Schedule(cullHandle);
                if (_billboardMeshRenderSystem != null)
                    sortHandle = JobHandle.CombineDependencies(sortHandle, BillboardMatricesJobHandler.Schedule(_crowdVolume.AnimationComponent, _billboardMeshRenderSystem));
                _jobHandle = sortHandle;
                return true;
            }
        }

        public void CompleteJobs()
        {
            _jobHandle.Complete();
        }

        public void ComputeCrowdSkinning(CommandBuffer cmd)
        {
            if (_crowdVolume == null) return;
            var animation = _crowdVolume.AnimationComponent;
            if (animation == null || !animation.Matrices.IsCreated) return;
            var buffer = _crowdSystemData.AnimationMatricesBuffer;
            if (!buffer.IsValid() || buffer.count != animation.Matrices.Length) return;
            buffer.SetData(animation.Matrices);
            _crowdMeshRenderSystem.ComputeSkinning(cmd, buffer);
        }

        public void SetupComputeCrowd(CommandBuffer cmd, Vector3 lookAt, float randomLookAtWeight, Vector3 cameraPos, Vector3 cameraForward, Vector4 occlusionSphere)
        {
            if (_crowdSystemData != null)
                SetComputeParams(cmd, _crowdSystemData.CrowdCompute, lookAt, randomLookAtWeight, cameraPos, cameraForward, occlusionSphere);
            if (_penlightMeshRenderSystem != null)
                SetComputeParams(cmd, _penlightMeshRenderSystem.PenlightCompute, lookAt, randomLookAtWeight, cameraPos, cameraForward, occlusionSphere);
        }

        public void ComputeCrowd(CommandBuffer cmd)
        {
            _jobHandle.Complete();
            _crowdSystemData?.UpdatePersonIndexBuffer(cmd);
            _crowdSystemData?.ComputeUpdatePerson(cmd);
            ComputePenlight(cmd);
        }

        private void SetupCompute(ComputeShader skinningCompute, ComputeShader crowdCompute, ComputeShader penlightCompute)
        {
            _crowdMeshRenderSystem?.SetupCompute(skinningCompute);
            _penlightMeshRenderSystem?.SetupCompute(penlightCompute);
            _crowdSystemData?.SetupCompute(crowdCompute);
        }

        private void SetComputeParams(CommandBuffer cmd, ComputeShader compute, Vector3 lookAt, float randomLookAtWeight, Vector3 cameraPos, Vector3 cameraForward, Vector4 occlusionSphere)
        {
            if (cmd == null || compute == null) return;
            cmd.SetComputeVectorParam(compute, LookAtID, new Vector4(lookAt.x, lookAt.y, lookAt.z, randomLookAtWeight));
            cmd.SetComputeVectorParam(compute, CameraPositionID, cameraPos);
            cmd.SetComputeVectorParam(compute, CameraForwardID, cameraForward);
            cmd.SetComputeVectorParam(compute, OcclusionSphereID, occlusionSphere);
        }

        private void ComputePenlight(CommandBuffer cmd)
        {
            if (_crowdSystemData == null || _penlightMeshRenderSystem == null) return;
            var crowdPenlight = _crowdVolume.CrowdPenlight;
            if (crowdPenlight == null || crowdPenlight.HidePenlight) return;
            int count = _crowdSystemData.TotalSubMeshInstanceCount + _crowdSystemData.BillboardInstanceCount.Value;
            var compute = _penlightMeshRenderSystem.PenlightCompute;
            int kernel = _penlightMeshRenderSystem.UpdatePenlightKernelIndex;
            _crowdSystemData.SetBoundsMin(cmd, compute);
            _crowdSystemData.SetVisiblePersonCount(cmd, compute, count);
            _crowdSystemData.SetPersonBuffers(cmd, compute, kernel);
            _crowdSystemData.SetPenlightBuffers(cmd, compute, kernel);
            _penlightMeshRenderSystem.ComputeUpdatePenlight(cmd, count);
            var penlight = (_audiencePenlightVolume != null ? _audiencePenlightVolume.AudiencePenlight : null) ?? _defaultAudiencePenlight;
            CoreUtils.SetKeyword(cmd, PenlightMeshRenderSystem.UseColorTableKeyword, !penlight.UseColorProjection);
        }

        public void BakeBillboardCrowd(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (_crowdMeshRenderSystem != null)
                _billboardMeshRenderSystem?.BakeBillboard(context, ref renderingData, _crowdMeshRenderSystem.Mesh, _crowdMeshRenderSystem.SubMeshes);
        }

        public void SetupRenderingParameter()
        {
            if (_materialPropertyBlock == null || _crowdSystemData == null || _crowdMeshRenderSystem == null || _crowdVolume == null) return;
            _crowdSystemData.SetPersonInfoBytes(_materialPropertyBlock);
            _crowdSystemData.SetBoundsMin(_materialPropertyBlock);
            var animation = _crowdVolume.AnimationComponent;
            var penlight = _crowdVolume.CrowdPenlight;
            if (animation != null && animation.Matrices.IsCreated && penlight != null && !penlight.HidePenlight)
            {
                var rawMatrices = _crowdVolume.AnimationComponent.RawMatrices;
                _crowdMeshRenderSystem.SetHandMatrices(_materialPropertyBlock, in rawMatrices);
            }
        }

        public void RenderCrowd(CommandBuffer cmd, EventType eventType)
        {
            if (_materialPropertyBlock == null || _crowdSystemData == null || _crowdMeshRenderSystem == null) return;
            _crowdMeshRenderSystem.Render(cmd, _materialPropertyBlock, _crowdSystemData.InstanceCountsPerSubMesh, eventType);
            var animation = _crowdVolume.AnimationComponent;
            var crowdPenlight = _crowdVolume.CrowdPenlight;
            if (animation == null || !animation.Matrices.IsCreated || crowdPenlight == null || crowdPenlight.HidePenlight || _penlightMeshRenderSystem == null) return;
            var penlight = (_audiencePenlightVolume != null ? _audiencePenlightVolume.AudiencePenlight : null) ?? _defaultAudiencePenlight;
            _penlightMeshRenderSystem.Render(cmd, _materialPropertyBlock, _crowdSystemData.Bounds, penlight, eventType);
        }

        public void RenderBillboardCrowd(CommandBuffer cmd, Material material, EventType eventType)
        {
            if (material == null || _materialPropertyBlock == null || _crowdSystemData == null || _billboardMeshRenderSystem == null) return;
            var count = _crowdSystemData.BillboardInstanceCount;
            if (!count.IsCreated || count.Value < 1) return;
            _billboardMeshRenderSystem.RenderBillboard(cmd, material, _materialPropertyBlock, _crowdSystemData.TotalSubMeshInstanceCount, count.Value, eventType);
        }

        public void Dispose()
        {
            if (_cells.IsCreated) _cells.Dispose(_jobHandle);
            if (!_jobHandle.IsCompleted) _jobHandle.Complete();
            DisposeCrowdMeshRenderSystem();
            DisposeBillboardMeshRenderSystem();
            DisposePenlightMeshRenderSystem();
            DisposeCrowdSystemData();
        }

        private void DisposeCrowdMeshRenderSystem()
        {
            _crowdMeshRenderSystem?.Dispose();
            _crowdMeshRenderSystem = null;
        }

        private void DisposeBillboardMeshRenderSystem()
        {
            _billboardMeshRenderSystem?.Dispose();
            _billboardMeshRenderSystem = null;
        }

        private void DisposePenlightMeshRenderSystem()
        {
            _penlightMeshRenderSystem?.Dispose();
            _penlightMeshRenderSystem = null;
        }

        private void DisposeCrowdSystemData()
        {
            _crowdSystemData?.Dispose();
            _crowdSystemData = null;
        }
    }
}
