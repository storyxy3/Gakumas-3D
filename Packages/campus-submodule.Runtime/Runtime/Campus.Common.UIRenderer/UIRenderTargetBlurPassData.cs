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
            this.src = src;
            this.dst = dst;
            this.descriptor = descriptor;
            this.blurSize = blurSize;
        }

        public UIRenderTargetBlurPassData(Texture src, RTHandle dst, RenderTextureDescriptor descriptor, int blurSize)
        {
            this.src = src;
            this.dst = dst;
            this.descriptor = descriptor;
            this.blurSize = blurSize;
        }
    }
}
