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
        public Vector2 ProjectionUvRectMin = Vector2.zero;
        public Vector2 ProjectionUvRectMax = Vector2.one;
        public AudiencePenlightTimelineBehaviour()
        {
        }
    }
}
