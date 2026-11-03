namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;

    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(RectTransform))]
    public class ScreenFitter : QuaUIBehaviour
    {
        [Serializable]
        public struct Padding
        {
            [SerializeField]
            public float left;
            [SerializeField]
            public float right;
            [SerializeField]
            public float top;
            [SerializeField]
            public float bottom;
            public float HorizontalPadding
            {
                get
                {
                    return default(float);
                }
            }

            public float VerticalPadding
            {
                get
                {
                    return default(float);
                }
            }

            public Padding(float left, float right, float top, float bottom)
            {
                this = default;
            }
        }

        [Serializable]
        public struct ScreenOrientationPadding
        {
            [SerializeField]
            public Padding landscapeLeft;
            [SerializeField]
            public Padding landscapeRight;
            [SerializeField]
            public Padding portrait;
            [SerializeField]
            public Padding portraitUpsideDown;
            public Padding GetPadding(ScreenOrientation orientation)
            {
                return default(Padding);
            }
        }

        private Canvas _rootCanvas;
        private RectTransformEventTrigger _canvasResizedTrigger;
        [SerializeField]
        public bool useMaxSize;
        [SerializeField]
        public Vector2 maxSize;
        [SerializeField]
        public Vector2 fitLimitSize;
        [SerializeField]
        public bool useScreenOrientation;
        [SerializeField]
        public Padding padding;
        [SerializeField]
        public ScreenOrientationPadding orientationPadding;
        public Canvas RootCanvas
        {
            get
            {
                return null;
            }
        }

        public RectTransformEventTrigger CanvasResizedTrigger
        {
            get
            {
                return null;
            }
        }

        public Padding GetPadding()
        {
            return default(Padding);
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected void OnChange(RectTransform canvasRect)
        {
        }

        public void UpdateRect()
        {
        }

        public void UpdateRect(RectTransform rootCanvasTransform, Padding padding)
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        private void ClearCanvasCaches()
        {
        }

        private void BindCanvasEvent()
        {
        }

        private void Unbind()
        {
        }

        public ScreenFitter()
        {
        }
    }
}
