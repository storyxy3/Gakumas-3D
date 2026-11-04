namespace Campus.Crowd
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class CrowdRendererFeature : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public bool useMainCamera;
            public Settings()
            {
            }
        }

        private readonly ProfilingSampler _profilingSampler = new ProfilingSampler("Render Crowd");
        public Settings settings = new Settings();
        public ComputeShader skinningCompute;
        public ComputeShader crowdCompute;
        public ComputeShader penlightCompute;
        public Shader billboardShader;
        private Material _billboardMaterial;
        private Dictionary<int, CrowdSystem> _systems;
        private CrowdComputePass _computePass;
        private CrowdRenderingSetupData _crowdSetupData;
        private RenderingBridge.RenderEvent _onRenderPreDepth;
        private RenderingBridge.RenderEvent _onRenderGBuffer;
        private RenderingBridge.RenderEvent _onRenderMotionVector;
        public override void Create()
        {
            if (crowdCompute == null || skinningCompute == null || penlightCompute == null || billboardShader == null) return;
            _computePass = new CrowdComputePass();
            Dispose(false);
            _systems = new Dictionary<int, CrowdSystem>(8);
            _crowdSetupData = new CrowdRenderingSetupData();
            _onRenderPreDepth = OnRenderPreDepth;
            _onRenderGBuffer = OnRenderGBuffer;
            _onRenderMotionVector = OnRenderMotionVector;
        }

        public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
        {
            if (_systems == null || cameraData.cameraType == CameraType.Preview) return;
            var stack = VolumeManager.instance.stack;
            var crowd = stack.GetComponent<Crowd>();
            var volume = crowd.target.value;
            if (volume == null || volume.modelData == null || volume.crowdData == null) return;
            var audience = stack.GetComponent<global::Campus.AudiencePenlight.AudiencePenlightVolumeComponent>().target.value;
            var camera = cameraData.camera;
            int id = camera.GetInstanceID();
            if (!_systems.TryGetValue(id, out var system))
            {
                system = new CrowdSystem(camera);
                _systems.Add(id, system);
            }
            else if (system == null)
            {
                system = new CrowdSystem(camera);
                _systems[id] = system;
            }
            system.Setup(volume, audience, skinningCompute, crowdCompute, penlightCompute);
            if (!system.IsActive()) return;
            _crowdSetupData.Update(in cameraData, false, crowd);
            system.SetDrawCounts(crowd.drawDetailCount.value);
            system.SetBillboardResolution(crowd.billboardQuality.value);
            if (system.ScheduleJobs(_crowdSetupData.ViewProjMatrix, _crowdSetupData.CameraPos, _crowdSetupData.OcclusionSphere))
            {
                RenderingBridge.AddRenderEvent(RenderingBridge.EventType.PreDepth, _onRenderPreDepth);
                RenderingBridge.AddRenderEvent(RenderingBridge.EventType.GBuffer, _onRenderGBuffer);
            }
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (!_systems.TryGetValue(renderingData.cameraData.camera.GetInstanceID(), out var system) || !system.IsActive()) return;
            _computePass.Setup(system, _crowdSetupData);
            renderer.EnqueuePass(_computePass);
        }

        protected override void Dispose(bool disposing)
        {
            if (_systems != null)
            {
                foreach (var system in _systems.Values) system?.Dispose();
                _systems = null;
            }
            CoreUtils.Destroy(_billboardMaterial);
        }

        private CrowdSystem GetSystem(ref CameraData cameraData)
        {
            if (cameraData.cameraType == CameraType.Preview) return null;
            if (_systems.TryGetValue(cameraData.camera.GetInstanceID(), out var system) && system.IsActive()) return system;
            return null;
        }

        private void OnRenderPreDepth(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var system = GetSystem(ref renderingData.cameraData);
            if (system == null) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                system.RenderCrowd(cmd, CrowdSystem.EventType.PreDepth);
                if (_billboardMaterial == null) _billboardMaterial = CoreUtils.CreateEngineMaterial(billboardShader);
                system.RenderBillboardCrowd(cmd, _billboardMaterial, CrowdSystem.EventType.PreDepth);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void OnRenderGBuffer(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var system = GetSystem(ref renderingData.cameraData);
            if (system == null || _crowdSetupData == null) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                system.RenderCrowd(cmd, CrowdSystem.EventType.GBuffer);
                if (_billboardMaterial == null) _billboardMaterial = CoreUtils.CreateEngineMaterial(billboardShader);
                system.RenderBillboardCrowd(cmd, _billboardMaterial, CrowdSystem.EventType.GBuffer);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        private void OnRenderMotionVector(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (GetSystem(ref renderingData.cameraData) == null || renderingData.cameraData.cameraType != CameraType.Game) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler)) { }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        public CrowdRendererFeature()
        {
        }
    }
}
