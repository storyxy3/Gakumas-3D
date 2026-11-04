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
        private Vector2 _uvScale = new Vector2(1f, 1f);
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
                return _uvScale;
            }

            set
            {
                if (_uvScale != value)
                {
                    _uvScale = value;
                    SetVerticesDirty();
                }
            }
        }

        public float Time
        {
            get
            {
                return _time;
            }

            set
            {
                if (_time != value)
                {
                    _time = value;
                    SetVerticesDirty();
                }
            }
        }

        public Vector2 ScrollOffset
        {
            get
            {
                return _scrollOffset;
            }

            set
            {
                if (_scrollOffset != value)
                {
                    _scrollOffset = value;
                    SetVerticesDirty();
                }
            }
        }

        public Vector2 ScrollSpeed
        {
            get
            {
                return _scrollSpeed;
            }

            set
            {
                if (_scrollSpeed != value)
                {
                    _scrollSpeed = value;
                    SetVerticesDirty();
                }
            }
        }

        public Sprite sprite2
        {
            get
            {
                return _sprite2;
            }
        }

        private Vector4 GetDrawingDimensions2()
        {
            var padding = sprite != null ? global::UnityEngine.Sprites.DataUtility.GetPadding(sprite) : Vector4.zero;
            var spriteRect = sprite != null ? sprite.rect : Rect.zero;
            var rect = GetPixelAdjustedRect();
            int width = Mathf.RoundToInt(spriteRect.width);
            int height = Mathf.RoundToInt(spriteRect.height);
            var bounds = new Vector4(padding.x / width, padding.y / height, (width - padding.z) / width, (height - padding.w) / height);
            return new Vector4(rect.x + rect.width * bounds.x, rect.y + rect.height * bounds.y,
                rect.x + rect.width * bounds.z, rect.y + rect.height * bounds.w);
        }

        private void Update()
        {
            if (_scrollSpeed.sqrMagnitude > 0.0001f) SetVerticesDirty();
        }

        private Vector4 GetUVOffset(Vector4 uv, bool lastX, bool lastY, Vector2 offsetByTime, Vector4 vOffset, Vector2 size)
        {
            float width = uv.z - uv.x;
            if (lastX)
            {
                uv.x = uv.z - width * offsetByTime.x;
                uv.z -= width * Mathf.Max(0f, offsetByTime.x - _uvScale.x);
            }
            else uv.z = uv.x + width * ((vOffset.z - vOffset.x) / size.x);
            float height = uv.w - uv.y;
            if (lastY)
            {
                uv.y = uv.w - height * offsetByTime.y;
                uv.w -= height * Mathf.Max(0f, offsetByTime.y - _uvScale.y);
            }
            else uv.w = uv.y + height * ((vOffset.w - vOffset.y) / size.y);
            return uv;
        }

        protected override void OnPopulateMesh(VertexHelper toFill)
        {
            if (sprite == null)
            {
                base.OnPopulateMesh(toFill);
                return;
            }
            _uvScale = new Vector2(Mathf.Max(0.01f, _uvScale.x), Mathf.Max(0.01f, _uvScale.y));
            var bounds = GetDrawingDimensions2();
            var offset = _scrollSpeed * _time + _scrollOffset;
            offset = new Vector2((offset.x % 1f + 1f) % 1f, (offset.y % 1f + 1f) % 1f);
            bool offsetX = !Mathf.Approximately(0f, offset.x);
            bool offsetY = !Mathf.Approximately(0f, offset.y);
            var uv = sprite != null ? global::UnityEngine.Sprites.DataUtility.GetOuterUV(sprite) : Vector4.zero;
            var uv2 = _sprite2 != null ? global::UnityEngine.Sprites.DataUtility.GetOuterUV(_sprite2) : Vector4.zero;
            Color32 tint = color;
            toFill.Clear();
            int columns = Mathf.CeilToInt(_uvScale.x) + (offsetX ? 1 : 0);
            int rows = Mathf.CeilToInt(_uvScale.y) + (offsetY ? 1 : 0);
            var size = new Vector2((bounds.z - bounds.x) / _uvScale.x, (bounds.w - bounds.y) / _uvScale.y);
            for (int i = 0; i < columns * rows; i++)
            {
                int x = i % columns;
                int y = i / columns;
                bool lastX = offsetX && x == columns - 1;
                bool lastY = offsetY && y == rows - 1;
                if (lastX) x = -1;
                if (lastY) y = -1;
                var shift = new Vector2(size.x * (offset.x + x), size.y * (offset.y + y));
                var vertices = new Vector4(Mathf.Clamp(bounds.x + shift.x, bounds.x, bounds.z),
                    Mathf.Clamp(bounds.y + shift.y, bounds.y, bounds.w),
                    Mathf.Clamp(bounds.x + size.x + shift.x, bounds.x, bounds.z),
                    Mathf.Clamp(bounds.y + size.y + shift.y, bounds.y, bounds.w));
                var firstUV = GetUVOffset(uv, lastX, lastY, offset, vertices, size);
                var secondUV = GetUVOffset(uv2, lastX, lastY, offset, vertices, size);
                toFill.AddVert(new Vector3(vertices.x, vertices.y, 0f), tint, new Vector4(firstUV.x, firstUV.y, 0f, 0f),
                    new Vector4(secondUV.x, secondUV.y, 0f, 0f), Vector3.back, new Vector4(1f, 0f, 0f, -1f));
                toFill.AddVert(new Vector3(vertices.x, vertices.w, 0f), tint, new Vector4(firstUV.x, firstUV.w, 0f, 0f),
                    new Vector4(secondUV.x, secondUV.w, 0f, 0f), Vector3.back, new Vector4(1f, 0f, 0f, -1f));
                toFill.AddVert(new Vector3(vertices.z, vertices.w, 0f), tint, new Vector4(firstUV.z, firstUV.w, 0f, 0f),
                    new Vector4(secondUV.z, secondUV.w, 0f, 0f), Vector3.back, new Vector4(1f, 0f, 0f, -1f));
                toFill.AddVert(new Vector3(vertices.z, vertices.y, 0f), tint, new Vector4(firstUV.z, firstUV.y, 0f, 0f),
                    new Vector4(secondUV.z, secondUV.y, 0f, 0f), Vector3.back, new Vector4(1f, 0f, 0f, -1f));
                toFill.AddTriangle(i * 4, i * 4 + 1, i * 4 + 2);
                toFill.AddTriangle(i * 4 + 2, i * 4 + 3, i * 4);
            }
        }

        public MonitorRepeatImage()
        {
        }
    }
}
