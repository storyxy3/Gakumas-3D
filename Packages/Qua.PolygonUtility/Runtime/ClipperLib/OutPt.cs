namespace ClipperLib
{
    using global::ClipperLib;
    using global::Qua.PolygonUtility;

    internal class OutPt : Pooling<OutPt>
    {
        internal int Idx;
        internal IntPoint Pt;
        internal OutPt Next;
        internal OutPt Prev;
        public override void OnBeforeReturn()
        {
        }

        public OutPt()
        {
        }
    }
}
