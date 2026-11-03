namespace DG.Tweening.Plugins.Options
{
    using global::DG.Tweening;
    using global::DG.Tweening.Plugins.Options;

    public struct Vector3ArrayOptions : IPlugOptions
    {
        public AxisConstraint axisConstraint;
        public bool snapping;
        internal float[] durations;
        public void Reset()
        {
        }
    }
}
