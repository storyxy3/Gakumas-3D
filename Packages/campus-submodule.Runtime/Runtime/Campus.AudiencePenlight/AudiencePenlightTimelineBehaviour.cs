namespace Campus.AudiencePenlight
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class AudiencePenlightTimelineBehaviour : PlayableBehaviour
    {
        public bool UseColorProjection;
        [ColorUsage(false, true)]
        public Color[] ColorTable;
        public Vector2 ProjectionUvRectMin;
        public Vector2 ProjectionUvRectMax;
        public AudiencePenlightTimelineBehaviour()
        {
        }
    }
}
