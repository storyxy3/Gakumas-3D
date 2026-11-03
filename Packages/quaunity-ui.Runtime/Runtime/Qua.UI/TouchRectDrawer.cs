namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    [ExecuteAlways]
    public class TouchRectDrawer : MaskableGraphic
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public _003C_003Ec()
            {
            }

            internal Func<List<BaseRaycaster>> _003C_002Ecctor_003Eb__24_0()
            {
                return null;
            }
        }

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
