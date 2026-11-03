namespace Campus.Common
{
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.UI;

    public abstract class CampusUIBase : QuaUIBehaviour, IMaterialModifier
    {
        private static class PropertyId
        {
            public static readonly int BlendOp;
            public static readonly int BlendSrcFactor;
            public static readonly int BlendDstFactor;
        }

        [SerializeField]
        private Shader _shader;
        protected Graphic _graphic;
        protected Material _material;
        protected UISharedHub _hub;
        private CampusCanvas _canvas;
        protected abstract string MainKeyword { get; }

        public Graphic Graphic
        {
            get
            {
                return null;
            }
        }

        public CampusCanvas Canvas
        {
            get
            {
                return null;
            }
        }

        protected override void Awake()
        {
        }

        protected virtual Shader GetRuntimeShader()
        {
            return null;
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public Material GetModifiedMaterial(Material baseMaterial)
        {
            return null;
        }

        protected virtual bool ShouldSkipModify()
        {
            return default(bool);
        }

        protected abstract void OnMaterialModified(Material material);
        protected virtual void OnBlendModeSet(Material material)
        {
        }

        protected static void SetBlendMode(Material material, BlendOp op, BlendMode src, BlendMode dst)
        {
        }

        public void SetDirty()
        {
        }

        public void SetMaterialDirty()
        {
        }

        public void SetVerticesDirty()
        {
        }

        protected void DestroyMaterial()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected CampusUIBase()
        {
        }
    }
}
