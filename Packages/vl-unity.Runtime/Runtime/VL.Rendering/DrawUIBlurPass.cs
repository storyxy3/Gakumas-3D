namespace VL.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class DrawUIBlurPass : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public LayerMask layerMask;
            public string blurSortingLayer;
            public string uiSortingLayer;
            [Range(4f, 10f)]
            public float blurSize = 7f;
            [Header("アルファブレンドするかどうか")]
            public bool useAlpha;
            public Settings()
            {
            }
        }

        public Settings settings;
        private UIBlurPass _pass;
        public Shader blurShader;
        public override void Create()
        {
            if (blurShader == null) return;
            _pass = new UIBlurPass(UnityEngine.Rendering.CoreUtils.CreateEngineMaterial(blurShader), settings);
        }

        protected override void Dispose(bool disposing)
        {
            _pass?.Dispose();
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_pass == null) return;
            _pass.Setup(renderer.cameraColorTargetHandle);
            renderer.EnqueuePass(_pass);
        }

        public DrawUIBlurPass()
        {
        }
    }
}
