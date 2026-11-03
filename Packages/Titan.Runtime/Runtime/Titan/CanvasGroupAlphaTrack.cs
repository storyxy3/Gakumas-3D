namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(CanvasGroup))]
    [TrackClipType(typeof(CanvasGroupAlphaClip))]
    [DisplayName("Titan/CanvasGroup/Alpha")]
    public class CanvasGroupAlphaTrack : FloatTweenerTrackBase<CanvasGroupAlphaClip, CanvasGroup, AlphaParameter>
    {
        protected override float DefaultInitialValue
        {
            get
            {
                return default(float);
            }
        }

        protected override float GetValue(CanvasGroup component)
        {
            return default(float);
        }

        protected override void SetValue(float value, CanvasGroup component)
        {
        }

        public CanvasGroupAlphaTrack()
        {
        }
    }
}
