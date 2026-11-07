namespace AmplifyOcclusion
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    [DisallowMultipleRendererFeature(null)]
    public class AmplifyOcclusionRendererFeature : ScriptableRendererFeature
    {
        public Shader occlusionShader;
        public Shader blurShader;
        public Shader applyOcclusionShader;
        private AmplifyOcclusionPass _pass;
        private Material _occlusionMat;
        private Material _blurMat;
        private Material _applyOcclusionMat;
        public override void Create()
        {
            if (occlusionShader == null || blurShader == null || applyOcclusionShader == null)
                return;
            _occlusionMat = CoreUtils.CreateEngineMaterial(occlusionShader);
            _blurMat = CoreUtils.CreateEngineMaterial(blurShader);
            _applyOcclusionMat = CoreUtils.CreateEngineMaterial(applyOcclusionShader);
            _pass = new AmplifyOcclusionPass(_occlusionMat, _blurMat, _applyOcclusionMat);
            if (!_pass.Initialize())
            {
                _pass.Dispose();
                _pass = null;
            }
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_pass == null)
                return;
            var settings = VolumeManager.instance.stack.GetComponent<global::AmplifyOcclusion.AmplifyOcclusion>();
            if (settings == null)
                return;
            if (settings.IsActive())
            {
                _pass.Setup(settings, ref renderingData.cameraData);
                renderer.EnqueuePass(_pass);
            }
        }

        protected override void Dispose(bool disposing)
        {
            CoreUtils.Destroy(_occlusionMat);
            CoreUtils.Destroy(_blurMat);
            CoreUtils.Destroy(_applyOcclusionMat);
            if (_pass != null)
                _pass.Dispose();
            _pass = null;
        }

        public AmplifyOcclusionRendererFeature()
        {
        }
    }
}
