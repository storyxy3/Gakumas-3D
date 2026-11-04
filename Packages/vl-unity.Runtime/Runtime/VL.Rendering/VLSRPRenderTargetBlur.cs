namespace VL.Rendering
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    [RequireComponent(typeof(Camera))]
    public class VLSRPRenderTargetBlur : MonoBehaviour
    {
        public struct BlurRequest
        {
            public readonly float blurSize;
            public readonly RTHandle source;
            public readonly RenderTextureDescriptor sourceDescriptor;
            public readonly RTHandle destination;
        }

        private List<BlurRequest> _blurRequests;
        public List<BlurRequest> Requests
        {
            get
            {
                return _blurRequests;
            }
        }

        public void Add(BlurRequest target)
        {
            if (_blurRequests == null) _blurRequests = new List<BlurRequest>();
            _blurRequests.Add(target);
        }

        public bool Remove(BlurRequest target)
        {
            return _blurRequests != null && _blurRequests.Remove(target);
        }

        public void Clear()
        {
            _blurRequests?.Clear();
        }

        public VLSRPRenderTargetBlur()
        {
        }
    }
}
