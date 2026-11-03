namespace Campus.Common.UIRenderer
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common.UIRenderer;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class UIRenderPass : ScriptableRenderPass
    {
        private static readonly List<ShaderTagId> ShaderTagIds;
        public static readonly string _BlurTexName;
        public static readonly int _BlurTexId;
        private static readonly RTHandle _FrameBufferHandle;
        private ProfilingSampler _profilingSampler;
        private FilteringSettings _filteringSettings;
        private RenderStateBlock _renderStateBlock;
        private FilteringSettings _2dFilteringSettings;
        private bool _isDraw2dLayer;
        private IUIRenderPassData _passData;
        private (int width, int height) _blurTextureSize;
        private KawaseBlur _blur;
        private Material _blurMaterial;
        private Texture _defaultBlurTexture;
        private RTHandle _blurTemp;
        private RTHandle[] _blurTargets;
        private int _passIndex;
        private bool _needsClear;
        private Color _clearColor;
        private CustomRenderPassData _renderPassData;
        private CustomSubPassData[] _subPassData;
        [CompilerGenerated]
        private bool _003CDrawFrameBuffer_003Ek__BackingField;
        private bool ShouldDrawBlur
        {
            get
            {
                return default(bool);
            }
        }

        public bool DrawFrameBuffer
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public UIRenderPass(LayerMask layerMask, int passIndex, bool needsCLear, Color clearColor, Material blurMaterial, Texture defaultBlurTexture)
        {
        }

        public void Dispose()
        {
        }

        public void SetBlurTextureSize(int width, int height)
        {
        }

        public void SetRenderPassData(IUIRenderPassData passData)
        {
        }

        public void SetSortingLayerRange(short from, short to)
        {
        }

        public void SetRTHandles(RTHandle[] blurTargets)
        {
        }

        public void Set2DLayerMask(LayerMask layerMask)
        {
        }

        public void Reset()
        {
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void OnDrawBaseUI(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        private void DrawBlur(CommandBuffer cmd, ref CameraData cameraData)
        {
        }
    }
}
