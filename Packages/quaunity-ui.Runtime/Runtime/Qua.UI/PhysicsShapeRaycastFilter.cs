namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Image))]
    public class PhysicsShapeRaycastFilter : QuaUIBehaviour, ICanvasRaycastFilter
    {
        private readonly List<Vector2> _verts;
        private Image _image;
        private Image Image
        {
            get
            {
                return null;
            }
        }

        public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
        {
            return default(bool);
        }

        private bool IsInPolygon(List<Vector2> polygon, Vector2 p)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static float CrossProduct(Vector2 u, Vector2 v)
        {
            return default(float);
        }

        public PhysicsShapeRaycastFilter()
        {
        }
    }
}
