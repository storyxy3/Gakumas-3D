namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [RequireComponent(typeof(Graphic))]
    public class LinearGradient : CampusUIBase
    {
        private static class PropertyId
        {
            public static readonly int Positions;
            public static readonly int Colors;
        }

        [Serializable]
        public class ColorStep
        {
            public Vector2 position;
            public Color color;
            public ColorStep()
            {
            }
        }

        public const int MaxStep = 3;
        private const string DitherKeyword = "LINEAR_GRADIENT_DITHER";
        public static readonly Color[] DefaultColors;
        [SerializeField]
        private ColorStep[] _colorSteps;
        [SerializeField]
        private bool _isDithering;
        private Vector4[] _positions;
        private Vector4[] _colors;
        private Vector2 _canvasScale;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public ColorStep[] ColorSteps
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool IsEmpty
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsDithering
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        protected override void Start()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        private Vector3 GetGlobalPosition(Vector2 position, Vector2 halfsize)
        {
            return default(Vector3);
        }

        public Vector3 GetWorldPosition(Vector2 position)
        {
            return default(Vector3);
        }

        private Vector3 GetWorldPosition(Vector2 position, Vector2 halfsize)
        {
            return default(Vector3);
        }

        public Vector2 GetRelativePosition(Vector3 worldPosition)
        {
            return default(Vector2);
        }

        private Vector2 GetRelativePosition(Vector3 worldPosition, Vector2 halfsize)
        {
            return default(Vector2);
        }

        private static Vector3 GetExtraPoint(Vector3 a, Vector3 b, float extraDistance)
        {
            return default(Vector3);
        }

        public void ClampStraightLine()
        {
        }

        public static Vector3 ClampedNearestPointOnLine(Vector3 a, Vector3 b, Vector3 value)
        {
            return default(Vector3);
        }

        public LinearGradient()
        {
        }
    }
}
