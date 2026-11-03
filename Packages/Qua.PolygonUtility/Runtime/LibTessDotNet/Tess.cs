namespace LibTessDotNet
{
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::LibTessDotNet;

    internal class Tess
    {
        internal class ActiveRegion : Pooled<ActiveRegion>
        {
            internal MeshUtils.Edge _eUp;
            internal Dict<ActiveRegion>.Node _nodeUp;
            internal int _windingNumber;
            internal bool _inside;
            internal bool _sentinel;
            internal bool _dirty;
            internal bool _fixUpperEdge;
            public void Init(IPool pool)
            {
            }

            public void Reset(IPool pool)
            {
            }

            public ActiveRegion()
            {
            }
        }

        private IPool _pool;
        private Mesh _mesh;
        private Vec3 _normal;
        private Vec3 _sUnit;
        private Vec3 _tUnit;
        private float _bminX;
        private float _bminY;
        private float _bmaxX;
        private float _bmaxY;
        private WindingRule _windingRule;
        private Dict<ActiveRegion> _dict;
        private PriorityQueue<MeshUtils.Vertex> _pq;
        private MeshUtils.Vertex _event;
        private CombineCallback _combineCallback;
        private static List<ContourVertex> _vertices;
        private int _vertexCount;
        private static List<int> _elements;
        private int _elementCount;
        public float SUnitX;
        public float SUnitY;
        public float SentinelCoord;
        public bool NoEmptyPolygons;
        private static readonly float[] minVal;
        private static readonly MeshUtils.Vertex[] minVert;
        private static readonly float[] maxVal;
        private static readonly MeshUtils.Vertex[] maxVert;
        public List<ContourVertex> Vertices
        {
            get
            {
                return null;
            }
        }

        public List<int> Elements
        {
            get
            {
                return null;
            }
        }

        private ActiveRegion RegionBelow(ActiveRegion reg)
        {
            return null;
        }

        private ActiveRegion RegionAbove(ActiveRegion reg)
        {
            return null;
        }

        private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
        {
            return default(bool);
        }

        private void DeleteRegion(ActiveRegion reg)
        {
        }

        private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
        {
        }

        private ActiveRegion TopLeftRegion(ActiveRegion reg)
        {
            return null;
        }

        private ActiveRegion TopRightRegion(ActiveRegion reg)
        {
            return null;
        }

        private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
        {
            return null;
        }

        private void ComputeWinding(ActiveRegion reg)
        {
        }

        private void FinishRegion(ActiveRegion reg)
        {
        }

        private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
        {
            return null;
        }

        private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
        {
        }

        private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
        {
        }

        private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
        {
            throw null;
        }

        private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
        {
        }

        private bool CheckForRightSplice(ActiveRegion regUp)
        {
            return default(bool);
        }

        private bool CheckForLeftSplice(ActiveRegion regUp)
        {
            return default(bool);
        }

        private bool CheckForIntersect(ActiveRegion regUp)
        {
            return default(bool);
        }

        private void WalkDirtyRegions(ActiveRegion regUp)
        {
        }

        private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
        {
        }

        private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
        {
        }

        private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
        {
        }

        private void SweepEvent(MeshUtils.Vertex vEvent)
        {
        }

        private void AddSentinel(float smin, float smax, float t)
        {
        }

        private void InitEdgeDict()
        {
        }

        private void DoneEdgeDict()
        {
        }

        private void RemoveDegenerateEdges()
        {
        }

        private void InitPriorityQ()
        {
        }

        private void DonePriorityQ()
        {
        }

        private void RemoveDegenerateFaces()
        {
        }

        protected void ComputeInterior()
        {
        }

        public Tess()
        {
        }

        public Tess(IPool pool)
        {
        }

        private void ComputeNormal(ref Vec3 norm)
        {
        }

        private void CheckOrientation()
        {
        }

        private void ProjectPolygon()
        {
        }

        private void TessellateMonoRegion(MeshUtils.Face face)
        {
        }

        private void TessellateInterior()
        {
        }

        private void SetWindingNumber(int value, bool keepOnlyBoundary)
        {
        }

        private int GetNeighbourFace(MeshUtils.Edge edge)
        {
            return default(int);
        }

        private void OutputPolymesh(ElementType elementType, int polySize)
        {
        }

        private void OutputContours()
        {
        }

        private float SignedArea(IList<ContourVertex> vertices)
        {
            return default(float);
        }

        public void AddContour(IList<ContourVertex> vertices, ContourOrientation forceOrientation = ContourOrientation.Original)
        {
        }

        private void AddContourInternal(IList<ContourVertex> vertices, ContourOrientation forceOrientation)
        {
        }

        public void Tessellate([global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(WindingRule.EvenOdd)] WindingRule windingRule, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(ElementType.Polygons)] ElementType elementType, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(3)] int polySize, [Optional] CombineCallback combineCallback, [Optional] Vec3 normal)
        {
        }

        public void Reset()
        {
        }
    }
}
