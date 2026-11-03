namespace Qua.VectorUI
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class SimpleRoundLine : SharedMaterialGraphic<SimpleRoundLine>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass6_0
        {
            public Rect r;
            public VertexHelper vh;
            public Color32 color32;
            public SimpleRoundLine _003C_003E4__this;
            public Vector2 offset;
            public Vector2 size;
        }

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

        [CompilerGenerated]
        private void _003COnPopulateMesh_003Eg__AddVert_007C6_0(Vector3 pos, Vector2 uv, ref _003C_003Ec__DisplayClass6_0 P_2)
        {
        }
    }
}
