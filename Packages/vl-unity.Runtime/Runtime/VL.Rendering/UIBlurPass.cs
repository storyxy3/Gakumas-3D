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

        private readonly ProfilingSampler _uiBlurProfilingSampler = new ProfilingSampler("UIBlur");
        private readonly ProfilingSampler _uiProfilingSampler = new ProfilingSampler("UI");
        private static readonly string _UITextureName = "_UITexture";
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
            renderPassEvent = RenderPassEvent.AfterRenderingTransparents;
            _material = material;
            _blur = new DownsampleBlur("_UIBlur", material, 0, 1);
            _blurFilteringSettings = new FilteringSettings(RenderQueueRange.transparent, settings.layerMask);
            short blurLayer = (short)SortingLayer.GetLayerValueFromName(settings.blurSortingLayer);
            _blurFilteringSettings.sortingLayerRange = new SortingLayerRange(blurLayer, blurLayer);
            _uiFilteringSettings = new FilteringSettings(RenderQueueRange.transparent, settings.layerMask);
            short uiLayer = (short)SortingLayer.GetLayerValueFromName(settings.uiSortingLayer);
            _uiFilteringSettings.sortingLayerRange = new SortingLayerRange(uiLayer, uiLayer);
            _stateBlock = default;
            _blurSize = settings.blurSize;
            _useAlpha = settings.useAlpha;
            _shaderTagIds = new List<ShaderTagId>();
            _shaderTagIds.Add(new ShaderTagId("UniversalForward"));
            _shaderTagIds.Add(new ShaderTagId("LightweightForward"));
            _shaderTagIds.Add(new ShaderTagId("SRPDefaultUnlit"));
        }

        public void Dispose()
        {
            _uiTexture?.Release();
            _uiBlurTexture?.Release();
        }

        public void Setup(RTHandle colorTexture)
        {
            _colorTexture = colorTexture;
        }

        private RTHandle DrawUIBlur(ref ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawSettings, CommandBuffer cmd, BlurTargetType blurTargetType)
        {
            if (blurTargetType == BlurTargetType.None)
            {
                CoreUtils.SetRenderTarget(cmd, _colorTexture);
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                return null;
            }
            var descriptor = renderingData.cameraData.cameraTargetDescriptor;
            descriptor.width >>= 1;
            descriptor.height >>= 1;
            descriptor.msaaSamples = 1;
            descriptor.graphicsFormat = (UnityEngine.Experimental.Rendering.GraphicsFormat)4;
            RenderingUtils.ReAllocateIfNeeded(ref _uiTexture, descriptor, FilterMode.Bilinear, TextureWrapMode.Repeat, name: _UITextureName);
            CoreUtils.SetRenderTarget(cmd, _uiTexture, ClearFlag.Color, Color.clear);
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            if (HasFlag(blurTargetType, BlurTargetType.Blur))
                context.DrawRenderers(renderingData.cullResults, ref drawSettings, ref _blurFilteringSettings, ref _stateBlock);
            if (HasFlag(blurTargetType, BlurTargetType.UI))
                context.DrawRenderers(renderingData.cullResults, ref drawSettings, ref _uiFilteringSettings, ref _stateBlock);
            _blur.ApplyBlur(cmd, _uiTexture, descriptor, ref _uiBlurTexture, _blurSize);
            Blitter.BlitCameraTexture(cmd, _uiBlurTexture, _colorTexture, _material, _useAlpha ? EnableAlphaPass : DisableAlphaPass);
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            return _uiBlurTexture;
        }

        private void DrawUI(ref ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawSettings, CommandBuffer cmd, BlurTargetType blurTargetType, RTHandle blurTarget)
        {
            if (!HasFlag(blurTargetType, BlurTargetType.Blur))
            {
                context.DrawRenderers(renderingData.cullResults, ref drawSettings, ref _blurFilteringSettings, ref _stateBlock);
                if (HasFlag(blurTargetType, BlurTargetType.UI) && blurTarget != null)
                {
                    Vector2 scale = blurTarget.useScaling ? new Vector2(blurTarget.rtHandleProperties.rtHandleScale.x, blurTarget.rtHandleProperties.rtHandleScale.y) : Vector2.one;
                    Blitter.BlitTexture(cmd, blurTarget, new Vector4(scale.x, scale.y, 0f, 0f), _material, EnableAlphaPass);
                }
            }
            if (!HasFlag(blurTargetType, BlurTargetType.UI))
                context.DrawRenderers(renderingData.cullResults, ref drawSettings, ref _uiFilteringSettings, ref _stateBlock);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var targetType = VLSRPDrawUIBlurPassSetting.HasInstance ? VLSRPDrawUIBlurPassSetting.Instance.BlurTargetType : BlurTargetType.Blur;
            var drawingSettings = CreateDrawingSettings(_shaderTagIds, ref renderingData, SortingCriteria.CommonTransparent);
            var cmd = CommandBufferPool.Get();
            RTHandle blurTarget;
            using (new ProfilingScope(cmd, _uiBlurProfilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                blurTarget = DrawUIBlur(ref context, ref renderingData, ref drawingSettings, cmd, targetType);
            }
            context.ExecuteCommandBuffer(cmd);
            cmd.Clear();
            using (new ProfilingScope(cmd, _uiProfilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                DrawUI(ref context, ref renderingData, ref drawingSettings, cmd, targetType, blurTarget);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        [MethodImpl(256)]
        private static bool HasFlag(BlurTargetType mask, BlurTargetType flag)
        {
            return (mask & flag) == flag;
        }
    }
}
