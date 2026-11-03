namespace Qua.VectorUI
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class RoundBorder : SharedMaterialGraphic<RoundBorder>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass25_0
        {
            public RoundBorder _003C_003E4__this;
            public Color32 color32;
            public Vector2 offset;
            public Vector2 size;
            public Color32 linearBorderColor;
            public VertexHelper vh;
        }

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

        [CompilerGenerated]
        private void _003COnPopulateMesh_003Eg__AddVert_007C25_0(float posX, float posY, ref _003C_003Ec__DisplayClass25_0 P_2)
        {
        }

        [CompilerGenerated]
        private void _003COnPopulateMesh_003Eg__AddVertBorder_007C25_1(float posX, float posY, ref _003C_003Ec__DisplayClass25_0 P_2)
        {
        }
    }
}
