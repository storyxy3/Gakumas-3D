namespace Qua.VectorUI
{
    using global::System;
    using global::Qua.Utility;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.Events;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [RequireComponent(typeof(CanvasRenderer))]
    public class RoundedPolyline : MaskableGraphic
    {
        private static class PropertyId
        {
            public static readonly int Thickness;
            public static readonly int StartPointStartIndex;
            public static readonly int StartPointEndIndex;
            public static readonly int StartPoint;
            public static readonly int IsStartSquare;
            public static readonly int EndPointStartIndex;
            public static readonly int EndPointEndIndex;
            public static readonly int EndPoint;
            public static readonly int IsEndSquare;
        }

        [Serializable]
        public class Vertex
        {
            public Vector2 point;
            [Vector2Anchor]
            public Vector2 anchor;
            public float radius;
            public Vector2 GetAnchoredPoint(in Rect area)
            {
                return default(Vector2);
            }

            public void SetAnchoredPoint(in Vector2 pos, in Rect area)
            {
            }

            public Vertex()
            {
            }
        }

        public enum VertexPositionType
        {
            Local,
            Anchor
        }

        public enum EndCapType
        {
            Round,
            Square,
            SquareToRound
        }

        [SerializeField]
        private Shader _shader;
        [SerializeField]
        private VertexPositionType _positionType;
        [SerializeField]
        private Vertex[] _vertices;
        [SerializeField]
        private float _thickness;
        [SerializeField]
        [Range(0f, 1f)]
        private float _startRatio;
        [SerializeField]
        private EndCapType _startCap;
        private bool _isStartRatioDirty;
        private Vector2Int _startPointRange;
        private Vector2 _startPoint;
        [SerializeField]
        [Range(0f, 1f)]
        private float _endRatio;
        [SerializeField]
        private EndCapType _endCap;
        private bool _isEndRatioDirty;
        private Vector2Int _endPointRange;
        private Vector2 _endPoint;
        [SerializeField]
        private bool _autoAdjustRect;
        private DrivenRectTransformTracker _tracker;
        private bool _isAdjustingRect;
        private bool _isRectDirty;
        private Rect _parentRect;
        private RoundedPolylineMesh _polylineMesh;
        private Material _material;
        public VertexPositionType PositionType
        {
            get
            {
                return default(VertexPositionType);
            }
        }

        internal Vertex[] Vertices
        {
            get
            {
                return null;
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
        }

        public float StartRatio
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float EndRatio
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        internal RoundedPolylineMesh PolylineMesh
        {
            get
            {
                return null;
            }
        }

        public override Material materialForRendering
        {
            get
            {
                return null;
            }
        }

        internal event UnityAction OnDirtyVertsCallback
        {
            add
            {
            }

            remove
            {
            }
        }

        protected override void OnEnable()
        {
        }

        public void SetupForCurrentPositionType()
        {
        }

        protected override void OnDisable()
        {
        }

        private void LateUpdate()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void SetMaterialProperty<T>(ref T currentValue, T newValue, ref bool isDirty)
            where T : struct
        {
        }

        private void UpdateStartPoint()
        {
        }

        private void UpdateEndPoint()
        {
        }

        private void DestroyMaterial()
        {
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        public override void SetVerticesDirty()
        {
        }

        public void SetRectDirty()
        {
        }

        public void AdjustRect()
        {
        }

        private Rect GetParentRect()
        {
            return default(Rect);
        }

        public Vector2 GetVertexPoint(int index)
        {
            return default(Vector2);
        }

        public void SetVertexPoint(int index, Vector2 pos)
        {
        }

        public RoundedPolyline()
        {
        }
    }
}
