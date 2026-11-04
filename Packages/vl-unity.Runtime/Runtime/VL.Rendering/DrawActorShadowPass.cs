namespace VL.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class DrawActorShadowPass : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public LayerMask mask;
            public int renderingLayer = -1;
            public float depthBias = 2f;
            public float normalBias;
            public float far = 15f;
            [Range(0.1f, 0.9f)]
            public float fade = 0.9f;
            public int size = 1024;
            public Settings()
            {
            }
        }

        public Settings settings;
        private ActorShadowPass _pass;
        public override void Create()
        {
            if (settings == null) settings = new Settings();
            _pass = new ActorShadowPass(ref settings);
        }

        protected override void Dispose(bool disposing)
        {
            _pass?.Dispose();
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_pass == null) return;
            _pass.Setup(ref renderingData, ref settings);
            renderer.EnqueuePass(_pass);
        }

        public DrawActorShadowPass()
        {
        }
    }
}
