namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    public class QuaScrollRect : ScrollRect
    {
        [CompilerGenerated]
        private bool _003CIsDragging_003Ek__BackingField;
        public Action onPotentialDrag;
        public Action onBeginDrag;
        public Action onEndDrag;
        public Action onRectChanged;
        private bool _isDragEnabled;
        private bool _elasticOnlyDragging;
        private Rect _previousRect;
        [CompilerGenerated]
        private MouseButtonType _003CInputMouseButton_003Ek__BackingField;
        public bool IsDragging
        {
            [CompilerGenerated]
            get
            {
                return _003CIsDragging_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CIsDragging_003Ek__BackingField = value;
            }
        }

        public bool IsDragEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public MouseButtonType InputMouseButton
        {
            [CompilerGenerated]
            get
            {
                return _003CInputMouseButton_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CInputMouseButton_003Ek__BackingField = value;
            }
        }

        public void SetDragEnabled(bool isDragEnabled)
        {
        }

        public void SetElasticOnlyDragging(bool isEnabled)
        {
        }

        public override void OnInitializePotentialDrag(PointerEventData eventData)
        {
        }

        public override void OnBeginDrag(PointerEventData eventData)
        {
        }

        public override void OnDrag(PointerEventData eventData)
        {
        }

        public override void OnEndDrag(PointerEventData eventData)
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public QuaScrollRect()
        {
        }
    }
}
