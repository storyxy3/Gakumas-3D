namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;

    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Graphics))]
    public class ColorPaint : CampusUIBase
    {
        private static class PropertyId
        {
            public static readonly int PaintColor;
            public static readonly int PaintMode;
        }

        public enum PaintMode
        {
            Single,
            Add
        }

        [SerializeField]
        private Color _color;
        [FormerlySerializedAs("_blendMode")]
        [SerializeField]
        private PaintMode _paintMode;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public Color Color
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        public ColorPaint()
        {
        }
    }
}
