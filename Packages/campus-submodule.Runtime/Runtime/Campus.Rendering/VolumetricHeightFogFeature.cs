namespace Campus.Rendering
{
    using global::Campus.Rendering;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class VolumetricHeightFogFeature : ScriptableRendererFeature
    {
        public VolumetricHeightFogSettings Settings = new VolumetricHeightFogSettings();
        public Shader FogShader;
        private DrawVolumetricHeightFogPass _drawPass;
        private BlitVolumetricHeightFogPass _blitPass;
        public override void Create()
        {
            if (FogShader == null)
                return;
            Material material = CoreUtils.CreateEngineMaterial(FogShader);
            _drawPass = new DrawVolumetricHeightFogPass(Settings);
            _blitPass = new BlitVolumetricHeightFogPass(material, Settings);
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_drawPass == null)
                return;
            CameraType cameraType = renderingData.cameraData.cameraType;
            if (cameraType == CameraType.Preview || cameraType == CameraType.Reflection)
                return;
            renderer.EnqueuePass(_drawPass);
            renderer.EnqueuePass(_blitPass);
        }

        public VolumetricHeightFogFeature()
        {
        }
    }
}
