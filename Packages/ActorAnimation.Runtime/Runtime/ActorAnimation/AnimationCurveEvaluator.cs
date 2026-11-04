namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    public struct AnimationCurveEvaluator
    {
        public unsafe static float Evaluate(float time, ref AnimationCurveData curve, KeyframeData* keyframe)
        {
            time %= keyframe[curve.startIndex + curve.length - 1].time;
            FindSurroundingKeyframes(time, ref curve, keyframe);
            var left = keyframe + curve.leftCacheIndex;
            if (float.IsInfinity(left->outTangent)) return left->value;
            var right = keyframe + curve.rightCacheIndex;
            if (float.IsInfinity(right->inTangent)) return left->value;
            if (left->outWeight.Equals(1f / 3f) && right->inWeight.Equals(1f / 3f))
                return HermiteInterpolate(time, left, right);
            return BezierInterpolate(time, left, right);
        }

        private unsafe static void FindSurroundingKeyframes(float time, ref AnimationCurveData curve, KeyframeData* keyframe)
        {
            if (!(curve.leftCacheIndex == curve.rightCacheIndex
                || keyframe[curve.leftCacheIndex].time > time || keyframe[curve.rightCacheIndex].time < time)) return;
            int first = curve.startIndex;
            int count = curve.length;
            while (count > 0)
            {
                int half = count >> 1;
                int middle = first + half;
                if (keyframe[middle].time <= time)
                {
                    first = middle + 1;
                    count -= half + 1;
                }
                else count = half;
            }
            curve.leftCacheIndex = first - 1;
            curve.rightCacheIndex = math.min(first, curve.startIndex + curve.length - 1);
        }

        private unsafe static float HermiteInterpolate(float time, KeyframeData* leftKeyframe, KeyframeData* rightKeyframe)
        {
            float duration = rightKeyframe->time - leftKeyframe->time;
            float t = 0f;
            float m0 = 0f;
            float m1 = 0f;
            if (duration != 0f)
            {
                t = (time - leftKeyframe->time) / duration;
                m0 = duration * leftKeyframe->outTangent;
                m1 = duration * rightKeyframe->inTangent;
            }
            return HermiteInterpolate(t, leftKeyframe->value, m0, m1, rightKeyframe->value);
        }

        private static float HermiteInterpolate(float t, float p0, float m0, float m1, float p1)
        {
            float a = (p0 + p0 + m0) - (p1 + p1) + m1;
            float b = p0 * -3f - (m0 + m0) + p1 * 3f - m1;
            return ((b + a * t) * t + m0) * t + p0;
        }

        private unsafe static float BezierInterpolate(float time, KeyframeData* leftKeyframe, KeyframeData* rightKeyframe)
        {
            float duration = rightKeyframe->time - leftKeyframe->time;
            if (duration == 0f) return leftKeyframe->value;
            return BezierInterpolate((time - leftKeyframe->time) / duration,
                leftKeyframe->value, duration * leftKeyframe->outTangent, leftKeyframe->outWeight,
                rightKeyframe->value, duration * rightKeyframe->inTangent, rightKeyframe->inWeight);
        }

        private static float FastCbrtPositive(float x)
        {
            return math.exp(math.log(x) / 3f);
        }

        private static float FastCbrt(float x)
        {
            return x >= 0f ? FastCbrtPositive(x) : -FastCbrtPositive(-x);
        }

        private static float BezierExtractU(float t, float w1, float w2)
        {
            float c = w1 * 3f;
            float a = w1 * 3f - w2 * 3f + 1f;
            float b = w2 * 3f + w1 * -6f;
            float u;
            if (!(math.abs(a) <= 0.001f))
            {
                float shift = -b / (a * 3f);
                float p = c / (a * 3f);
                float q = shift * (shift * shift) + (c * b + a * 3f * t) / (a * (a * 6f));
                float d = q * q + (p - shift * shift) * ((p - shift * shift) * (p - shift * shift));
                if (d >= 0f)
                {
                    float root = math.sqrt(d);
                    u = shift + (FastCbrt(q + root) + FastCbrt(q - root));
                }
                else
                {
                    float imaginary = math.sqrt(-d);
                    float magnitude = math.sqrt(q * q - d);
                    float angle = math.atan2(imaginary, q);
                    float root = FastCbrtPositive(magnitude);
                    float thirdAngle = angle / 3f;
                    float r0 = math.cos(thirdAngle);
                    float twiceRoot = root + root;
                    float r1 = math.cos(thirdAngle + 2.0943952f);
                    u = shift + twiceRoot * r0;
                    float r2 = math.cos(thirdAngle - 2.0943952f);
                    if (u < 0f || u > 1f)
                    {
                        u = shift + twiceRoot * r1;
                        if (u < 0f || u > 1f) u = shift + twiceRoot * r2;
                    }
                }
            }
            else if (!(math.abs(b) <= 0.001f))
            {
                float root = math.sqrt(c * c + b * 4f * t);
                float denominator = b + b;
                u = (-c - root) / denominator;
                if (u < 0f || u > 1f) u = (root - c) / denominator;
            }
            else
            {
                if (math.abs(c) > 0.001f) return t / c;
                return 0f;
            }
            if (u < 0f || u > 1f) return t >= 0.5f ? 1f : 0f;
            return u;
        }

        private static float BezierInterpolate(float t, float v1, float m1, float w1, float v2, float m2, float w2)
        {
            float u = BezierExtractU(t, w1, 1f - w2);
            return BezierInterpolate(u, v1, m1 * w1 + v1, v2 - m2 * w2, v2);
        }

        private static float BezierInterpolate(float t, float p0, float p1, float p2, float p3)
        {
            float inverse = 1f - t;
            return t * t * t * p3 + (inverse * (t * t * 3f) * p2
                + (inverse * (inverse * inverse) * p0 + (t * 3f) * (inverse * inverse) * p1));
        }
    }
}
