namespace Campus.Common.UIRenderer
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class UIRenderResultCopyPass : ScriptableRenderPass
    {
        private ProfilingSampler _profilingSampler;
        private UIRenderResultCopyManager _manager;
        private Material _material;
        public UIRenderResultCopyPass(Material material)
        {
        }

        public void SetManager(UIRenderResultCopyManager manager)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
