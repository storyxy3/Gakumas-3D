namespace VLB
{
    using global::UnityEngine;
    using global::VLB;

    public class PolygonHelper : MonoBehaviour
    {
        public struct Plane2D
        {
            public Vector2 normal;
            public float distance;
            public float Distance(Vector2 point)
            {
                return default(float);
            }

            public Vector2 Intersect(Vector2 p1, Vector2 p2)
            {
                return default(Vector2);
            }

            public bool GetSide(Vector2 point)
            {
                return default(bool);
            }

            public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
            {
                return default(Plane2D);
            }

            public void Flip()
            {
            }

            public Vector2[] CutConvex(Vector2[] poly)
            {
                return null;
            }

            public override string ToString()
            {
                return null;
            }
        }

        public PolygonHelper()
        {
        }
    }
}
