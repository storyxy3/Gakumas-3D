namespace Qua.UI
{
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class AnimationCurveImage : LineImage
    {
        [SerializeField]
        private int _curveResolutionMin;
        public void SetCurve(AnimationCurve curve)
        {
        }

        [MethodImpl(256)]
        public Vector2 GetRelativePositionInRect(in Rect rect, float time, float value)
        {
            return default(Vector2);
        }

        [MethodImpl(256)]
        private Vector3 ToNormalizedValue(float time, float value)
        {
            return default(Vector3);
        }

        public (float, float) GetCurveValueFromScreenPoint(Vector2 screenPoint)
        {
            return default((float, float));
        }

        public AnimationCurveImage()
        {
        }
    }
}
