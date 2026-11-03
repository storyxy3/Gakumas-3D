namespace ClipperLib
{
    using global::ClipperLib;
    using global::Qua.PolygonUtility;

    internal class Join : Pooling<Join>
    {
        internal OutPt OutPt1;
        internal OutPt OutPt2;
        internal IntPoint OffPt;
        public override void OnBeforeReturn()
        {
        }

        public Join()
        {
        }
    }
}
