namespace ClipperLib
{
    using global::ClipperLib;
    using global::Qua.PolygonUtility;

    internal class LocalMinima : Pooling<LocalMinima>
    {
        internal long Y;
        internal TEdge LeftBound;
        internal TEdge RightBound;
        internal LocalMinima Next;
        public override void OnBeforeReturn()
        {
        }

        public LocalMinima()
        {
        }
    }
}
