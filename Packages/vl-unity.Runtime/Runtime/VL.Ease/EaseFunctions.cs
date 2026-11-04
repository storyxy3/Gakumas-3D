namespace VL.Ease
{
    using global::VL.Ease;
    using global::UnityEngine;

    public static class EaseFunctions
    {
        private static EaseFunction _linear;
        private static EaseFunction _inSine;
        private static EaseFunction _outSine;
        private static EaseFunction _inOutSine;
        private static EaseFunction _inQuad;
        private static EaseFunction _outQuad;
        private static EaseFunction _inOutQuad;
        private static EaseFunction _inCubic;
        private static EaseFunction _outCubic;
        private static EaseFunction _inOutCubic;
        private static EaseFunction _inQuart;
        private static EaseFunction _outQuart;
        private static EaseFunction _inOutQuart;
        private static EaseFunction _inQuint;
        private static EaseFunction _outQuint;
        private static EaseFunction _inOutQuint;
        private static EaseFunction _inExpo;
        private static EaseFunction _outExpo;
        private static EaseFunction _inOutExpo;
        private static EaseFunction _inCirc;
        private static EaseFunction _outCirc;
        private static EaseFunction _inOutCirc;
        public static EaseFunction GetEaseFunction(EaseType type)
        {
            switch (type)
            {
                case EaseType.InSine:
                    return _inSine ?? (_inSine = new EaseFunction(InSine));
                case EaseType.OutSine:
                    return _outSine ?? (_outSine = new EaseFunction(OutSine));
                case EaseType.InOutSine:
                    return _inOutSine ?? (_inOutSine = new EaseFunction(InOutSine));
                case EaseType.InQuad:
                    return _inQuad ?? (_inQuad = new EaseFunction(InQuad));
                case EaseType.OutQuad:
                    return _outQuad ?? (_outQuad = new EaseFunction(OutQuad));
                case EaseType.InOutQuad:
                    return _inOutQuad ?? (_inOutQuad = new EaseFunction(InOutQuad));
                case EaseType.InCubic:
                    return _inCubic ?? (_inCubic = new EaseFunction(InCubic));
                case EaseType.OutCubic:
                    return _outCubic ?? (_outCubic = new EaseFunction(OutCubic));
                case EaseType.InOutCubic:
                    return _inOutCubic ?? (_inOutCubic = new EaseFunction(InOutCubic));
                case EaseType.InQuart:
                    return _inQuart ?? (_inQuart = new EaseFunction(InQuart));
                case EaseType.OutQuart:
                    return _outQuart ?? (_outQuart = new EaseFunction(OutQuart));
                case EaseType.InOutQuart:
                    return _inOutQuart ?? (_inOutQuart = new EaseFunction(InOutQuart));
                case EaseType.InQuint:
                    return _inQuint ?? (_inQuint = new EaseFunction(InQuint));
                case EaseType.OutQuint:
                    return _outQuint ?? (_outQuint = new EaseFunction(OutQuint));
                case EaseType.InOutQuint:
                    return _inOutQuint ?? (_inOutQuint = new EaseFunction(InOutQuint));
                case EaseType.InExpo:
                    return _inExpo ?? (_inExpo = new EaseFunction(InExpo));
                case EaseType.OutExpo:
                    return _outExpo ?? (_outExpo = new EaseFunction(OutExpo));
                case EaseType.InOutExpo:
                    return _inOutExpo ?? (_inOutExpo = new EaseFunction(InOutExpo));
                case EaseType.InCirc:
                    return _inCirc ?? (_inCirc = new EaseFunction(InCirc));
                case EaseType.OutCirc:
                    return _outCirc ?? (_outCirc = new EaseFunction(OutCirc));
                case EaseType.InOutCirc:
                    return _inOutCirc ?? (_inOutCirc = new EaseFunction(InOutCirc));
                default:
                    return _linear ?? (_linear = new EaseFunction(Linear));
            }
        }

        public static float Linear(float time, float duration)
        {
            return time / duration;
        }

        public static float InSine(float time, float duration)
        {
            return -Mathf.Cos(time / duration * Mathf.PI * 0.5f) + 1f;
        }

        public static float OutSine(float time, float duration)
        {
            return Mathf.Sin(time / duration * Mathf.PI * 0.5f);
        }

        public static float InOutSine(float time, float duration)
        {
            return -0.5f * (Mathf.Cos(time * Mathf.PI / duration) - 1f);
        }

        public static float InQuad(float time, float duration)
        {
            time /= duration;
            return time * time;
        }

        public static float OutQuad(float time, float duration)
        {
            time /= duration;
            return -time * (time - 2f);
        }

        public static float InOutQuad(float time, float duration)
        {
            time /= duration * 0.5f;
            if (time < 1f)
                return 0.5f * time * time;
            --time;
            return -0.5f * (time * (time - 2f) - 1f);
        }

        public static float InCubic(float time, float duration)
        {
            time /= duration;
            return time * time * time;
        }

        public static float OutCubic(float time, float duration)
        {
            time = time / duration - 1f;
            return (time * time * time) + 1f;
        }

        public static float InOutCubic(float time, float duration)
        {
            time /= duration * 0.5f;
            if (time < 1f)
                return 0.5f * time * time * time;
            time -= 2f;
            return 0.5f * (time * time * time + 2f);
        }

        public static float InQuart(float time, float duration)
        {
            time /= duration;
            return time * time * time * time;
        }

        public static float OutQuart(float time, float duration)
        {
            time = time / duration - 1f;
            return -(time * time * time * time - 1f);
        }

        public static float InOutQuart(float time, float duration)
        {
            time /= duration * 0.5f;
            if (time < 1f)
                return 0.5f * time * time * time * time;
            time -= 2f;
            return -0.5f * (time * time * time * time - 2f);
        }

        public static float InQuint(float time, float duration)
        {
            time /= duration;
            return time * time * time * time * time;
        }

        public static float OutQuint(float time, float duration)
        {
            time = time / duration - 1f;
            return (time * time * time * time * time) + 1f;
        }

        public static float InOutQuint(float time, float duration)
        {
            time /= duration * 0.5f;
            if (time < 1f)
                return 0.5f * time * time * time * time * time;
            time -= 2f;
            return 0.5f * (time * time * time * time * time + 2f);
        }

        public static float InExpo(float time, float duration)
        {
            return time == 0f ? 0f : Mathf.Pow(2f, 10f * (time / duration - 1f));
        }

        public static float OutExpo(float time, float duration)
        {
            return Mathf.Approximately(time, duration) ? 1f : -Mathf.Pow(2f, -10f * time / duration) + 1f;
        }

        public static float InOutExpo(float time, float duration)
        {
            if (time == 0f)
                return 0f;
            if (Mathf.Approximately(time, duration))
                return 1f;
            time /= duration * 0.5f;
            if (time < 1f)
                return 0.5f * Mathf.Pow(2f, 10f * (time - 1f));
            --time;
            return 0.5f * (-Mathf.Pow(2f, -10f * time) + 2f);
        }

        public static float InCirc(float time, float duration)
        {
            time /= duration;
            return -(Mathf.Sqrt(1f - time * time) - 1f);
        }

        public static float OutCirc(float time, float duration)
        {
            time = time / duration - 1f;
            return Mathf.Sqrt(1f - time * time);
        }

        public static float InOutCirc(float time, float duration)
        {
            time /= duration * 0.5f;
            if (time < 1f)
                return -0.5f * (Mathf.Sqrt(1f - time * time) - 1f);
            time -= 2f;
            return 0.5f * (Mathf.Sqrt(1f - time * time) + 1f);
        }
    }
}
