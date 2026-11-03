namespace DG.Tweening.Plugins.Core.PathCore
{
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::UnityEngine;

    internal abstract class ABSPathDecoder
    {
        internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);
        internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);
        protected ABSPathDecoder()
        {
        }
    }
}
