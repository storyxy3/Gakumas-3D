namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class UIRenderTargetBlurManager : MonoBehaviour
    {
        private List<UIRenderTargetBlurPassData> _passData;
        public IReadOnlyList<UIRenderTargetBlurPassData> FinalPassDatas
        {
            get
            {
                return null;
            }
        }

        public void Add(RTHandle src, RTHandle dst, RenderTextureDescriptor descriptor, int blurSize)
        {
        }

        public void Add(Texture src, RTHandle dst, int blurSize)
        {
        }

        public void Clear()
        {
        }

        public UIRenderTargetBlurManager()
        {
        }
    }
}
