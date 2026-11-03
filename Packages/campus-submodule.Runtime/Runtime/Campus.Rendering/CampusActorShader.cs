namespace Campus.Rendering
{
    public static class CampusActorShader
    {
        public enum ShaderType
        {
            Opaque,
            Cutout,
            Transparent,
            EyeBase,
            Eye,
            EyeHighlight,
            FaceParts,
            FacialParts,
            Hair,
            Face
        }

        public static class Property
        {
            public static readonly string _BaseMap;
            public static readonly string _BaseColor;
            public static readonly string _ShadeMap;
            public static readonly string _RampMap;
            public static readonly string _HighlightMap;
            public static readonly string _DefMap;
            public static readonly string _DefValue;
            public static readonly string _DefDebugMask;
            public static readonly string _RenderMode;
            public static readonly string _EnableLayerMap;
            public static readonly string _LayerWeight;
            public static readonly string _LayerMap;
            public static readonly string _BumpMap;
            public static readonly string _BumpScale;
            public static readonly string _AnisotropicMap;
            public static readonly string _RampAddMap;
            public static readonly string _ShaderType;
            public static readonly string _SrcBlend;
            public static readonly string _DstBlend;
            public static readonly string _SrcAlphaBlend;
            public static readonly string _DstAlphaBlend;
            public static readonly string _ColorMask;
            public static readonly string _ZWrite;
            public static readonly string _Cull;
            public static readonly string _StencilRef;
            public static readonly string _StencilReadMask;
            public static readonly string _StencilWriteMask;
            public static readonly string _StencilComp;
            public static readonly string _StencilPass;
            public static readonly string CastShadows;
            public static readonly string ReceiveShadows;
            public static readonly string _EmissionMap;
            public static readonly string _EmissionColor;
        }
    }
}
