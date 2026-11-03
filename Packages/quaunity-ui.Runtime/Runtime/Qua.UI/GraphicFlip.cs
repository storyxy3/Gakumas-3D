namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::UnityEngine.UI;

    public class GraphicFlip : BaseMeshEffect
    {
        public enum DirectionType
        {
            None,
            Horizontal,
            Vertical,
            Both
        }

        private RectTransform _cacheRectTransform;
        [SerializeField]
        [FormerlySerializedAs("_flipType")]
        private DirectionType _direction;
        [SerializeField]
        private bool _swapXY;
        public DirectionType Direction
        {
            get
            {
                return default(DirectionType);
            }

            set
            {
            }
        }

        public bool SwapXY
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        protected override void Awake()
        {
        }

        public override void ModifyMesh(VertexHelper vh)
        {
        }

        public GraphicFlip()
        {
        }
    }
}
