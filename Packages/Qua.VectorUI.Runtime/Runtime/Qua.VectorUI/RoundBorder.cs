namespace Qua.VectorUI
{
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class RoundBorder : SharedMaterialGraphic<RoundBorder>
    {
        [SerializeField]
        private Color _borderColor;
        [SerializeField]
        private float _borderSize;
        [SerializeField]
        public bool _isRoundUniform;
        [SerializeField]
        private Vector4 _round;
        [SerializeField]
        private float _blur;
        protected override string ShaderName
        {
            get
            {
                return null;
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

        public RoundBorder()
        {
        }
    }
}
