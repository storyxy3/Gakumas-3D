namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.UI;

    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(Graphic))]
    public class Blendable : CampusUIBase
    {
        private static class PropertyId
        {
            public static readonly int BlendMode;
        }

        public enum Blend
        {
            Normal,
            Add,
            Darken,
            Multiply,
            Lighten,
            Screen,
            ColorDodge
        }

        [SerializeField]
        private Blend _mode;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public Blend Mode
        {
            get
            {
                return default(Blend);
            }

            set
            {
            }
        }

        protected override void OnDisable()
        {
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        protected override void OnBlendModeSet(Material material)
        {
        }

        public static (BlendOp, BlendMode, BlendMode) GetBlendModeValue(Blend blend)
        {
            return default((BlendOp, BlendMode, BlendMode));
        }

        public Blendable()
        {
        }
    }
}
