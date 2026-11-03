namespace Campus.Common.UIRenderer
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public struct UIRenderTargetBlurPassData
    {
        public readonly Texture src;
        public readonly RTHandle dst;
        public readonly RenderTextureDescriptor descriptor;
        public readonly int blurSize;
        public UIRenderTargetBlurPassData(RTHandle src, RTHandle dst, RenderTextureDescriptor descriptor, int blurSize)
        {
            this = default;
        }

        public UIRenderTargetBlurPassData(Texture src, RTHandle dst, RenderTextureDescriptor descriptor, int blurSize)
        {
            this = default;
        }
    }
}
