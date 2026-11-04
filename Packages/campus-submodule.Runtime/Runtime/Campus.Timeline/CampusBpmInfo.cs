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
            BpmCurve = bpmCurve;
            this.beatDenominatorCurve = beatDenominatorCurve;
            this.beatNumeratorCurve = beatNumeratorCurve;
        }

        public void SetTime(float time)
        {
            _time = time;
        }

        public float EvaluateBpm()
        {
            return BpmCurve.Evaluate(_time);
        }

        public float EvaluateBpmAtTime(float time)
        {
            return BpmCurve.Evaluate(time);
        }
    }
}
