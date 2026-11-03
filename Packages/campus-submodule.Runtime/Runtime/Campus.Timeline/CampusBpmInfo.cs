namespace Campus.Timeline
{
    using global::UnityEngine;

    public class CampusBpmInfo
    {
        public AnimationCurve BpmCurve;
        public AnimationCurve beatNumeratorCurve;
        public AnimationCurve beatDenominatorCurve;
        private float _time;
        public CampusBpmInfo(AnimationCurve bpmCurve, AnimationCurve beatNumeratorCurve, AnimationCurve beatDenominatorCurve)
        {
        }

        public void SetTime(float time)
        {
        }

        public float EvaluateBpm()
        {
            return default(float);
        }

        public float EvaluateBpmAtTime(float time)
        {
            return default(float);
        }
    }
}
