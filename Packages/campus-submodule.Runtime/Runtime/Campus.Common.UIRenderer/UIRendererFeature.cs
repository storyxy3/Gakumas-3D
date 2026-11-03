namespace Campus.Common.UIRenderer
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class UIRendererFeature : ScriptableRendererFeature
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass19_0
        {
            public int width;
            public int height;
            public _003C_003Ec__DisplayClass19_0()
            {
            }

            internal void _003CSetBlurTextureSize_003Eb__0(UIRenderPass x)
            {
            }
        }

        [SerializeField]
        private LayerMask _layerMask;
        [SerializeField]
        private LayerMask _2dLayerMask;
        [SerializeField]
        private Shader _blurShader;
        [SerializeField]
        private Texture _defaultBlurTexture;
        [SerializeField]
        private Shader _uiCopyShader;
        [SerializeField]
        [Tooltip("Clearが必要")]
        private bool _needsClear;
        [SerializeField]
        private Color _clearColor;
        private Material _blurMaterial;
        private Material _copyMaterial;
        private List<UIRenderPass> _uiRenderPasses;
        private UIRenderTargetBlurPass _renderTargetBlurPass;
        private UIRenderResultCopyPass _renderResultCopyPass;
        private RTHandle[] _blurTargets;
        private int MaxPassCount
        {
            get
            {
                return default(int);
            }
        }

        public override void Create()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        private void OnForceUpdateBlurTextureSize()
        {
        }

        private void UpdateBlurTextureSize(IVLCameraController cameraController)
        {
        }

        private void SetBlurTextureSize(int width, int height)
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        private void TryAddUIRenderPass(ScriptableRenderer renderer, ref RenderingData renderingData, bool drawFrameBuffer)
        {
        }

        private UIRenderPass GetUIRenderPass(int index)
        {
            return null;
        }

        private bool TryAddRenderTargetBlurPass(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            return default(bool);
        }

        private bool TryAddUIResultCopyPass(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            return default(bool);
        }

        public UIRendererFeature()
        {
        }
    }
}
