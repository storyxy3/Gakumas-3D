namespace DG.Tweening
{
    using global::DG.Tweening;

    public static class TweenExtensions
    {
        public static void Complete(this Tween t)
        {
        }

        public static void Complete(this Tween t, bool withCallbacks)
        {
        }

        public static void Goto(this Tween t, float to, bool andPlay = false)
        {
        }

        public static void Kill(this Tween t, bool complete = false)
        {
        }

        public static T Pause<T>(this T t)
            where T : Tween
        {
            return null;
        }

        public static T Play<T>(this T t)
            where T : Tween
        {
            return null;
        }

        public static void PlayBackwards(this Tween t)
        {
        }

        public static void PlayForward(this Tween t)
        {
        }

        public static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f)
        {
        }

        public static void Rewind(this Tween t, bool includeDelay = true)
        {
        }

        public static void TogglePause(this Tween t)
        {
        }

        public static float Duration(this Tween t, bool includeLoops = true)
        {
            return default(float);
        }

        public static float Elapsed(this Tween t, bool includeLoops = true)
        {
            return default(float);
        }

        public static float ElapsedPercentage(this Tween t, bool includeLoops = true)
        {
            return default(float);
        }

        public static float ElapsedDirectionalPercentage(this Tween t)
        {
            return default(float);
        }

        public static bool IsActive(this Tween t)
        {
            return default(bool);
        }

        public static bool IsComplete(this Tween t)
        {
            return default(bool);
        }

        public static bool IsInitialized(this Tween t)
        {
            return default(bool);
        }

        public static bool IsPlaying(this Tween t)
        {
            return default(bool);
        }

        public static int Loops(this Tween t)
        {
            return default(int);
        }
    }
}
