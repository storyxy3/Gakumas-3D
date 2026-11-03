namespace VL.Rendering
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VL.Rendering;
    using global::VLB;

    public class DownscaleSystemRendererFeature : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public LayerMask transparentLayerMask;
            public string[] transparentShaderPassIds;
            public bool flareOverlay;
            public Settings()
            {
            }
        }

        public const RenderPassEvent DownscaleSystemPassEvent = (RenderPassEvent)225;
        public const RenderPassEvent LastTransparentPassEvent = (RenderPassEvent)460;
        private static readonly int _StencilComp;
        public Settings settings;
        public DownscaleSystemData data;
        private DownscaleTransparentPass _transparentPass;
        private DownscaleApplyPass _applyPass;
        private DownscalePass _downscalePass;
        private SubWorldPass _subWorldPass;
        private Material _downscaleMaterial;
        private Material _ssaoMaterial;
        private Material _fogMaterial;
        private Material _subWorldMaterial;
        private DownscaleBuffers _buffers;
        private bool _recreateSystems;
        [CompilerGenerated]
        private static readonly SharedPlanarReflectionEntityManager _003CsharedPlanarReflectionManager_003Ek__BackingField;
        private PlanarReflectionEntityManager _planarReflectionEntityManager;
        private PlanarReflectionUpdateCachedSystem _planarReflectionUpdateCachedSystem;
        private PlanarReflectionCullingSystem _planarReflectionCullingSystem;
        private PlanarReflectionResultSystem _planarReflectionResultSystem;
        private PlanarReflectionDrawSystem _planarReflectionDrawSystem;
        private Mesh _boxMesh;
        [CompilerGenerated]
        private static readonly SharedVLBEntityManager _003CsharedVLBEntityManager_003Ek__BackingField;
        private VLBEntityManager _vlbEntityManager;
        private VLBUpdateCachedSystem _vlbUpdateCachedSystem;
        private VLBCullingSystem _vlbCullingSystem;
        private VLBDrawCallSystem _vlbDrawCallSystem;
        private ProFlareRenderingSystem _flareSystem;
        private Material _flareMaterial;
        private AmplifyOcclusionRenderingData _amplifyOcclusionRenderingData;
        private Material _amplifyOcclusionMat;
        private Material _amplifyOcclusionBlurMat;
        private Material _amplifyOcclusionApplyMat;
        private static SharedPlanarReflectionEntityManager sharedPlanarReflectionManager
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        private static SharedVLBEntityManager sharedVLBEntityManager
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

        private void RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
        {
        }

        private void SetupDownscalePass(ScriptableRenderer renderer, ref RenderingData renderingData, DeferredLights deferredLights, in Matrix4x4 vpMatrix, in Matrix4x4 viewMatrix)
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public DownscaleSystemRendererFeature()
        {
        }
    }
}
