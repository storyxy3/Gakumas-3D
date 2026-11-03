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
            public int renderingLayer;
            public float depthBias;
            public float normalBias;
            public float far;
            [Range(0.1f, 0.9f)]
            public float fade;
            public int size;
            public Settings()
            {
            }
        }

        public Settings settings;
        private ActorShadowPass _pass;
        public override void Create()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public DrawActorShadowPass()
        {
        }
    }
}
