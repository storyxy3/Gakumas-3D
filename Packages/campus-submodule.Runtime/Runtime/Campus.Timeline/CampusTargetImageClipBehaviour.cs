namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusTargetImageClipBehaviour : PlayableBehaviour
    {
        public Transform trackingTarget;
        public float alpha = 1f;
        public Vector2 center;
        public float scale = 1f;
        public CampusTargetImageClipBehaviour()
        {
        }
    }
}
