namespace Campus.Common.UIRenderer
{
    using global::Campus.Common;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class UIRenderTargetBlurPass : ScriptableRenderPass
    {
        private ProfilingSampler _profilingSampler;
        private KawaseBlur _blur;
        private UIRenderTargetBlurManager _manager;
        private RTHandle[] _blurTargets;
        public UIRenderTargetBlurPass(Material blurMaterial)
        {
        }

        public void SetManager(UIRenderTargetBlurManager manager)
        {
        }

        public void SetRTHandles(RTHandle[] blurTargets)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
