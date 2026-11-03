namespace Qua.VectorUI
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    public class RadarChart : MaskableGraphic
    {
        [SerializeField]
        [Range(0f, 1f)]
        private float[] _values;
        [SerializeField]
        private float _angleOffset;
        private bool _isPointDirty;
        private readonly List<Vector3> _points;
        public float[] Values
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        internal List<Vector3> Points
        {
            get
            {
                return null;
            }
        }

        public override void SetVerticesDirty()
        {
        }

        private void CalculatePoints()
        {
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        public RadarChart()
        {
        }
    }
}
