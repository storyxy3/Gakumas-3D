namespace Qua.UI
{
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(CanvasRenderer))]
    public class CircleTouchArea : Graphic
    {
        private readonly Vector3[] _localCorners;
        public override bool Raycast(Vector2 sp, Camera eventCamera)
        {
            return default(bool);
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
        }

        public CircleTouchArea()
        {
        }
    }
}
