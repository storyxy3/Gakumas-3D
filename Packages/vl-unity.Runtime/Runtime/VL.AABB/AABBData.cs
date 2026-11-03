namespace VL.AABB
{
    using global::System;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public struct AABBData
    {
        public VLActorAABBCalcType aabbCalcType;
        public int positionIndex;
        public int positionLength;
        public Bounds defaultBounds;
    }
}
