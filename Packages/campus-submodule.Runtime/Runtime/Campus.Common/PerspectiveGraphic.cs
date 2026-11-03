namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [ExecuteAlways]
    [RequireComponent(typeof(PerspectiveTransform))]
    public class PerspectiveGraphic : CampusUIBase, IMeshModifier, ICanvasRaycastFilter
    {
        [SerializeField]
        private PerspectiveTransform _perspectiveTransform;
        [SerializeField]
        private bool _overrideRaycast;
        private Rect _transformedRect;
        private List<Vector2> _raycastHull;
        protected override string MainKeyword
        {
            get
            {
                return null;
            }
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public void ModifyMesh(Mesh mesh)
        {
        }

        public void ModifyMesh(VertexHelper vh)
        {
        }

        private void UpdateRaycastInfo(VertexHelper vh)
        {
        }

        private void UpdateBoundsInfo(VertexHelper vh)
        {
        }

        private void UpdateRaycastHull(VertexHelper vh)
        {
        }

        protected override void OnMaterialModified(Material material)
        {
        }

        bool UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
        {
            return default(bool);
        }

        public Bounds GetBounds()
        {
            return default(Bounds);
        }

        public PerspectiveGraphic()
        {
        }
    }
}
