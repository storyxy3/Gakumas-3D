namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Graphic))]
    [TrackClipType(typeof(GraphicColorClip))]
    [DisplayName("Titan/Graphic/Color")]
    public class GraphicColorTrack : ColorTweenerTrackBase<GraphicColorClip, Graphic>
    {
        protected override Color DefaultInitialValue
        {
            get
            {
                return default(Color);
            }
        }

        protected override Color GetValue(Graphic component)
        {
            return default(Color);
        }

        protected override void SetValue(Color value, Graphic component)
        {
        }

        public GraphicColorTrack()
        {
        }
    }
}
