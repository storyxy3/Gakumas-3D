namespace Campus.AudiencePenlight
{
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;

    [ExecuteAlways]
    [RequireComponent(typeof(AudiencePenlightVolume))]
    public class AudiencePenlightTimeline : MonoBehaviour, IAudiencePenlight
    {
        [SerializeField]
        private bool useColorProjection;
        [SerializeField]
        private Vector4[] colorTable;
        [SerializeField]
        private Vector2 projectionUvRectMin;
        [SerializeField]
        private Vector2 projectionUvRectMax;
        public bool UseColorProjection
        {
            get
            {
                return useColorProjection;
            }
        }

        public Vector4[] ColorTable
        {
            get
            {
                return colorTable;
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            get
            {
                return projectionUvRectMin;
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            get
            {
                return projectionUvRectMax;
            }
        }

        private void Awake()
        {
            useColorProjection = false;
            SetPenlightColorTable(null);
        }

        public void SetUsePenlightColorProjection(bool useColorProjection)
        {
            this.useColorProjection = useColorProjection;
        }

        public void SetPenlightColorTable(Color[] colorTable)
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(colorTable)) colorTable = new[] { Color.white };
            this.colorTable = new Vector4[8];
            for (int i = 0; i < 8; i++) this.colorTable[i] = colorTable[i % colorTable.Length];
        }

        public void SetPenlightProjectionUvRect(Vector2 min, Vector2 max)
        {
            projectionUvRectMin = Vector2.Min(min, max);
            projectionUvRectMax = Vector2.Max(min, max);
        }

        public AudiencePenlightTimeline()
        {
        }
    }
}
