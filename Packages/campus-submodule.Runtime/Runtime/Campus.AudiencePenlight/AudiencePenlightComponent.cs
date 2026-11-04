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
                return _hidePenlight;
            }
        }

        public bool UseColorProjection
        {
            get
            {
                return false;
            }
        }

        public Vector4[] ColorTable
        {
            [CompilerGenerated]
            get
            {
                return _003CColorTable_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CColorTable_003Ek__BackingField = value;
            }
        }

        public Vector2 ProjectionUvRectMin
        {
            get
            {
                return Vector2.zero;
            }
        }

        public Vector2 ProjectionUvRectMax
        {
            get
            {
                return Vector2.one;
            }
        }

        private void OnEnable()
        {
            ValidatePenlightData();
        }

        private void ValidatePenlightData()
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_penlightColorTable))
                _penlightColorTable = new[] { Color.white };
            ColorTable = new Vector4[8];
            for (int i = 0; i < 8; i++)
                ColorTable[i] = _penlightColorTable[i % _penlightColorTable.Length];
        }

        public AudiencePenlightComponent()
        {
        }
    }
}
