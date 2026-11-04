namespace VL
{
    internal static class ShaderIDs
    {
        internal static readonly int _MainTex = UnityEngine.Shader.PropertyToID("_MainTex");
        internal static readonly int _OutlineParam = UnityEngine.Shader.PropertyToID("_OutlineParam");
        internal static readonly int _FogParams = UnityEngine.Shader.PropertyToID("_VLFogParams");
        internal static readonly int _FogColor = UnityEngine.Shader.PropertyToID("_VLFogColor");
        internal static readonly int _HeightFogColor = UnityEngine.Shader.PropertyToID("_VLHeightFogColor");
        internal static readonly int _ActorIndex = UnityEngine.Shader.PropertyToID("_ActorIndex");
        internal static readonly int _MultiplyColor = UnityEngine.Shader.PropertyToID("_MultiplyColor");
        internal static readonly int _MultiplyOutlineColor = UnityEngine.Shader.PropertyToID("_MultiplyOutlineColor");
        internal static readonly int _HeadDirection = UnityEngine.Shader.PropertyToID("_HeadDirection");
        internal static readonly int _HeadUpDirection = UnityEngine.Shader.PropertyToID("_HeadUpDirection");
        internal static readonly int _HeadXAxisReflectionMatrix = UnityEngine.Shader.PropertyToID("_HeadXAxisReflectionMatrix");
    }
}
