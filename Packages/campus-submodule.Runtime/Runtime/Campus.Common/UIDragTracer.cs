namespace Campus.Common
{
    using global::System.Runtime.InteropServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class UIDragTracer : UIBehaviour
    {
        private static readonly Vector3[] _worldCorners;
        [SerializeField]
        private DragGesture _gesture;
        [SerializeField]
        private RectTransform _tracer;
        [SerializeField]
        private RectTransform _traceableRect;
        public Vector3 BeginPosition;
        private Canvas _cachedRootCanvas;
        private Vector2 _screenSpaceTargetDistance;
        public RectTransform Tracer
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public RectTransform TraceableRect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected override void Awake()
        {
        }

        public void Bind(DragGesture gesture, [Optional] RectTransform tracer)
        {
        }

        public void UnBind()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        public void UpdateStartDistance()
        {
        }

        private void OnBeginDrag()
        {
        }

        private void OnDrag()
        {
        }

        private bool ScreenToWorldPoint(in Vector2 screenPoint, out Vector3 worldPosition)
        {
            throw null;
        }

        private void AdjustTraceableRect(ref Vector2 screenPosition)
        {
        }

        public UIDragTracer()
        {
        }
    }
}
