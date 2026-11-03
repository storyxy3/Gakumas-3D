namespace DG.Tweening.Plugins.Options
{
    using global::DG.Tweening;
    using global::DG.Tweening.Plugins.Options;

    public struct VectorOptions : IPlugOptions
    {
        public AxisConstraint axisConstraint;
        public bool snapping;
        public void Reset()
        {
        }
    }
}
