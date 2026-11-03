namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class LimitInfo
    {
        public int useLimit;
        public Vector2Int axisX;
        public Vector2Int axisY;
        public Vector2Int axisZ;
        public LimitInfo()
        {
        }
    }
}
