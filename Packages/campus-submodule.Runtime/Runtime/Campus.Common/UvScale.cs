namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    [ExecuteAlways]
    public class UvScale : CampusUIBase
    {
        private static class PropertyId
        {
            public static readonly int ScaleData;
        }

        [SerializeField]
        [Range(0.5f, 1.5f)]
        private float _scale;
        [SerializeField]
        private Vector2 _scalePivot;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public float Scale
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Vector2 ScalePivot
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        public UvScale()
        {
        }
    }
}
