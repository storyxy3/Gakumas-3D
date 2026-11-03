namespace Qua.VectorUI
{
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class SimpleRoundLine : SharedMaterialGraphic<SimpleRoundLine>
    {
        [SerializeField]
        private float _blur;
        protected override string ShaderName
        {
            get
            {
                return null;
            }
        }

        public float Blur
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        public SimpleRoundLine()
        {
        }
    }
}
