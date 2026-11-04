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

        public Settings settings = new Settings();
        private VLActorParameterPass _actorParameterPass;
        private VLActorForward _pass;
        private VLActorTransparentPass _transparentPass;
        public override void Create()
        {
            _actorParameterPass = new VLActorParameterPass();
            _pass = new VLActorForward(settings.mask);
            _transparentPass = new VLActorTransparentPass(settings.mask);
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            var universalRenderer = renderer as UniversalRenderer;
            if (renderingData.cameraData.renderType == CameraRenderType.Base)
                renderer.EnqueuePass(_actorParameterPass);
            if (universalRenderer.renderingModeActual == RenderingMode.Forward)
            {
                renderer.EnqueuePass(_pass);
                renderer.EnqueuePass(_transparentPass);
            }
        }

        public DrawVLActor()
        {
        }
    }
}
