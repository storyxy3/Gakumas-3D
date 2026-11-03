namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(SpriteRendererColorClip))]
    [DisplayName("Titan/SpriteRenderer/Color")]
    public class SpriteRendererColorTrack : ColorTweenerTrackBase<SpriteRendererColorClip, SpriteRenderer>
    {
        protected override Color DefaultInitialValue
        {
            get
            {
                return default(Color);
            }
        }

        protected override Color GetValue(SpriteRenderer component)
        {
            return default(Color);
        }

        protected override void SetValue(Color value, SpriteRenderer component)
        {
        }

        public SpriteRendererColorTrack()
        {
        }
    }
}
