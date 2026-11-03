namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    [DefaultExecutionOrder(-1001)]
    public class TouchResultDrawer : MaskableGraphic
    {
        private static readonly UIVertex[] Vertices;
        private static readonly List<RaycastResult> TmpHits;
        private readonly List<RaycastResult> _firstHits;
        private readonly List<RaycastResult> _prevHits;
        [SerializeField]
        private bool _drawTouchRect;
        [SerializeField]
        private bool _dumpTouchName;
        [SerializeField]
        private Color[] _cornerColors;
        private PointerEventData _pointer;
        public bool DrawTouchRect
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public bool DumpTouchName
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        protected override void OnEnable()
        {
        }

        private void UpdateFirstHits()
        {
        }

        private void Update()
        {
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        private void AddQuad(VertexHelper helper, RaycastResult result)
        {
        }

        private Color GetCornerColor(int index)
        {
            return default(Color);
        }

        public TouchResultDrawer()
        {
        }
    }
}
