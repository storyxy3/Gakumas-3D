namespace Qua.VectorUI
{
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class Ellipse : SharedMaterialGraphic<Ellipse>
    {
        [SerializeField]
        private Color _borderColor;
        [SerializeField]
        private float _borderSize;
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

        protected override string ShaderName
        {
            get
            {
                return null;
            }
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        public Ellipse()
        {
        }
    }
}
