namespace Campus.Common
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class RoundBorder : BaseMeshEffect, IMaterialModifier
    {
        private static class PropertyId
        {
            public static readonly int SizeX;
            public static readonly int SizeY;
            public static readonly int IsRoundUniform;
            public static readonly int RoundTopLeft;
            public static readonly int RoundTopRight;
            public static readonly int RoundBottomLeft;
            public static readonly int RoundBottomRight;
            public static readonly int FillColor;
            public static readonly int BorderSize;
            public static readonly int BorderColor;
        }

        [SerializeField]
        private Shader _shader;
        [SerializeField]
        private Color _fillColor;
        [SerializeField]
        private Color _borderColor;
        [SerializeField]
        private float _borderSize;
        [SerializeField]
        private bool _isRoundUniform;
        [SerializeField]
        private Vector4 _round;
        private Material _material;
        private Graphic _target;
        private RectTransform _rectTransform;
        public Color FillColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Color BorderColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public float BorderSize
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool IsRoundUniform
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public Vector4 Round
        {
            get
            {
                return default(Vector4);
            }

            set
            {
            }
        }

        public float UniformRound
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
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

        public Material GetModifiedMaterial(Material baseMaterial)
        {
            return null;
        }

        private void DestroyMaterial()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public RoundBorder()
        {
        }
    }
}
