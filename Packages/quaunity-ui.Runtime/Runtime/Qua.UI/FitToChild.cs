namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    public class FitToChild : QuaUIBehaviour, ILayoutGroup, ILayoutController, ILayoutElement
    {
        [SerializeField]
        private RectTransform _child;
        [SerializeField]
        private RectOffset _padding;
        [SerializeField]
        private TextAnchor _childAlignment;
        [SerializeField]
        private bool _controlSelfSize;
        [SerializeField]
        private Vector2 _maxSize;
        private DrivenRectTransformTracker _tracker;
        [CompilerGenerated]
        private float _003CminWidth_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CpreferredWidth_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CflexibleWidth_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CminHeight_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CpreferredHeight_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CflexibleHeight_003Ek__BackingField;
        public float minWidth
        {
            [CompilerGenerated]
            get
            {
                return _003CminWidth_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CminWidth_003Ek__BackingField = value;
            }
        }

        public float preferredWidth
        {
            [CompilerGenerated]
            get
            {
                return _003CpreferredWidth_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CpreferredWidth_003Ek__BackingField = value;
            }
        }

        public float flexibleWidth
        {
            [CompilerGenerated]
            get
            {
                return _003CflexibleWidth_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CflexibleWidth_003Ek__BackingField = value;
            }
        }

        public float minHeight
        {
            [CompilerGenerated]
            get
            {
                return _003CminHeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CminHeight_003Ek__BackingField = value;
            }
        }

        public float preferredHeight
        {
            [CompilerGenerated]
            get
            {
                return _003CpreferredHeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CpreferredHeight_003Ek__BackingField = value;
            }
        }

        public float flexibleHeight
        {
            [CompilerGenerated]
            get
            {
                return _003CflexibleHeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CflexibleHeight_003Ek__BackingField = value;
            }
        }

        public int layoutPriority
        {
            get
            {
                return default(int);
            }
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

        private void SetDirty()
        {
        }

        public void SetLayoutHorizontal()
        {
        }

        public void SetLayoutVertical()
        {
        }

        private float GetAlignmentOnAxis(int axis)
        {
            return default(float);
        }

        private void SetLayout(int axis)
        {
        }

        public void CalculateLayoutInputHorizontal()
        {
        }

        public void CalculateLayoutInputVertical()
        {
        }

        private void CalculateLayoutInput(int axis)
        {
        }

        public FitToChild()
        {
        }
    }
}
