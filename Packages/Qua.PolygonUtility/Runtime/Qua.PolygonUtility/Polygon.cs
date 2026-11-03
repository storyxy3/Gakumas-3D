namespace Qua.PolygonUtility
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Qua.PolygonUtility;

    public struct Polygon : IDisposable
    {
        private List<Region> _regions;
        public List<Region> Regions
        {
            get
            {
                return null;
            }
        }

        public bool HasData
        {
            get
            {
                return default(bool);
            }
        }

        internal Polygon(PolygonPaths polygonPaths)
        {
            this = default;
        }

        public void Dispose()
        {
        }
    }
}
