namespace DG.Tweening.Plugins
{
    using global::DG.Tweening;
    using global::DG.Tweening.Core;
    using global::DG.Tweening.Core.Enums;
    using global::DG.Tweening.Plugins.Core;
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
    {
        public override void Reset(TweenerCore<Vector3, Path, PathOptions> t)
        {
        }

        public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative)
        {
        }

        public static ABSTweenPlugin<Vector3, Path, PathOptions> Get()
        {
            return null;
        }

        public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value)
        {
            return null;
        }

        public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t)
        {
        }

        public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue)
        {
            return default(float);
        }

        public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
        {
        }

        public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice)
        {
        }

        public PathPlugin()
        {
        }
    }
}
