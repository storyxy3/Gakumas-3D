namespace VL
{
    using global::VL;

    public struct AnimationCurveEvaluator
    {
        public unsafe static float Evaluate(float time, ref AnimationCurveData curve, KeyframeData* keyframe)
        {
            return default(float);
        }

        private unsafe static void FindSurroundingKeyframes(float time, ref AnimationCurveData curve, KeyframeData* keyframe)
        {
        }

        private unsafe static float HermiteInterpolate(float time, KeyframeData* leftKeyframe, KeyframeData* rightKeyframe)
        {
            return default(float);
        }

        private static float HermiteInterpolate(float t, float p0, float m0, float m1, float p1)
        {
            return default(float);
        }

        private unsafe static float BezierInterpolate(float time, KeyframeData* leftKeyframe, KeyframeData* rightKeyframe)
        {
            return default(float);
        }

        private static float FastCbrtPositive(float x)
        {
            return default(float);
        }

        private static float FastCbrt(float x)
        {
            return default(float);
        }

        private static float BezierExtractU(float t, float w1, float w2)
        {
            return default(float);
        }

        private static float BezierInterpolate(float t, float v1, float m1, float w1, float v2, float m2, float w2)
        {
            return default(float);
        }

        private static float BezierInterpolate(float t, float p0, float p1, float p2, float p3)
        {
            return default(float);
        }
    }
}
