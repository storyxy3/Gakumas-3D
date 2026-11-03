namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Graphic))]
    [TrackClipType(typeof(GraphicAlphaClip))]
    [DisplayName("Titan/Graphic/Alpha")]
    public class GraphicAlphaTrack : FloatTweenerTrackBase<GraphicAlphaClip, Graphic, AlphaParameter>
    {
        protected override float DefaultInitialValue
        {
            get
            {
                return default(float);
            }
        }

        protected override float GetValue(Graphic component)
        {
            return default(float);
        }

        protected override void SetValue(float value, Graphic component)
        {
        }

        public GraphicAlphaTrack()
        {
        }
    }
}
