namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.Events;

    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class RectTransformEventTrigger : QuaUIBehaviour
    {
        [Serializable]
        public class RectTransformEvent : UnityEvent<RectTransform>
        {
            public RectTransformEvent()
            {
            }
        }

        [SerializeField]
        public RectTransformEvent onRectTransformDimensionsChange;
        [SerializeField]
        public RectTransformEvent onBeforeTransformParentChanged;
        [SerializeField]
        public RectTransformEvent onTransformParentChanged;
        [SerializeField]
        public RectTransformEvent onDidApplyAnimationProperties;
        [SerializeField]
        public RectTransformEvent onCanvasGroupChanged;
        [SerializeField]
        public RectTransformEvent onCanvasHierarchyChanged;
        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected override void OnBeforeTransformParentChanged()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        protected override void OnCanvasGroupChanged()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        public RectTransformEventTrigger()
        {
        }
    }
}
