namespace VL.Rendering
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class DrawVLActor : ScriptableRendererFeature
    {
        [Serializable]
        public class Settings
        {
            public LayerMask mask;
            public Settings()
            {
            }
        }

        public Settings settings;
        private VLActorParameterPass _actorParameterPass;
        private VLActorForward _pass;
        private VLActorTransparentPass _transparentPass;
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public DrawVLActor()
        {
        }
    }
}
