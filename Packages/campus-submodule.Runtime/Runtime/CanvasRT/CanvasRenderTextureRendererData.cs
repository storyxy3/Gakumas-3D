namespace CanvasRT
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    [Serializable]
    [ReloadGroup]
    [ExcludeFromPreset]
    public class CanvasRenderTextureRendererData : ScriptableRendererData
    {
        public LayerMask layerMask;
        public uint actorRenderingLayer;
        protected override ScriptableRenderer Create()
        {
            return null;
        }

        public CanvasRenderTextureRendererData()
        {
        }
    }
}
