namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public abstract class GraphicMaskBase : CampusUIBase, IMeshModifier
    {
        private static class PropertyId
        {
            public static readonly int MaskTex;
            public static readonly int Invert;
            public static readonly int MaskMinAlpha;
            public static readonly int MaskTex_Mode;
            public static readonly int MaskTex_WorldToMask;
            public static readonly int MaskTex_Rect;
            public static readonly int MaskTex_UvRect;
            public static readonly int MaskTex_BorderRect;
            public static readonly int MaskTex_UvBorderRect;
            public static readonly int MaskTex_TileRepeat;
        }

        private const string GpuModeKeyword = "GRAPHIC_MASK_GPU";
        [SerializeField]
        private bool _isInvert;
        private float _minAlpha;
        [CompilerGenerated]
        private MaskUtility.ClippingType _003CClippingType_003Ek__BackingField;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public bool IsInvert
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public float MinAlpha
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public MaskUtility.ClippingType ClippingType
        {
            [CompilerGenerated]
            get
            {
                return default(MaskUtility.ClippingType);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void OnTransformChanged()
        {
        }

        protected override bool ShouldSkipModify()
        {
            return default(bool);
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        public void ModifyMesh(Mesh mesh)
        {
        }

        public void ModifyMesh(VertexHelper vh)
        {
        }

        private MaskUtility.ClippingType GetClippingType()
        {
            return default(MaskUtility.ClippingType);
        }

        protected void OnTargetMaterialDirty()
        {
        }

        protected void OnTargetQuadDirty()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected abstract void AddTargetEvent();
        protected abstract void RemoveTargetEvent();
        protected abstract bool IsTargetValid();
        protected abstract bool IsTargetCull();
        protected abstract bool IsGpuMode();
        protected abstract MaskGpuUtility.GpuData GetGpuData();
        protected abstract bool IsMaskAreaChanged();
        protected abstract Texture GetTargetTexture();
        protected abstract MaskUtility.ClippingType GetTargetClippingType();
        protected abstract bool IsTargetHullCheck();
        protected abstract void ProcessUIQuads(List<MaskUtility.UIQuad> source, List<MaskUtility.UIQuad> output);
        protected abstract void ProcessUIVertices(List<MaskUtility.UIVertexMini> source, bool isHullOnly, List<MaskUtility.UIVertexMini> output);
        protected GraphicMaskBase()
        {
        }
    }
}
