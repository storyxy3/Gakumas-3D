namespace Campus.Crowd
{
    using global::System.Collections.Generic;
    using global::Campus.Crowd;

    public struct CellSortDataComparer : IComparer<CellSortData>
    {
        public int Compare(CellSortData x, CellSortData y)
        {
            return x.cameraDistance == y.cameraDistance ? 0 : x.cameraDistance > y.cameraDistance ? 1 : -1;
        }
    }
}
