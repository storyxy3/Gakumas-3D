namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(RectTransform))]
    public class ClippingRectFitter : QuaUIBehaviour, ILayoutSelfController, ILayoutController
    {
        public enum FitMode
        {
            None,
            FitInParent,
            EnvelopeParent
        }

        [SerializeField]
        private FitMode _mode;
        [SerializeField]
        private Vector2 _baseSize;
        [SerializeField]
        private Rect _clippingRect;
        private DrivenRectTransformTracker _tracker;
        public FitMode Mode
        {
            get
            {
                return default(FitMode);
            }

            set
            {
            }
        }

        public Vector2 BaseSize
        {
            get
            {
                return default(Vector2);
            }

            set
            {
            }
        }

        public Rect ClippingRect
        {
            get
            {
                return default(Rect);
            }

            set
            {
            }
        }

        public void SetLayoutHorizontal()
        {
        }

        public void SetLayoutVertical()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void Start()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void UpdateRect()
        {
        }

        private void SetProperty<T>(ref T currentValue, T newValue)
            where T : struct
        {
        }

        private RectTransform GetParent()
        {
            return null;
        }

        private bool IsComponentValidOnObject()
        {
            return default(bool);
        }

        private bool IsFitModeValid()
        {
            return default(bool);
        }

        private static float ClampSize(float value)
        {
            return default(float);
        }

        private static Vector2 ClampSize(Vector2 value)
        {
            return default(Vector2);
        }

        private static Rect ClampSize(Rect value)
        {
            return default(Rect);
        }

        public ClippingRectFitter()
        {
        }
    }
}
