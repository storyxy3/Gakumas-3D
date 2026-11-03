namespace DG.Tweening.Core
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public static class DOTweenExternalCommand
    {
        [CompilerGenerated]
        private static Action<PathOptions, Tween, Quaternion, Transform> m_SetOrientationOnPath;
        public static event Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        internal static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
        {
        }
    }
}
