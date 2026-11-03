namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(CampusCanvas))]
    [TrackClipType(typeof(CampusCanvasBlurHsvOffsetClip))]
    [DisplayName("Titan/Canvas/BlurHsvOffset")]
    public class CampusCanvasBlurHsvOffsetTrack : Vector3TweenerTrackBase<CampusCanvasBlurHsvOffsetClip, CampusCanvas>
    {
        protected override Vector3 GetValue(CampusCanvas component)
        {
            return default(Vector3);
        }

        protected override void SetValue(Vector3 value, CampusCanvas component)
        {
        }

        public CampusCanvasBlurHsvOffsetTrack()
        {
        }
    }
}
