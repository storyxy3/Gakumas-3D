namespace VL.Rendering
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class UIBlurPass : ScriptableRenderPass
    {
        [Flags]
        public enum BlurTargetType
        {
            None = 0,
            Blur = 1,
            UI = 2
        }

        private readonly ProfilingSampler _uiBlurProfilingSampler;
        private readonly ProfilingSampler _uiProfilingSampler;
        private static readonly string _UITextureName;
        private const int EnableAlphaPass = 3;
        private const int DisableAlphaPass = 2;
        private RTHandle _uiTexture;
        private RTHandle _uiBlurTexture;
        private RTHandle _colorTexture;
        private DownsampleBlur _blur;
        private Material _material;
        private RenderStateBlock _stateBlock;
        private FilteringSettings _blurFilteringSettings;
        private FilteringSettings _uiFilteringSettings;
        private List<ShaderTagId> _shaderTagIds;
        private float _blurSize;
        private bool _useAlpha;
        public UIBlurPass(Material material, DrawUIBlurPass.Settings settings)
        {
        }

        public void Dispose()
        {
        }

        public void Setup(RTHandle colorTexture)
        {
        }

        private RTHandle DrawUIBlur(ref ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawSettings, CommandBuffer cmd, BlurTargetType blurTargetType)
        {
            return null;
        }

        private void DrawUI(ref ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawSettings, CommandBuffer cmd, BlurTargetType blurTargetType, RTHandle blurTarget)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        [MethodImpl(256)]
        private static bool HasFlag(BlurTargetType mask, BlurTargetType flag)
        {
            return default(bool);
        }
    }
}
