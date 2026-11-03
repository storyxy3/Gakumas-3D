namespace Qua.VectorUI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.VectorUI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    internal class RoundedPolylineMesh
    {
        internal abstract class PartsMeshInfoBase
        {
            private static readonly Stack<PartsMeshInfoBase> Pool;
            public Vector2 p1;
            public Vector2 p2;
            public abstract float Length { get; }

            public abstract Vector2 GetPoint(float length);
            public abstract void AddMesh(VertexHelper vh, int index, Color32 color);
            public void Return()
            {
            }

            protected static T Rent<T>()
                where T : PartsMeshInfoBase
            {
                return null;
            }

            protected PartsMeshInfoBase()
            {
            }
        }

        internal class EdgeMeshInfo : PartsMeshInfoBase
        {
            public Vector2 direction;
            public Vector2 wing;
            public override float Length
            {
                get
                {
                    return default(float);
                }
            }

            public static EdgeMeshInfo Rent()
            {
                return null;
            }

            public override Vector2 GetPoint(float length)
            {
                return default(Vector2);
            }

            public override void AddMesh(VertexHelper vh, int index, Color32 color)
            {
            }

            public EdgeMeshInfo()
            {
            }
        }

        internal class CornerMeshInfo : PartsMeshInfoBase
        {
            public float angle;
            public Vector2 center;
            public Vector2 outerCenter;
            public Vector2 outer1;
            public Vector2 outer2;
            public Vector2 inner1;
            public Vector2 inner2;
            public bool isClockwise;
            public float radius;
            public override float Length
            {
                get
                {
                    return default(float);
                }
            }

            public static CornerMeshInfo Rent()
            {
                return null;
            }

            public override Vector2 GetPoint(float length)
            {
                return default(Vector2);
            }

            public override void AddMesh(VertexHelper vh, int index, Color32 color)
            {
            }

            public CornerMeshInfo()
            {
            }
        }

        private readonly List<PartsMeshInfoBase> _meshes;
        private bool _isMeshDirty;
        private readonly RoundedPolyline _target;
        private readonly List<float> _meshCumulativeLengthList;
        internal IList<PartsMeshInfoBase> Meshes
        {
            get
            {
                return null;
            }
        }

        public RoundedPolylineMesh(RoundedPolyline target)
        {
        }

        public void SetDirty()
        {
        }

        public void GenerateIfDirty()
        {
        }

        private void Generate()
        {
        }

        public (Vector2, Vector2Int) GetStartPointInfo(float ratio, RoundedPolyline.EndCapType capType)
        {
            return default((Vector2, Vector2Int));
        }

        public (Vector2, Vector2Int) GetEndPointInfo(float ratio, RoundedPolyline.EndCapType capType)
        {
            return default((Vector2, Vector2Int));
        }

        private int GetMeshIndex(float targetLength)
        {
            return default(int);
        }

        public void AddMesh(VertexHelper vh, Color32 color)
        {
        }

        [MethodImpl(256)]
        private static Vector2 Rotate(Vector2 v, float angle)
        {
            return default(Vector2);
        }

        [MethodImpl(256)]
        private static float Cross(Vector2 v1, Vector2 v2)
        {
            return default(float);
        }

        [MethodImpl(256)]
        private static Vector2 Reflect(Vector2 v, Vector2 p)
        {
            return default(Vector2);
        }
    }
}
