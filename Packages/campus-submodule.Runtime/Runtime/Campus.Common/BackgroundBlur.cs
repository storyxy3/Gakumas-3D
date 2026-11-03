namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    [ExecuteAlways]
    public class BackgroundBlur : CampusUIBase
    {
        private static class PropertyId
        {
            public static readonly int Brightness;
            public static readonly int SourceOpacity;
            public static readonly int AlphaSoftness;
            public static readonly int ScaleData;
            public static readonly int MixWhiteAmountId;
        }

        [SerializeField]
        [Range(-50f, 50f)]
        private int _brightness;
        [SerializeField]
        [Range(0f, 1f)]
        private float _sourceOpacity;
        [SerializeField]
        [Range(0f, 1f)]
        private float _alphaSoftness;
        [SerializeField]
        [Range(0f, 1f)]
        private float _mixWhiteAmount;
        private bool _isBlurEnabled;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        public int Brightness
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public float SourceOpacity
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float MixWhiteAmout
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        private float GetBrightness()
        {
            return default(float);
        }

        private float GetSourceOpacity()
        {
            return default(float);
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void AddBlur()
        {
        }

        private void RemoveBlur()
        {
        }

        protected override void OnCanvasGroupChanged()
        {
        }

        public BackgroundBlur()
        {
        }
    }
}
