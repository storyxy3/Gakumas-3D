namespace DG.Tweening
{
    using global::System.Runtime.InteropServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public static class ShortcutExtensions
    {
        public static TweenerCore<float, float, FloatOptions> DOAspect(this Camera target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Color, Color, ColorOptions> DOColor(this Camera target, Color endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<float, float, FloatOptions> DOFieldOfView(this Camera target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<float, float, FloatOptions> DOOrthoSize(this Camera target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Rect, Rect, RectOptions> DOPixelRect(this Camera target, Rect endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Rect, Rect, RectOptions> DORect(this Camera target, Rect endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Color, Color, ColorOptions> DOColor(this Light target, Color endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<float, float, FloatOptions> DOIntensity(this Light target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Color, Color, ColorOptions> DOColor(this Material target, Color endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Color, Color, ColorOptions> DOFade(this Material target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Transform target, float endValue, float duration, bool snapping = false)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false)
        {
            return null;
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
        {
            return null;
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, Vector3 endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX(this Transform target, float endValue, float duration)
        {
            return null;
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY(this Transform target, float endValue, float duration)
        {
            return null;
        }

        public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
        {
            return null;
        }

        public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
        {
            return null;
        }

        public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
        {
            return null;
        }

        public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
        {
            return null;
        }

        public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
        {
            return null;
        }

        public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PathType.Linear)] PathType pathType, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PathMode.Full3D)] PathMode pathMode, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(10)] int resolution, [Optional] Color? gizmoColor)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PathType.Linear)] PathType pathType, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(PathMode.Full3D)] PathMode pathMode, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(10)] int resolution, [Optional] Color? gizmoColor)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
        {
            return null;
        }

        public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
        {
            return null;
        }

        public static int DOKill(this Component target, bool complete = false)
        {
            return default(int);
        }
    }
}
