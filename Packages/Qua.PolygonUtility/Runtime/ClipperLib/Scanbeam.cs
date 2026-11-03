namespace ClipperLib
{
    using global::ClipperLib;
    using global::Qua.PolygonUtility;

    internal class Scanbeam : Pooling<Scanbeam>
    {
        internal long Y;
        internal Scanbeam Next;
        public override void OnBeforeReturn()
        {
        }

        public Scanbeam()
        {
        }
    }
}
