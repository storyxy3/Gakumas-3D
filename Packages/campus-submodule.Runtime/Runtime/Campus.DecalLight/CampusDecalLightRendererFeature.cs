namespace Campus.DecalLight
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.DecalLight;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    [DisallowMultipleRendererFeature("Campus Decal Light")]
    public class CampusDecalLightRendererFeature : ScriptableRendererFeature
    {
        public Material material;
        [CompilerGenerated]
        private static readonly SharedCampusDecalLightEntityManager _003CsharedManager_003Ek__BackingField = new SharedCampusDecalLightEntityManager();
        private CampusDecalLightEntityManager _manager;
        private CampusDecalLightUpdateSystem _updateSystem;
        private CampusDecalLightCullingSystem _cullingSystem;
        private CampusDecalLightResultSystem _resultSystem;
        private CampusDecalLightDrawSystem _drawSystem;
        private bool _recreateSystems;
        private RenderingBridge.RenderEvent _onLitLighting;
        private static SharedCampusDecalLightEntityManager sharedManager
        {
            [CompilerGenerated]
            get
            {
                return _003CsharedManager_003Ek__BackingField;
            }
        }

        public override void Create()
        {
            if (material == null) return;
            _recreateSystems = true;
            _onLitLighting = OnLitLighting;
        }

        protected override void Dispose(bool disposing)
        {
            _drawSystem?.Dispose();
            sharedManager.Release(ref _manager);
        }

        private void RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
        {
            if (!_recreateSystems) return;
            if (_manager == null) _manager = sharedManager.Get();
            _drawSystem = new CampusDecalLightDrawSystem(_manager, material);
            _updateSystem = new CampusDecalLightUpdateSystem(_manager);
            _cullingSystem = new CampusDecalLightCullingSystem(_manager);
            _resultSystem = new CampusDecalLightResultSystem(_manager, _drawSystem);
            _recreateSystems = false;
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            ref var cameraData = ref renderingData.cameraData;
            if (cameraData.cameraType != CameraType.Game && cameraData.cameraType != CameraType.SceneView) return;
            RecreateSystemsIfNeeded(renderer, cameraData);
            _ = VolumeManager.instance.stack;
            var projection = cameraData.GetProjectionMatrix();
            var view = cameraData.GetViewMatrix();
            var viewProjection = projection * view;
            if (_manager.combinedChunksList == null) return;
            _manager.Update();
            _manager.UpdateAllEntityData();
            _updateSystem.Execute();
            _cullingSystem.Execute(viewProjection);
            _resultSystem.Execute(cameraData.worldSpaceCameraPos, view);
            RenderingBridge.AddRenderEvent(RenderingBridge.EventType.LitLighting, _onLitLighting);
        }

        private void OnLitLighting(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (_drawSystem == null) return;
            var cmd = CommandBufferPool.Get();
            _drawSystem.CompleteJob();
            _drawSystem.Execute(cmd);
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        public CampusDecalLightRendererFeature()
        {
        }
    }
}
