namespace DG.Tweening
{
    using global::System.Runtime.InteropServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public static class TweenSettingsExtensions
    {
        public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion)
            where T : Tween
        {
            return null;
        }

        public static T SetId<T>(this T t, object objectId)
            where T : Tween
        {
            return null;
        }

        public static T SetId<T>(this T t, string stringId)
            where T : Tween
        {
            return null;
        }

        public static T SetLink<T>(this T t, GameObject gameObject)
            where T : Tween
        {
            return null;
        }

        public static T SetTarget<T>(this T t, object target)
            where T : Tween
        {
            return null;
        }

        public static T SetLoops<T>(this T t, int loops)
            where T : Tween
        {
            return null;
        }

        public static T SetLoops<T>(this T t, int loops, LoopType loopType)
            where T : Tween
        {
            return null;
        }

        public static T SetEase<T>(this T t, Ease ease)
            where T : Tween
        {
            return null;
        }

        public static T SetEase<T>(this T t, Ease ease, float amplitude, float period)
            where T : Tween
        {
            return null;
        }

        public static T SetEase<T>(this T t, AnimationCurve animCurve)
            where T : Tween
        {
            return null;
        }

        public static T SetEase<T>(this T t, EaseFunction customEase)
            where T : Tween
        {
            return null;
        }

        public static T SetUpdate<T>(this T t, bool isIndependentUpdate)
            where T : Tween
        {
            return null;
        }

        public static T SetUpdate<T>(this T t, UpdateType updateType)
            where T : Tween
        {
            return null;
        }

        public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate)
            where T : Tween
        {
            return null;
        }

        public static T OnStart<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static T OnPlay<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static T OnRewind<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static T OnUpdate<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static T OnStepComplete<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static T OnComplete<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static T OnKill<T>(this T t, TweenCallback action)
            where T : Tween
        {
            return null;
        }

        public static Sequence Append(this Sequence s, Tween t)
        {
            return null;
        }

        public static Sequence Join(this Sequence s, Tween t)
        {
            return null;
        }

        public static Sequence Insert(this Sequence s, float atPosition, Tween t)
        {
            return null;
        }

        public static Sequence AppendInterval(this Sequence s, float interval)
        {
            return null;
        }

        public static Sequence PrependInterval(this Sequence s, float interval)
        {
            return null;
        }

        public static Sequence AppendCallback(this Sequence s, TweenCallback callback)
        {
            return null;
        }

        public static Sequence PrependCallback(this Sequence s, TweenCallback callback)
        {
            return null;
        }

        public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
        {
            return null;
        }

        public static T From<T>(this T t)
            where T : Tweener
        {
            return null;
        }

        public static T From<T>(this T t, bool isRelative)
            where T : Tweener
        {
            return null;
        }

        public static T SetDelay<T>(this T t, float delay)
            where T : Tween
        {
            return null;
        }

        public static T SetDelay<T>(this T t, float delay, bool asPrependedIntervalIfSequence)
            where T : Tween
        {
            return null;
        }

        public static T SetRelative<T>(this T t)
            where T : Tween
        {
            return null;
        }

        public static T SetRelative<T>(this T t, bool isRelative)
            where T : Tween
        {
            return null;
        }

        public static T SetSpeedBased<T>(this T t)
            where T : Tween
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(ScrambleMode.None)] ScrambleMode scrambleMode, [Optional] string scrambleChars)
        {
            return null;
        }

        public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
        {
            return null;
        }

        private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, [Optional] Vector3? forwardDirection, [Optional] Vector3? up, bool stableZRotation = false)
        {
            return null;
        }

        private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
        {
        }
    }
}
