namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class UIRenderResultCopyManager : MonoBehaviour
    {
        private List<RTHandle> _renderTargets;
        public IReadOnlyList<RTHandle> RenderTargets
        {
            get
            {
                return null;
            }
        }

        public void Add(RTHandle target)
        {
        }

        public void Clear()
        {
        }

        public UIRenderResultCopyManager()
        {
        }
    }
}
