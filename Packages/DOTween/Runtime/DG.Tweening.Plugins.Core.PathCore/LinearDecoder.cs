namespace DG.Tweening.Plugins.Core.PathCore
{
    using global::DG.Tweening.Plugins.Core.PathCore;
    using global::UnityEngine;

    internal class LinearDecoder : ABSPathDecoder
    {
        internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
        {
        }

        internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
        {
            return default(Vector3);
        }

        internal void SetTimeToLengthTables(Path p, int subdivisions)
        {
        }

        public LinearDecoder()
        {
        }
    }
}
