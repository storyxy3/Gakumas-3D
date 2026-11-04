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
                if (ReferenceEquals(_rectTransform, null)) _rectTransform = GetComponent<RectTransform>();
                return _canvasRenderTexture.Canvas;
            }
        }

        public RectTransform rectTransform
        {
            get
            {
                if (ReferenceEquals(_rectTransform, null)) _rectTransform = GetComponent<RectTransform>();
                return _rectTransform;
            }
        }

        protected override void OnEnable()
        {
            _canvasRenderTexture = GetComponentInParent<CanvasRenderTexture>();
            if (_canvasRenderTexture == null) Debug.LogError("親階層にCanvasRenderTextureが付いていません");
            else _canvasRenderTexture.RegisterMonitor3D(this);
        }

        protected override void OnDisable()
        {
            if (_canvasRenderTexture != null) _canvasRenderTexture.UnregisterMonitor3D(this);
        }

        public Rect GetRect()
        {
            return rectTransform.rect;
        }

        public Rect GetViewportRect()
        {
            var current = rectTransform;
            var position = Vector2.zero;
            while (current != null)
            {
                position += (Vector2)current.localPosition;
                current = current.parent as RectTransform;
            }
            var rect = rectTransform.rect;
            var canvasRect = canvas.pixelRect;
            return new Rect(position.x + (canvasRect.width - rect.width) * 0.5f,
                position.y + (canvasRect.height - rect.height) * 0.5f, rect.width, rect.height);
        }

        public Monitor3DImage()
        {
        }
    }
}
