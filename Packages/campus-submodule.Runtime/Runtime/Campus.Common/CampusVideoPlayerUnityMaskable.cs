namespace Campus.Common
{
    using global::Campus.Common;
    using global::CriWare.CriMana;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class CampusVideoPlayerUnityMaskable : MonoBehaviour, IMaterialModifier
    {
        private static class PropertyId
        {
            public static readonly int StencilComp;
            public static readonly int Stencil;
            public static readonly int StencilOp;
            public static readonly int StencilWriteMask;
            public static readonly int StencilReadMask;
        }

        [SerializeField]
        private Shader _defaultShader;
        [SerializeField]
        private Shader _androidShader;
        private int _stencilComp;
        private int _stencil;
        private int _stencilOp;
        private int _stencilWriteMask;
        private int _stencilReadMask;
        private CampusVideoPlayer _videoPlayer;
        private Shader ActiveShader
        {
            get
            {
                return null;
            }
        }

        private void Awake()
        {
        }

        private Shader ShaderDispatch(MovieInfo movieInfo, bool additiveMode)
        {
            return null;
        }

        public Material GetModifiedMaterial(Material baseMaterial)
        {
            return null;
        }

        public CampusVideoPlayerUnityMaskable()
        {
        }
    }
}
