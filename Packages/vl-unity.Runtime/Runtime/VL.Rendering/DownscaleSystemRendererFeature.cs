// TODO(qa-recon): AddRenderPasses and SetupDownscalePass retain native semantic flags (camera predicates and unreconstructed URP/Amplify dependencies); see TASK_D_REPORT.md.
namespace VL.Rendering
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.Rendering.Universal.Internal;
    using global::VL.Rendering;
    using global::VLB;

    public class DownscaleSystemRendererFeature : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public LayerMask transparentLayerMask = -1;
            public string[] transparentShaderPassIds = new[] { "UniversalForward" };
            public bool flareOverlay;
            public Settings()
            {
            }
        }

        public const RenderPassEvent DownscaleSystemPassEvent = (RenderPassEvent)225;
        public const RenderPassEvent LastTransparentPassEvent = (RenderPassEvent)460;
        private static readonly int _StencilComp = Shader.PropertyToID("_StencilComp");
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
        private static readonly SharedPlanarReflectionEntityManager _003CsharedPlanarReflectionManager_003Ek__BackingField = new SharedPlanarReflectionEntityManager();
        private PlanarReflectionEntityManager _planarReflectionEntityManager;
        private PlanarReflectionUpdateCachedSystem _planarReflectionUpdateCachedSystem;
        private PlanarReflectionCullingSystem _planarReflectionCullingSystem;
        private PlanarReflectionResultSystem _planarReflectionResultSystem;
        private PlanarReflectionDrawSystem _planarReflectionDrawSystem;
        private Mesh _boxMesh;
        [CompilerGenerated]
        private static readonly SharedVLBEntityManager _003CsharedVLBEntityManager_003Ek__BackingField = new SharedVLBEntityManager();
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
                return _003CsharedPlanarReflectionManager_003Ek__BackingField;
            }
        }

        private static SharedVLBEntityManager sharedVLBEntityManager
        {
            [CompilerGenerated]
            get
            {
                return _003CsharedVLBEntityManager_003Ek__BackingField;
            }
        }

        public override void Create()
        {
            if (settings == null) settings = new Settings();
            _buffers = new DownscaleBuffers();
            if (data == null) return;
            _downscaleMaterial = CoreUtils.CreateEngineMaterial(data.downscaleShader);
            _fogMaterial = CoreUtils.CreateEngineMaterial(data.fogShader);
            _ssaoMaterial = CoreUtils.CreateEngineMaterial(data.ssaoShader);
            _boxMesh = VL.VLMeshUtility.CreateBoxMesh();
            _transparentPass = new DownscaleTransparentPass(settings.transparentShaderPassIds, settings.transparentLayerMask, _downscaleMaterial, _buffers);
            _transparentPass.renderPassEvent = LastTransparentPassEvent;
            _applyPass = new DownscaleApplyPass(_downscaleMaterial);
            _applyPass.renderPassEvent = (RenderPassEvent)461;
            _downscalePass = new DownscalePass(_boxMesh, _downscaleMaterial, _buffers);
            _downscalePass.renderPassEvent = DownscaleSystemPassEvent;
            _downscalePass.InitializeHiZ(data.hizComputeShader);
            _downscalePass.InitializeSSAO(_ssaoMaterial);
            _subWorldMaterial = CoreUtils.CreateEngineMaterial(data.subWorldShader);
            _subWorldPass = new SubWorldPass(_subWorldMaterial);
            _recreateSystems = true;
            if (data.flareShader != null && data.flareComputeShader != null)
            {
                _flareMaterial = CoreUtils.CreateEngineMaterial(data.flareShader);
                _flareSystem = new ProFlareRenderingSystem(data.flareComputeShader, _flareMaterial);
            }
            if (data.amplifyOcclusionShader != null && data.amplifyOcclusionBlurShader != null && data.amplifyOcclusionApplyShader != null)
            {
                _amplifyOcclusionMat = CoreUtils.CreateEngineMaterial(data.amplifyOcclusionShader);
                _amplifyOcclusionBlurMat = CoreUtils.CreateEngineMaterial(data.amplifyOcclusionBlurShader);
                _amplifyOcclusionApplyMat = CoreUtils.CreateEngineMaterial(data.amplifyOcclusionApplyShader);
                _amplifyOcclusionRenderingData = new AmplifyOcclusionRenderingData(_amplifyOcclusionMat, _amplifyOcclusionBlurMat, _amplifyOcclusionApplyMat);
                _amplifyOcclusionRenderingData.Initialize();
            }
        }

        private void RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData)
        {
            if (cameraData.cameraType == CameraType.Preview || cameraData.cameraType == CameraType.Reflection || !_recreateSystems) return;
            if (_planarReflectionEntityManager == null) _planarReflectionEntityManager = sharedPlanarReflectionManager.Get();
            _planarReflectionDrawSystem = new PlanarReflectionDrawSystem(_planarReflectionEntityManager, _downscaleMaterial, 2, 10, 3);
            _planarReflectionUpdateCachedSystem = new PlanarReflectionUpdateCachedSystem(_planarReflectionEntityManager);
            _planarReflectionCullingSystem = new PlanarReflectionCullingSystem(_planarReflectionEntityManager);
            _planarReflectionResultSystem = new PlanarReflectionResultSystem(_planarReflectionEntityManager, false);
            _downscalePass.SetPlanarReflectionDrawSystem(_planarReflectionDrawSystem);
            if (_vlbEntityManager == null) _vlbEntityManager = sharedVLBEntityManager.Get();
            var drawSystem = new VLBDrawSystem(_vlbEntityManager);
            _vlbUpdateCachedSystem = new VLBUpdateCachedSystem(_vlbEntityManager);
            _vlbCullingSystem = new VLBCullingSystem(_vlbEntityManager);
            _vlbDrawCallSystem = new VLBDrawCallSystem(_vlbEntityManager, drawSystem);
            _transparentPass.SetVLBDrawSystem(drawSystem);
            _recreateSystems = false;
        }

        private void SetupDownscalePass(ScriptableRenderer renderer, ref RenderingData renderingData, DeferredLights deferredLights, in Matrix4x4 vpMatrix, in Matrix4x4 viewMatrix)
        {
            if (renderingData.cameraData.renderType != CameraRenderType.Base) return;
            var stack = VolumeManager.instance.stack;
            var cameraType = renderingData.cameraData.cameraType;
            bool skipEffects = cameraType == CameraType.Preview || cameraType == CameraType.Reflection;
            var subWorld = stack.GetComponent<SubWorld>().target.value;
            if (!skipEffects && subWorld != null && subWorld.IsActive(renderingData.cameraData.camera, renderingData.cameraData.worldSpaceCameraPos))
            {
                _subWorldPass.Setup(subWorld, true);
                renderer.EnqueuePass(_subWorldPass);
            }
            var quality = stack.GetComponent<VLScreenSpaceReflection>().quality.value;
            if (skipEffects) quality = (VLSSRQualitySetting)0;
            var reflection = stack.GetComponent<PlanarReflectionVolumeComponent>();
            if (!skipEffects && reflection.enable.value && _planarReflectionEntityManager != null && _planarReflectionEntityManager.combinedChunks != null)
            {
                _planarReflectionEntityManager.Update();
                _planarReflectionEntityManager.UpdateAllEntityData();
                _planarReflectionUpdateCachedSystem.Execute();
                _planarReflectionCullingSystem.Execute(renderingData.cameraData.worldSpaceCameraPos, vpMatrix);
                _planarReflectionResultSystem.Execute(renderingData.cameraData.worldSpaceCameraPos, viewMatrix);
                _planarReflectionDrawSystem.isSystemExecuted = true;
            }
            _downscalePass.Setup(deferredLights, quality);
            var amplify = VolumeManager.instance.stack.GetComponent<global::AmplifyOcclusion.AmplifyOcclusion>();
            if (!skipEffects && _amplifyOcclusionRenderingData != null && amplify.IsActive())
            {
                _amplifyOcclusionRenderingData.Setup(amplify);
                _downscalePass.SetupAmplifyOcclusion(_amplifyOcclusionRenderingData);
                _downscalePass.SetupSSAO(false);
                _downscalePass.ConfigureInput(ScriptableRenderPassInput.Normal | ScriptableRenderPassInput.Motion);
            }
            else
            {
                _downscalePass.SetupAmplifyOcclusion(null);
                if (skipEffects)
                {
                    _downscalePass.SetupSSAO(false);
                    _downscalePass.ConfigureInput(quality != 0 ? ScriptableRenderPassInput.Normal : ScriptableRenderPassInput.None);
                }
                else
                {
                    var ssao = stack.GetComponent<VLScreenSpaceAmbientOcclusion>();
                    _downscalePass.SetupSSAO(ssao.IsActive());
                    _downscalePass.ConfigureInput(quality != 0 | ssao.IsActive() ? ScriptableRenderPassInput.Normal : ScriptableRenderPassInput.None);
                }
            }
            renderer.EnqueuePass(_downscalePass);
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            ref var cameraData = ref renderingData.cameraData;
            if (cameraData.pixelWidth < 2 || cameraData.pixelHeight < 2) return;
            var cameraType = cameraData.cameraType;
            RecreateSystemsIfNeeded(renderer, cameraData);
            var vlRenderer = renderer as VLSRPRenderer;
            var projection = cameraData.GetProjectionMatrix();
            var view = cameraData.GetViewMatrix();
            var vp = projection * view;
            SetupDownscalePass(renderer, ref renderingData, vlRenderer.deferredLights, vp, view);
            ProFlareBatchForSRPData flareData = null;
            if (cameraType != CameraType.Preview && cameraType != CameraType.Reflection)
            {
                if (cameraData.renderType == CameraRenderType.Base)
                {
                    _vlbEntityManager.Update();
                    _vlbEntityManager.UpdateAllEntityData();
                    _vlbUpdateCachedSystem.Execute(cameraData.camera);
                    _vlbCullingSystem.Execute(cameraData.worldSpaceCameraPos, vp);
                    _vlbDrawCallSystem.Execute();
                }
                _flareSystem?.TryGetFlareData(cameraData.camera, out flareData);
            }
            _transparentPass.SetupProFlare(flareData);
            _transparentPass.Setup(vlRenderer.forwardLights, vlRenderer.deferredLights);
                        renderer.EnqueuePass(_transparentPass);
            renderer.EnqueuePass(_applyPass);
        }

        protected override void Dispose(bool disposing)
        {
            CoreUtils.Destroy(_downscaleMaterial);
            CoreUtils.Destroy(_fogMaterial);
            CoreUtils.Destroy(_ssaoMaterial);
            CoreUtils.Destroy(_subWorldMaterial);
            CoreUtils.Destroy(_boxMesh);
            _downscalePass.Dispose();
            _buffers?.Dispose();
            _subWorldPass?.Dispose();
            _planarReflectionDrawSystem?.Dispose();
            sharedPlanarReflectionManager.Release(ref _planarReflectionEntityManager);
            if (_vlbEntityManager != null)
            {
                sharedVLBEntityManager.Release(_vlbEntityManager);
                _vlbEntityManager = null;
            }
            CoreUtils.Destroy(_flareMaterial);
            _amplifyOcclusionRenderingData?.Dispose();
            CoreUtils.Destroy(_amplifyOcclusionMat);
            CoreUtils.Destroy(_amplifyOcclusionBlurMat);
            CoreUtils.Destroy(_amplifyOcclusionApplyMat);
        }

        public DownscaleSystemRendererFeature()
        {
        }
    }
}
