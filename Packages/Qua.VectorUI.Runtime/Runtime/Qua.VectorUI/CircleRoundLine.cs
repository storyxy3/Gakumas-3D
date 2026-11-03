namespace Qua.VectorUI
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class CircleRoundLine : SharedMaterialGraphic<CircleRoundLine, bool>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_003Ec__DisplayClass30_0
        {
            public Vector2 offset;
            public VertexHelper vh;
            public Color32 color32;
            public CircleRoundLine _003C_003E4__this;
            public float angle;
            public int partition;
            public Vector2 size;
            public float cos;
            public float sin;
        }

        private static Material _partitionMaterial;
        private static int _partitionMaterialCount;
        [SerializeField]
        [Range(0f, 1f)]
        private float _ratio;
        [SerializeField]
        private float _pivot;
        [SerializeField]
        private float _offset;
        [SerializeField]
        private float _thickness;
        [SerializeField]
        private float _blur;
        [SerializeField]
        private int _partition;
        protected override string ShaderName
        {
            get
            {
                return null;
            }
        }

        public float Ratio
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float Pivot
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float Offset
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float Thickness
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

        public int Partition
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        protected override bool GetMaterialKey()
        {
            return default(bool);
        }

        protected override Material CreateMaterial()
        {
            return null;
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        public CircleRoundLine()
        {
        }

        [CompilerGenerated]
        private void _003COnPopulateMesh_003Eg__AddVert_007C30_0(Vector3 pos, ref _003C_003Ec__DisplayClass30_0 P_1)
        {
        }

        [CompilerGenerated]
        private Vector2 _003COnPopulateMesh_003Eg__Rotate_007C30_1(float x, float y, ref _003C_003Ec__DisplayClass30_0 P_2)
        {
            return default(Vector2);
        }
    }
}
