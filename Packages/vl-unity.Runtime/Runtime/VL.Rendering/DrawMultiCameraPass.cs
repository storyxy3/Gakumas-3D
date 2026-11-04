namespace VL.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class DrawMultiCameraPass : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public string[] shaderPasses;
            public Settings()
            {
            }
        }

        public const int MaxMultiCamera = 2;
        public Settings settings;
        public Shader maskShader;
        private MultiCameraMaskPass[] _maskPasses;
        private MultiCameraPass[] _cameraPasses;
        public static int GetMultiCameraStencil(int index)
        {
            switch (index)
            {
                case 0: return 8;
                case 1: return 16;
                case 2: return 24;
                default: Debug.LogError("InvalidIndex"); return 0;
            }
        }

        public override void Create()
        {
            if (settings == null || settings.shaderPasses == null || maskShader == null) return;
            _maskPasses = new MultiCameraMaskPass[2];
            _cameraPasses = new MultiCameraPass[4];
            for (int i = 0; i < 2; i++)
            {
                int stencil = GetMultiCameraStencil(i);
                var material = UnityEngine.Rendering.CoreUtils.CreateEngineMaterial(maskShader);
                material.SetFloat("_StencilRef", stencil);
                _maskPasses[i] = new MultiCameraMaskPass(i, material);
                _cameraPasses[i * 2] = new MultiCameraPass(i, stencil, RenderPassEvent.AfterRenderingOpaques, settings);
                _cameraPasses[i * 2 + 1] = new MultiCameraPass(i, stencil, RenderPassEvent.AfterRenderingTransparents, settings);
            }
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_cameraPasses == null || _maskPasses == null) return;
            var camera = renderingData.cameraData.camera;
            if (!camera.TryGetComponent<VLMultiCamera>(out var multiCamera)) return;
            for (int i = 0; i < 2; i++)
            {
                var data = multiCamera.GetCameraData(i);
                if (data.camera == null) continue;
                _maskPasses[i].Setup(camera, data);
                renderer.EnqueuePass(_maskPasses[i]);
                _cameraPasses[i * 2].Setup(camera, data);
                renderer.EnqueuePass(_cameraPasses[i * 2]);
                _cameraPasses[i * 2 + 1].Setup(camera, data);
                renderer.EnqueuePass(_cameraPasses[i * 2 + 1]);
            }
        }

        public DrawMultiCameraPass()
        {
        }
    }
}
