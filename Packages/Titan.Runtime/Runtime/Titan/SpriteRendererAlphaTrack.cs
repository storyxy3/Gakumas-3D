namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(SpriteRendererAlphaClip))]
    [DisplayName("Titan/SpriteRenderer/Alpha")]
    public class SpriteRendererAlphaTrack : FloatTweenerTrackBase<SpriteRendererAlphaClip, SpriteRenderer, AlphaParameter>
    {
        protected override float DefaultInitialValue
        {
            get
            {
                return default(float);
            }
        }

        protected override float GetValue(SpriteRenderer component)
        {
            return default(float);
        }

        protected override void SetValue(float value, SpriteRenderer component)
        {
        }

        public SpriteRendererAlphaTrack()
        {
        }
    }
}
