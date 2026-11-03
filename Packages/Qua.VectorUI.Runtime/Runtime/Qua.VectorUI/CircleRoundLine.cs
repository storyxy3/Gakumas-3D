namespace Qua.VectorUI
{
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class CircleRoundLine : SharedMaterialGraphic<CircleRoundLine, bool>
    {
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
    }
}
