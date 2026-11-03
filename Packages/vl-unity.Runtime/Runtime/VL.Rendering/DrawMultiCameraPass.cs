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
            return default(int);
        }

        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public DrawMultiCameraPass()
        {
        }
    }
}
