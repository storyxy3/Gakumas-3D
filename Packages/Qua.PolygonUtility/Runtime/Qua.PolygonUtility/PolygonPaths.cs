namespace Qua.PolygonUtility
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ClipperLib;
    using global::Qua.PolygonUtility;

    internal struct PolygonPaths : IDisposable
    {
        private List<List<IntPoint>> _paths;
        public List<List<IntPoint>> Paths
        {
            get
            {
                return null;
            }
        }

        public PolygonPaths(Polygon polygon)
        {
            this = default;
        }

        public void Dispose()
        {
        }

        public static PolygonPaths CreateEmpty()
        {
            return default(PolygonPaths);
        }
    }
}
