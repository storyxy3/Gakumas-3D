namespace ClipperLib
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ClipperLib;

    internal class ClipperBase
    {
        internal LocalMinima m_MinimaList;
        internal LocalMinima m_CurrentLM;
        internal List<List<TEdge>> m_edges;
        internal Scanbeam m_Scanbeam;
        internal List<OutRec> m_PolyOuts;
        internal TEdge m_ActiveEdges;
        internal bool m_UseFullRange;
        internal bool m_HasOpenPaths;
        [CompilerGenerated]
        private bool _003CPreserveCollinear_003Ek__BackingField;
        public bool PreserveCollinear
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public void Swap(ref long val1, ref long val2)
        {
        }

        internal static bool IsHorizontal(TEdge e)
        {
            return default(bool);
        }

        internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange)
        {
            return default(bool);
        }

        internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange)
        {
            return default(bool);
        }

        internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange)
        {
            return default(bool);
        }

        internal ClipperBase()
        {
        }

        public virtual void Clear()
        {
        }

        private void DisposeLocalMinimaList()
        {
        }

        private void RangeTest(IntPoint Pt, ref bool useFullRange)
        {
        }

        private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt)
        {
        }

        private void InitEdge2(TEdge e, PolyType polyType)
        {
        }

        private TEdge FindNextLocMin(TEdge E)
        {
            return null;
        }

        private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward)
        {
            return null;
        }

        public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed)
        {
            return default(bool);
        }

        public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed)
        {
            return default(bool);
        }

        internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3)
        {
            return default(bool);
        }

        private TEdge RemoveEdge(TEdge e)
        {
            return null;
        }

        private void SetDx(TEdge e)
        {
        }

        private void InsertLocalMinima(LocalMinima newLm)
        {
        }

        internal bool PopLocalMinima(long Y, out LocalMinima current)
        {
            throw null;
        }

        private void ReverseHorizontal(TEdge e)
        {
        }

        internal virtual void Reset()
        {
        }

        internal void InsertScanbeam(long Y)
        {
        }

        internal bool PopScanbeam(out long Y)
        {
            throw null;
        }

        internal bool LocalMinimaPending()
        {
            return default(bool);
        }

        internal OutRec CreateOutRec()
        {
            return null;
        }

        internal void DisposeOutRec(int index)
        {
        }

        internal void UpdateEdgeIntoAEL(ref TEdge e)
        {
        }

        internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2)
        {
        }

        internal void DeleteFromAEL(TEdge e)
        {
        }
    }
}
