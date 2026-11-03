namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal static class MeshUtils
    {
        internal class Vertex : Pooled<Vertex>
        {
            internal Vertex _prev;
            internal Vertex _next;
            internal Edge _anEdge;
            internal Vec3 _coords;
            internal float _s;
            internal float _t;
            internal PQHandle _pqHandle;
            internal int _n;
            internal object _data;
            public void Init(IPool pool)
            {
            }

            public void Reset(IPool pool)
            {
            }

            public Vertex()
            {
            }
        }

        internal class Face : Pooled<Face>
        {
            internal Face _prev;
            internal Face _next;
            internal Edge _anEdge;
            internal Face _trail;
            internal int _n;
            internal bool _marked;
            internal bool _inside;
            internal int VertsCount
            {
                get
                {
                    return default(int);
                }
            }

            public void Init(IPool pool)
            {
            }

            public void Reset(IPool pool)
            {
            }

            public Face()
            {
            }
        }

        internal struct EdgePair
        {
            internal Edge _e;
            internal Edge _eSym;
            public static EdgePair Create(IPool pool)
            {
                return default(EdgePair);
            }

            public void Reset(IPool pool)
            {
            }
        }

        internal class Edge : Pooled<Edge>
        {
            internal EdgePair _pair;
            internal Edge _next;
            internal Edge _Sym;
            internal Edge _Onext;
            internal Edge _Lnext;
            internal Vertex _Org;
            internal Face _Lface;
            internal Tess.ActiveRegion _activeRegion;
            internal int _winding;
            internal Face _Rface
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            internal Vertex _Dst
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            internal Edge _Oprev
            {
                get
                {
                    return null;
                }
            }

            internal Edge _Lprev
            {
                get
                {
                    return null;
                }
            }

            internal Edge _Rprev
            {
                get
                {
                    return null;
                }
            }

            internal Edge _Dnext
            {
                get
                {
                    return null;
                }
            }

            internal static void EnsureFirst(ref Edge e)
            {
            }

            public void Init(IPool pool)
            {
            }

            public void Reset(IPool pool)
            {
            }

            public Edge()
            {
            }
        }

        public static void Splice(Edge a, Edge b)
        {
        }

        public static void MakeVertex(IPool pool, Edge eOrig, Vertex vNext)
        {
        }

        public static void MakeFace(IPool pool, Edge eOrig, Face fNext)
        {
        }

        public static Edge MakeEdge(IPool pool, Edge eNext)
        {
            return null;
        }

        public static void KillEdge(IPool pool, Edge eDel)
        {
        }

        public static void KillVertex(IPool pool, Vertex vDel, Vertex newOrg)
        {
        }

        public static void KillFace(IPool pool, Face fDel, Face newLFace)
        {
        }

        public static float FaceArea(Face f)
        {
            return default(float);
        }
    }
}
