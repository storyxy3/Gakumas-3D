namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    [ExecuteAlways]
    public class TouchRectDrawer : MaskableGraphic
    {
        private static readonly UIVertex[] Vertices;
        [SerializeField]
        private float _lineWidth;
        private IReadOnlyList<BaseRaycaster> _raycasters;
        private List<Graphic> _targets;
        private List<Component> _components;
        private HashSet<Canvas> _excludeCanvases;
        private List<Canvas> _canvases;
        private static readonly Lazy<Func<List<BaseRaycaster>>> GetRaycasters;
        public float LineWidth
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDestroy()
        {
        }

        private void CacheRaycasterList()
        {
        }

        private void Update()
        {
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        private void AddFrame(VertexHelper helper, Graphic target)
        {
        }

        private void AddLine(VertexHelper helper, ref Vector2 start, ref Vector2 end)
        {
        }

        private void FindTargetGraphics(GraphicRaycaster raycaster, List<Graphic> targetList)
        {
        }

        private bool IsRaycastTarget(Transform graphicTransform)
        {
            return default(bool);
        }

        private void RemoveInvalidExcludeCanvases()
        {
        }

        public void AddExcludeCanvas(Canvas canvas)
        {
        }

        public void RemoveExcludeCanvas(Canvas canvas)
        {
        }

        public TouchRectDrawer()
        {
        }
    }
}
