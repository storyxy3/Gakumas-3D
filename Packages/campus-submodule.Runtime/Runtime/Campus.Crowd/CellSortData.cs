namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;

    public struct CellSortData : IComparable<CellSortData>
    {
        public ushort octreeIndex;
        public ushort personIndexOffset;
        public ushort personInfoLength;
        public ushort cameraDistance;
        public int CompareTo(CellSortData other)
        {
            return default(int);
        }
    }
}
