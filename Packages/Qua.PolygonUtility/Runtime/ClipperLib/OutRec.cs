namespace ClipperLib
{
    using global::ClipperLib;
    using global::Qua.PolygonUtility;

    internal class OutRec : Pooling<OutRec>
    {
        internal int Idx;
        internal bool IsHole;
        internal bool IsOpen;
        internal OutRec FirstLeft;
        internal OutPt Pts;
        internal OutPt BottomPt;
        internal PolyNode PolyNode;
        public override void OnBeforeReturn()
        {
        }

        public OutRec()
        {
        }
    }
}
