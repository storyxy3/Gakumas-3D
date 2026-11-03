namespace Vision.Common
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(UITextureOverlay))]
    [TrackClipType(typeof(UITextureOverlayScaleClip))]
    [DisplayName("Titan/UITextureOverlay/Scale")]
    public class UITextureOverlayScaleTrack : Vector2TweenerTrackBase<UITextureOverlayScaleClip, UITextureOverlay, ScaleVector2Parameter>
    {
        protected override Vector2 GetValue(UITextureOverlay component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, UITextureOverlay component)
        {
        }

        public UITextureOverlayScaleTrack()
        {
        }
    }
}
