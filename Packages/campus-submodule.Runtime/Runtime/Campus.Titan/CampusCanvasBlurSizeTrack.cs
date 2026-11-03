namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(CampusCanvas))]
    [TrackClipType(typeof(CampusCanvasBlurSizeClip))]
    [DisplayName("Titan/Canvas/BlurSize")]
    public class CampusCanvasBlurSizeTrack : IntTweenerTrackBase<CampusCanvasBlurSizeClip, CampusCanvas>
    {
        protected override int GetValue(CampusCanvas component)
        {
            return default(int);
        }

        protected override void SetValue(int value, CampusCanvas component)
        {
        }

        public CampusCanvasBlurSizeTrack()
        {
        }
    }
}
