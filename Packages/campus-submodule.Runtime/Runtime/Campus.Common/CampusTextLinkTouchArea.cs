namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [RequireComponent(typeof(CampusText))]
    public class CampusTextLinkTouchArea : QuaUIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        [SerializeField]
        private CampusText _target;
        public Action onLinkPointerUpCallback;
        public Action<string, string> onLinkPointerDownCallback;
        protected override void Awake()
        {
        }

        void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData e)
        {
        }

        void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData e)
        {
        }

        public CampusTextLinkTouchArea()
        {
        }
    }
}
