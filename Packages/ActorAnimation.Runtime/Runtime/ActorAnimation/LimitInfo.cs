namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class LimitInfo
    {
        public int useLimit;
        public Vector2Int axisX = new Vector2Int(-180, 180);
        public Vector2Int axisY = new Vector2Int(-180, 180);
        public Vector2Int axisZ = new Vector2Int(-180, 180);
        public LimitInfo()
        {
        }
    }
}
