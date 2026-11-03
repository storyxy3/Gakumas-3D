namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusTweenBehaviour : PlayableBehaviour
    {
        public Vector3 position;
        public Vector3 rotation;
        public Vector3 scale;
        public CampusTweenBehaviour()
        {
        }
    }
}
