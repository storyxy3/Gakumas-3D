namespace Campus.Live.Monitor
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [AddComponentMenu("UI/MonitorRepeatImage", 100)]
    public class MonitorRepeatImage : Image
    {
        [SerializeField]
        private Sprite _sprite2;
        [SerializeField]
        private Vector2 _uvScale;
        [SerializeField]
        private float _time;
        [SerializeField]
        private Vector2 _scrollOffset;
        [SerializeField]
        private Vector2 _scrollSpeed;
        public Vector2 UvScale
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public float Time
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Vector2 ScrollOffset
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Vector2 ScrollSpeed
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Sprite sprite2
        {
            get
            {
                return null;
            }
        }

        private Vector4 GetDrawingDimensions2()
        {
            return default(Vector4);
        }

        private void Update()
        {
        }

        private Vector4 GetUVOffset(Vector4 uv, bool lastX, bool lastY, Vector2 offsetByTime, Vector4 vOffset, Vector2 size)
        {
            return default(Vector4);
        }

        protected override void OnPopulateMesh(VertexHelper toFill)
        {
        }

        public MonitorRepeatImage()
        {
        }
    }
}
