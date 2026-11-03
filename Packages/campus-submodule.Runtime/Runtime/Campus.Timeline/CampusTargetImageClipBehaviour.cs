namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusTargetImageClipBehaviour : PlayableBehaviour
    {
        public Transform trackingTarget;
        public float alpha;
        public Vector2 center;
        public float scale;
        public CampusTargetImageClipBehaviour()
        {
        }
    }
}
