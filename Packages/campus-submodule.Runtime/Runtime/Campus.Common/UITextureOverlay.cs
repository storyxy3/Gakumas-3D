namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class UITextureOverlay : BaseMeshEffect, IMaterialModifier
    {
        public enum OverlayPivotType
        {
            Center,
            Left,
            Right,
            Top,
            Bottom,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        [Serializable]
        public class OverlayTransform
        {
            [SerializeField]
            public OverlayPivotType anchor;
            [SerializeField]
            public OverlayPivotType pivot;
            [SerializeField]
            public Vector2 position;
            [SerializeField]
            public Vector2 scale;
            [SerializeField]
            public float rotationZ;
            public OverlayTransform()
            {
            }
        }

        private static class PropertyId
        {
            public static readonly int OverlayTexture;
            public static readonly int OverlayColor;
            public static readonly int OverlayMatrix;
            public static readonly int OverlayUv;
            public static readonly int BaseImageRect;
            public static readonly int BlendOp;
            public static readonly int BlendSrcFactor;
            public static readonly int BlendDstFactor;
            public static readonly int BlendMode;
        }

        private static class ShaderKeyword
        {
            public static readonly string PositionAsOverlayUv;
            public static readonly string ClampOverlayUv;
            public static readonly string AlphaMaskOverlay;
        }

        [SerializeField]
        private Shader _shader;
        [SerializeField]
        private Texture2D _overlayTexture;
        [SerializeField]
        private Sprite _overlaySprite;
        [SerializeField]
        private OverlayTransform _overlay;
        [SerializeField]
        private Color _overlayColor;
        [SerializeField]
        private bool _clampOverlayUv;
        [SerializeField]
        private bool _alphaMask;
        [SerializeField]
        private Blendable.Blend _mode;
        private Material _material;
        private RectTransform _cachedTransform;
        public Shader Shader
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Texture2D OverlayTexture
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Sprite OverlaySprite
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual OverlayPivotType OverlayAnchor
        {
            get
            {
                return default(OverlayPivotType);
            }

            set
            {
            }
        }

        public virtual OverlayPivotType OverlayPivot
        {
            get
            {
                return default(OverlayPivotType);
            }

            set
            {
            }
        }

        public virtual Vector2 OverlayPosition
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public virtual Vector2 OverlayScale
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public virtual float OverlayRotationZ
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Color OverlayColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public bool ClampOverlayUv
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public Blendable.Blend Mode
        {
            get
            {
                return default(Blendable.Blend);
            }

            set
            {
            }
        }

        public RectTransform RectTransform
        {
            get
            {
                return null;
            }
        }

        protected Texture GetOverlayTexture()
        {
            return null;
        }

        protected Vector4 GetOverlayUv()
        {
            return default(Vector4);
        }

        protected Vector2 GetOverlayTextureSize()
        {
            return default(Vector2);
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public Material GetModifiedMaterial(Material baseMaterial)
        {
            return null;
        }

        private void UpdateCopiedMaterial(Material baseMaterial)
        {
        }

        private void UpdateOverlayMatrix(Texture texture)
        {
        }

        private void UpdateShaderKeyword(string keyword, bool isEnabled)
        {
        }

        protected virtual float4x4 CalculateOverlayMatrix(Texture overlayTexture, in Vector4 overlayTextureUv, in Vector2 baseImageSize)
        {
            return default(float4x4);
        }

        protected static float4x4 CalculateOverlayMatrix(Texture overlayTexture, in Vector4 overlayTextureUv, in Vector2 baseImageSize, in float2 pivotOffset, in float2 anchorOffset, OverlayTransform overlayTransform)
        {
            return default(float4x4);
        }

        [MethodImpl(256)]
        protected static float2 PivotTypeToOffset(OverlayPivotType pivotType)
        {
            return default(float2);
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        [MethodImpl(256)]
        protected void SetMaterialDirtyIfDirty(bool isDirty)
        {
        }

        [MethodImpl(256)]
        private void SetAllDirtyIfDirty(bool isDirty)
        {
        }

        private void DestroyMaterial()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected Vector2 GetOverlayFitScale()
        {
            return default(Vector2);
        }

        public virtual void FitHeightScale()
        {
        }

        public virtual void FitWidthScale()
        {
        }

        protected virtual void FitXYScale(bool isShrink)
        {
        }

        public void FitExpandScale()
        {
        }

        public void FitShrinkScale()
        {
        }

        protected virtual void ResetScale()
        {
        }

        private static bool SetColor(ref Color currentValue, Color newValue)
        {
            return default(bool);
        }

        private static bool SetStruct<T>(ref T currentValue, T newValue)
            where T : struct
        {
            return default(bool);
        }

        private static bool SetClass<T>(ref T currentValue, T newValue)
            where T : class
        {
            return default(bool);
        }

        public UITextureOverlay()
        {
        }
    }
}
