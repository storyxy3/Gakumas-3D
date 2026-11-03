namespace Vision.Common
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(UITextureOverlay))]
    [TrackClipType(typeof(UITextureOverlayRotationClip))]
    [DisplayName("Titan/UITextureOverlay/Rotation")]
    public class UITextureOverlayRotationTrack : FloatTweenerTrackBase<UITextureOverlayRotationClip, UITextureOverlay, FloatParameter>
    {
        protected override float GetValue(UITextureOverlay component)
        {
            return default(float);
        }

        protected override void SetValue(float value, UITextureOverlay component)
        {
        }

        public UITextureOverlayRotationTrack()
        {
        }
    }
}
