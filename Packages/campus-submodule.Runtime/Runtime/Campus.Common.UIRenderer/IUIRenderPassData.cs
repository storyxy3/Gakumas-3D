namespace Campus.Common.UIRenderer
{
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;

    public interface IUIRenderPassData
    {
        int LayerValue { get; }

        int BackgroundBlurSize { get; }

        Vector3 HsvOffset { get; }

        bool HasRenderPassType(UIRenderPassType flag);
    }
}
