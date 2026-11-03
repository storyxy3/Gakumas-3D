namespace ClipperLib
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ClipperLib;

    internal class Clipper : ClipperBase
    {
        private ClipType m_ClipType;
        private Maxima m_Maxima;
        private TEdge m_SortedEdges;
        private List<IntersectNode> m_IntersectList;
        private Comparison<IntersectNode> m_IntersectNodeComparison;
        private bool m_ExecuteLocked;
        private PolyFillType m_ClipFillType;
        private PolyFillType m_SubjFillType;
        private List<Join> m_Joins;
        private List<Join> m_GhostJoins;
        private bool m_UsingPolyTree;
        [CompilerGenerated]
        private bool _003CReverseSolution_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CStrictlySimple_003Ek__BackingField;
        public bool ReverseSolution
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

        public bool StrictlySimple
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

        public Clipper(int InitOptions = 0)
        {
        }

        public static int CompareIntersectNode(IntersectNode node1, IntersectNode node2)
        {
            return default(int);
        }

        private void InsertMaxima(long X)
        {
        }

        public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType)
        {
            return default(bool);
        }

        private bool ExecuteInternal()
        {
            return default(bool);
        }

        private void DisposeAllPolyPts()
        {
        }

        private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt)
        {
        }

        private void AddGhostJoin(OutPt Op, IntPoint OffPt)
        {
        }

        private void InsertLocalMinimaIntoAEL(long botY)
        {
        }

        private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge)
        {
        }

        private bool E2InsertsBeforeE1(TEdge e1, TEdge e2)
        {
            return default(bool);
        }

        private bool IsEvenOddFillType(TEdge edge)
        {
            return default(bool);
        }

        private bool IsEvenOddAltFillType(TEdge edge)
        {
            return default(bool);
        }

        private bool IsContributing(TEdge edge)
        {
            return default(bool);
        }

        private void SetWindingCount(TEdge edge)
        {
        }

        private void AddEdgeToSEL(TEdge edge)
        {
        }

        internal bool PopEdgeFromSEL(out TEdge e)
        {
            throw null;
        }

        private void CopyAELToSEL()
        {
        }

        private void SwapPositionsInSEL(TEdge edge1, TEdge edge2)
        {
        }

        private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt)
        {
        }

        private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt)
        {
            return null;
        }

        private OutPt AddOutPt(TEdge e, IntPoint pt)
        {
            return null;
        }

        private OutPt GetLastOutPt(TEdge e)
        {
            return null;
        }

        private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
        {
            return default(bool);
        }

        private void SetHoleState(TEdge e, OutRec outRec)
        {
        }

        private double GetDx(IntPoint pt1, IntPoint pt2)
        {
            return default(double);
        }

        private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2)
        {
            return default(bool);
        }

        private OutPt GetBottomPt(OutPt pp)
        {
            return null;
        }

        private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2)
        {
            return null;
        }

        private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2)
        {
            return default(bool);
        }

        private OutRec GetOutRec(int idx)
        {
            return null;
        }

        private void AppendPolygon(TEdge e1, TEdge e2)
        {
        }

        private void ReversePolyPtLinks(OutPt pp)
        {
        }

        private static void SwapSides(TEdge edge1, TEdge edge2)
        {
        }

        private static void SwapPolyIndexes(TEdge edge1, TEdge edge2)
        {
        }

        private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt)
        {
        }

        private void ProcessHorizontals()
        {
        }

        private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right)
        {
            throw null;
        }

        private void ProcessHorizontal(TEdge horzEdge)
        {
        }

        private TEdge GetNextInAEL(TEdge e, Direction Direction)
        {
            return null;
        }

        private bool IsMaxima(TEdge e, double Y)
        {
            return default(bool);
        }

        private bool IsIntermediate(TEdge e, double Y)
        {
            return default(bool);
        }

        internal TEdge GetMaximaPair(TEdge e)
        {
            return null;
        }

        internal TEdge GetMaximaPairEx(TEdge e)
        {
            return null;
        }

        private bool ProcessIntersections(long topY)
        {
            return default(bool);
        }

        private void BuildIntersectList(long topY)
        {
        }

        private bool EdgesAdjacent(IntersectNode inode)
        {
            return default(bool);
        }

        private bool FixupIntersectionOrder()
        {
            return default(bool);
        }

        private void ProcessIntersectList()
        {
        }

        internal static long Round(double value)
        {
            return default(long);
        }

        private static long TopX(TEdge edge, long currentY)
        {
            return default(long);
        }

        private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip)
        {
            throw null;
        }

        private void ProcessEdgesAtTopOfScanbeam(long topY)
        {
        }

        private void DoMaxima(TEdge e)
        {
        }

        private int PointCount(OutPt pts)
        {
            return default(int);
        }

        private void BuildResult(List<List<IntPoint>> polyg)
        {
        }

        private void FixupOutPolyline(OutRec outrec)
        {
        }

        private void FixupOutPolygon(OutRec outRec)
        {
        }

        private OutPt DupOutPt(OutPt outPt, bool InsertAfter)
        {
            return null;
        }

        private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
        {
            throw null;
        }

        private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft)
        {
            return default(bool);
        }

        private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2)
        {
            return default(bool);
        }

        private static int PointInPolygon(IntPoint pt, OutPt op)
        {
            return default(int);
        }

        private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2)
        {
            return default(bool);
        }

        private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec)
        {
        }

        private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec)
        {
        }

        private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec)
        {
        }

        private static OutRec ParseFirstLeft(OutRec FirstLeft)
        {
            return null;
        }

        private void JoinCommonEdges()
        {
        }

        private void UpdateOutPtIdxs(OutRec outrec)
        {
        }

        private void DoSimplePolygons()
        {
        }

        internal double Area(OutRec outRec)
        {
            return default(double);
        }

        internal double Area(OutPt op)
        {
            return default(double);
        }
    }
}
