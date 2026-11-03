namespace Common
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class VerticesMultiplier : BaseMeshEffect
    {
        [SerializeField]
        protected Color _multiplyColor;
        private Graphic _graphicCache;
        public Color MultiplyColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        private Graphic GraphicCache
        {
            get
            {
                return null;
            }
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public void SetVerticesDirty()
        {
        }

        protected override void OnDestroy()
        {
        }

        public VerticesMultiplier()
        {
        }
    }
}
