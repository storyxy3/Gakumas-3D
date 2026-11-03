namespace Qua.VectorUI
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class Circle : SharedMaterialGraphic<Circle>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass10_0
        {
            public Circle _003C_003E4__this;
            public float linearBorderColorFloatRg;
            public float linearBorderColorFloatBa;
            public Color32 color32;
            public Vector2 offset;
            public Vector2 size;
            public VertexHelper vh;
        }

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

        public Circle()
        {
        }

        [CompilerGenerated]
        private void _003COnPopulateMesh_003Eg__AddVert_007C10_0(float posX, float posY, ref _003C_003Ec__DisplayClass10_0 P_2)
        {
        }

        [CompilerGenerated]
        private void _003COnPopulateMesh_003Eg__AddVertBorder_007C10_1(float posX, float posY, ref _003C_003Ec__DisplayClass10_0 P_2)
        {
        }
    }
}
