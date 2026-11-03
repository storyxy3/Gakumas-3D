namespace Campus.Live.Monitor
{
    using global::System;
    using global::Campus.Common;
    using global::CanvasRT;
    using global::Cinemachine;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [ExecuteAlways]
    [AddComponentMenu("UI/Monitor3DImage", 100)]
    public class Monitor3DImage : UIBehaviour
    {
        public CinemachineVirtualCamera targetCamera;
        public CampusVirtualActorController virtualActorController;
        private CanvasRenderTexture _canvasRenderTexture;
        [NonSerialized]
        private RectTransform _rectTransform;
        public Canvas canvas
        {
            get
            {
                return null;
            }
        }

        public RectTransform rectTransform
        {
            get
            {
                return null;
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public Rect GetRect()
        {
            return default(Rect);
        }

        public Rect GetViewportRect()
        {
            return default(Rect);
        }

        public Monitor3DImage()
        {
        }
    }
}
