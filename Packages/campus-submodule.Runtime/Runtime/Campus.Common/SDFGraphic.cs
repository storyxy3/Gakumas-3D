namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(Graphic))]
    public class SDFGraphic : CampusUIBase
    {
        private static class PropertyId
        {
            public static readonly int FaceColor;
            public static readonly int FaceDilate;
            public static readonly int OutlineColor;
            public static readonly int OutlineWidth;
            public static readonly int OutlineSoftness;
        }

        [SerializeField]
        private Color _faceColor;
        [SerializeField]
        private Color _outlineColor;
        [SerializeField]
        [Range(0f, 1f)]
        private float _outlineRatio;
        [SerializeField]
        [Range(0f, 1f)]
        private float _outlineSoftness;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public Color FaceColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Color OutlineColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public float OutlineRatio
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float OutlineSoftness
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        public SDFGraphic()
        {
        }
    }
}
