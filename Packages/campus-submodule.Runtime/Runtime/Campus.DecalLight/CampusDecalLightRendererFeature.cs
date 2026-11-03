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
        private static readonly SharedCampusDecalLightEntityManager _003CsharedManager_003Ek__BackingField;
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
                return null;
            }
        }

        public override void Create()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        private void RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        private void OnLitLighting(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public CampusDecalLightRendererFeature()
        {
        }
    }
}
