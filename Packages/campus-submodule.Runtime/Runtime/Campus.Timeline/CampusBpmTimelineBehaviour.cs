namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusBpmTimelineBehaviour : PlayableBehaviour
    {
        [SerializeField]
        public float Bpm;
        [SerializeField]
        public int beatNumerator;
        [SerializeField]
        public int beatDenominator;
        public CampusBpmTimelineBehaviour()
        {
        }
    }
}
