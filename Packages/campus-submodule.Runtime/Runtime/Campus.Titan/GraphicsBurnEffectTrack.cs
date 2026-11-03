namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(GraphicsBurnEffectView))]
    [TrackClipType(typeof(GraphicsBurnEffectClip))]
    [DisplayName("Titan/BurnEffect")]
    public class GraphicsBurnEffectTrack : FloatTweenerTrackBase<GraphicsBurnEffectClip, GraphicsBurnEffectView>
    {
        protected override float GetValue(GraphicsBurnEffectView component)
        {
            return default(float);
        }

        protected override void SetValue(float value, GraphicsBurnEffectView component)
        {
        }

        public GraphicsBurnEffectTrack()
        {
        }
    }
}
