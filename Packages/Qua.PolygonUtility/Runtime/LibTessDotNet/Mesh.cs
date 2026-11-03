namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal class Mesh : Pooled<Mesh>
    {
        internal MeshUtils.Vertex _vHead;
        internal MeshUtils.Face _fHead;
        internal MeshUtils.Edge _eHead;
        internal MeshUtils.Edge _eHeadSym;
        public void Init(IPool pool)
        {
        }

        public void Reset(IPool pool)
        {
        }

        public MeshUtils.Edge MakeEdge(IPool pool)
        {
            return null;
        }

        public void Splice(IPool pool, MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
        {
        }

        public void Delete(IPool pool, MeshUtils.Edge eDel)
        {
        }

        public MeshUtils.Edge AddEdgeVertex(IPool pool, MeshUtils.Edge eOrg)
        {
            return null;
        }

        public MeshUtils.Edge SplitEdge(IPool pool, MeshUtils.Edge eOrg)
        {
            return null;
        }

        public MeshUtils.Edge Connect(IPool pool, MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
        {
            return null;
        }

        public void MergeConvexFaces(IPool pool, int maxVertsPerFace)
        {
        }

        public Mesh()
        {
        }
    }
}
