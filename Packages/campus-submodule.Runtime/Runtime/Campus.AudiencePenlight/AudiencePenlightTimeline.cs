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
                return default(bool);
            }
        }

        public Vector4[] ColorTable
        {
            get
            {
                return null;
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            get
            {
                return default(Vector2);
            }
        }

        private void Awake()
        {
        }

        public void SetUsePenlightColorProjection(bool useColorProjection)
        {
        }

        public void SetPenlightColorTable(Color[] colorTable)
        {
        }

        public void SetPenlightProjectionUvRect(Vector2 min, Vector2 max)
        {
        }

        public AudiencePenlightTimeline()
        {
        }
    }
}
