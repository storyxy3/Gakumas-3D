namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(LineRenderer))]
    public class LineImage : MaskableGraphic
    {
        private readonly struct VertexData
        {
            public readonly Vector3 pos;
            public readonly Color32 color;
            public readonly Vector2 uv;
            public VertexData(Vector3 pos, Color32 color, Vector2 uv)
            {
                this = default;
            }
        }

        private List<VertexData> _lineVertices;
        private List<int> _indices;
        private Rect? _imageRect;
        private List<UIVertex> _imageVertices;
        [SerializeField]
        private Texture _texture;
        [SerializeField]
        protected Vector2 _valueRangeMin;
        [SerializeField]
        protected Vector2 _valueRangeMax;
        [SerializeField]
        private float _simplifyTolerance;
        private LineRenderer _lineRenderer;
        public override Texture mainTexture
        {
            get
            {
                return null;
            }
        }

        public int PositionCount
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public AnimationCurve WidthCurve
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float StartWidth
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float EndWidth
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float WidthMultiplier
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public LineTextureMode TextureMode
        {
            get
            {
                return default(LineTextureMode);
            }

            set
            {
            }
        }

        public Gradient ColorGradient
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Color StartColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Color EndColor
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public override Color color
        {
            get
            {
                return default(Color);
            }

            set
            {
            }
        }

        public Vector2 ValueRangeMin
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Vector2 ValueRangeMax
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Vector2 ValueRange
        {
            get
            {
                return default(Vector2);
            }
        }

        public float SimplifyTolerance
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        private LineRenderer LineRenderer
        {
            get
            {
                return null;
            }
        }

        private static bool AreEqual<T>(T x, T y)
            where T : IEquatable<T>
        {
            return default(bool);
        }

        public void SetPositions(NativeArray<Vector3> positions)
        {
        }

        public void SetPositions(NativeSlice<Vector3> positions)
        {
        }

        public void SetPositions(Vector3[] positions)
        {
        }

        public void SetPosition(int index, Vector3 position)
        {
        }

        public void SetVerticesDirtyAndClearLineCache()
        {
        }

        private void UpdateLineVertices(bool force)
        {
        }

        protected static float InverseLerpUnclamped(float a, float b, float value)
        {
            return default(float);
        }

        private void PopulateVertices(List<Vector3> posList, List<Color32> colorList, List<Vector2> uvList, List<int> indices)
        {
        }

        private void ClearVertexCache()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        [MethodImpl(256)]
        protected Vector2 GetRelativePositionInRect(in Vector2 size, in Vector2 offset, in Vector3 pos)
        {
            return default(Vector2);
        }

        [MethodImpl(256)]
        protected static Vector2 GetPadding(in Vector2 rectSize, float lineWidth)
        {
            return default(Vector2);
        }

        [MethodImpl(256)]
        private static Vector2 GetRelativePositionInRect(in Vector2 size, in Vector2 offset, in Vector3 pos, float lineWidth)
        {
            return default(Vector2);
        }

        [MethodImpl(256)]
        private static float Lerp(float a, float b, float t, float min, float max)
        {
            return default(float);
        }

        public LineImage()
        {
        }
    }
}
