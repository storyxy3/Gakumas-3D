namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(RectTransform))]
    [DefaultExecutionOrder(100)]
    public abstract class RectTransformModifierBase : QuaUIBehaviour
    {
        private Canvas _rootCanvas;
        private RectTransform _rootCanvasTransform;
        private CanvasScaler _rootCanvasScaler;
        private RectTransformEventTrigger _trigger;
        private Vector2 _prevSize;
        private bool _aspectDirty;
        private bool _isUpdatingRect;
        protected Canvas RootCanvas
        {
            get
            {
                return null;
            }
        }

        protected RectTransform RootCanvasTransform
        {
            get
            {
                return null;
            }
        }

        protected CanvasScaler RootCanvasScaler
        {
            get
            {
                return null;
            }
        }

        private void CacheCanvas(Canvas canvas)
        {
        }

        private Canvas SearchRootCanvas()
        {
            return null;
        }

        public void SetAspectDirty()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected virtual void LateUpdate()
        {
        }

        protected override void OnDestroy()
        {
        }

        public void UpdateRect()
        {
        }

        protected abstract void UpdateRect(RectTransform rectTransform, RectTransform rootCanvasTransform);
        private void BindCanvasEvent(Canvas rootCanvas)
        {
        }

        private void Unbind()
        {
        }

        private void OnCanvasRectChanged(RectTransform canvasRectTransform)
        {
        }

        protected virtual void ClearCanvasCaches()
        {
        }

        protected RectTransformModifierBase()
        {
        }
    }
}
