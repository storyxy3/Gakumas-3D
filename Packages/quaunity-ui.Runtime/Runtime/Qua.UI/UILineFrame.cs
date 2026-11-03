namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    public class UILineFrame : MaskableGraphic
    {
        public enum CornerType
        {
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        public enum CornerUvType
        {
            InnerBottomLeft,
            InnerTopRight,
            OuterBottomLeft,
            OuterTopRight
        }

        [Serializable]
        private class CornerData
        {
            [SerializeField]
            public Vector2 padding;
            [SerializeField]
            public float width;
            public Vector3 GetInnerPadding(bool isBottom, bool isLeft)
            {
                return default(Vector3);
            }

            public Vector3 GetOuterMargin(bool isBottom, bool isLeft)
            {
                return default(Vector3);
            }

            public CornerData()
            {
            }
        }

        [Serializable]
        private class CornerUV
        {
            [SerializeField]
            public Vector2 innerBottomLeft;
            [SerializeField]
            public Vector2 innerTopRight;
            [FormerlySerializedAs("outerBottonLeft")]
            [SerializeField]
            public Vector2 outerBottomLeft;
            [SerializeField]
            public Vector2 outerTopRight;
            public Vector2 GetUV(bool isBottom, bool isLeft, bool isInner)
            {
                return default(Vector2);
            }

            public CornerUV()
            {
            }
        }

        [SerializeField]
        private Texture2D _mainTexture;
        [SerializeField]
        private CornerUV _lineUV;
        [SerializeField]
        private CornerData _topLeft;
        [SerializeField]
        private CornerData _topRight;
        [SerializeField]
        private CornerData _bottomLeft;
        [SerializeField]
        private CornerData _bottomRight;
        private readonly Vector3[] _localCorners;
        public override Texture mainTexture
        {
            get
            {
                return null;
            }
        }

        public float GetWidth(CornerType cornerType)
        {
            return default(float);
        }

        public void SetWidth(CornerType cornerType, float width)
        {
        }

        public Vector2 GetPadding(CornerType cornerType)
        {
            return default(Vector2);
        }

        public void SetPadding(CornerType cornerType, in Vector2 padding)
        {
        }

        private CornerData GetCorner(CornerType cornerType)
        {
            return null;
        }

        public Vector2 GetUv(CornerUvType cornerUvType)
        {
            return default(Vector2);
        }

        public void SetUv(CornerUvType cornerUvType, in Vector2 uv)
        {
        }

        private unsafe ref Vector2 GetCornerUvRef(CornerUvType cornerUvType)
        {
            throw null;
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        private void BuildVerticesRoughness(List<UIVertex> resultVertexList)
        {
        }

        private UIVertex CreateVertex(in Vector3 baseCorner, CornerData cornerData, bool isBottom, bool isLeft, bool isInner)
        {
            return default(UIVertex);
        }

        [MethodImpl(256)]
        private static void AddTriangle(List<UIVertex> resultVertexList, in UIVertex v0, in UIVertex v1, in UIVertex v2, in UIVertex v3)
        {
        }

        private void SetVertexProperty<T>(ref T currentValue, in T newValue)
            where T : struct
        {
        }

        public UILineFrame()
        {
        }
    }
}
