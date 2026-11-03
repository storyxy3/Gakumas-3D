namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(SiblingIndexClip))]
    [DisplayName("Titan/Transform/SiblingIndex")]
    public class SiblingIndexTrack : IntTweenerTrackBase<SiblingIndexClip, Transform>
    {
        protected override int GetValue(Transform component)
        {
            return default(int);
        }

        protected override void SetValue(int value, Transform component)
        {
        }

        public SiblingIndexTrack()
        {
        }
    }
}
