namespace DG.Tweening.Plugins.Options
{
    using global::DG.Tweening;
    using global::DG.Tweening.Plugins.Options;
    using global::UnityEngine;

    public struct QuaternionOptions : IPlugOptions
    {
        public RotateMode rotateMode;
        public AxisConstraint axisConstraint;
        public Vector3 up;
        public void Reset()
        {
        }
    }
}
