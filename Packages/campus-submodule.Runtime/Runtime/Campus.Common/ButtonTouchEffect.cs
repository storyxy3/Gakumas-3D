namespace Campus.Common
{
    using global::Campus.Common;
    using global::DG.Tweening;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Graphic))]
    public class ButtonTouchEffect : CampusUIBase, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        private static class PropertyId
        {
            public static readonly int TouchPosition;
            public static readonly int Intensity;
        }

        private Vector2? _touchPosition;
        private float _intensity;
        private Tween _fadeOutTween;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        protected override bool ShouldSkipModify()
        {
            return default(bool);
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
        }

        public void OnDrag(PointerEventData eventData)
        {
        }

        public void OnEndDrag(PointerEventData eventData)
        {
        }

        public void OnPointerDown(PointerEventData eventData)
        {
        }

        public void OnPointerUp(PointerEventData eventData)
        {
        }

        private void UpdateTouchPosition(PointerEventData eventData)
        {
        }

        private void FadeOutEffect()
        {
        }

        public ButtonTouchEffect()
        {
        }
    }
}
