namespace Campus.Common
{
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;

    [ExecuteAlways]
    [RequireComponent(typeof(Canvas), typeof(CampusCanvasScaler), typeof(CampusGraphicRaycaster))]
    public class CampusCanvas : QuaUIBehaviour
    {
        public enum CanvasDirection
        {
            Vertical,
            Horizontal
        }

        private static readonly Vector2 VerticalResolution;
        private static readonly Vector2 HorizontalResolution;
        [SerializeField]
        private CanvasDirection _direction;
        [SerializeField]
        private Canvas _canvas;
        private int? _sortingLayerID;
        [SerializeField]
        private CampusCanvasScaler _canvasScaler;
        private int _blurRefCount;
        private int? _overrideBlurSize;
        private Vector3? _overrideHsvOffset;
        public CanvasDirection Direction
        {
            get
            {
                return default(CanvasDirection);
            }

            set
            {
            }
        }

        public int LayerId
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int LayerValue
        {
            get
            {
                return default(int);
            }
        }

        public int OrderInLayer
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int? OverrideBlurSize
        {
            get
            {
                return null;
            }
        }

        public Vector3? OverrideHsvOffset
        {
            get
            {
                return null;
            }
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        internal void ApplySetting()
        {
        }

        public void AddBackgroundBlur()
        {
        }

        public void RemoveBackgroundBlur()
        {
        }

        private void UpdateBackgroundBlur()
        {
        }

        public int GetBlurSize()
        {
            return default(int);
        }

        public void SetBlurSize(int blurSize)
        {
        }

        public Vector3 GetBlurHsvOffset()
        {
            return default(Vector3);
        }

        public void SetBlurHsvOffset(Vector3 hsvOffset)
        {
        }

        public CampusCanvas()
        {
        }
    }
}
