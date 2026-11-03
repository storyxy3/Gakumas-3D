namespace Campus.AudiencePenlight
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.AudiencePenlight;
    using global::UnityEngine;

    [ExecuteAlways]
    [RequireComponent(typeof(AudiencePenlightVolume))]
    public class AudiencePenlightComponent : MonoBehaviour, IAudiencePenlight
    {
        [SerializeField]
        private bool _hidePenlight;
        [ColorUsage(false, true)]
        [SerializeField]
        private Color[] _penlightColorTable;
        [CompilerGenerated]
        private Vector4[] _003CColorTable_003Ek__BackingField;
        public bool HidePenlight
        {
            get
            {
                return default(bool);
            }
        }

        public bool UseColorProjection
        {
            get
            {
                return default(bool);
            }
        }

        public Vector4[] ColorTable
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
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

        private void OnEnable()
        {
        }

        private void ValidatePenlightData()
        {
        }

        public AudiencePenlightComponent()
        {
        }
    }
}
