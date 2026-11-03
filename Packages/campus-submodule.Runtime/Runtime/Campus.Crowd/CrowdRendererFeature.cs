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

        private readonly ProfilingSampler _profilingSampler;
        public Settings settings;
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
        }

        public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        private CrowdSystem GetSystem(ref CameraData cameraData)
        {
            return null;
        }

        private void OnRenderPreDepth(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void OnRenderGBuffer(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void OnRenderMotionVector(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public CrowdRendererFeature()
        {
        }
    }
}
