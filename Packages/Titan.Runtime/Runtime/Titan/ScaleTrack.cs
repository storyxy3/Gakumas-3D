namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(ScaleClip))]
    [DisplayName("Titan/Transform/Scale")]
    public class ScaleTrack : Vector2TweenerTrackBase<ScaleClip, Transform, ScaleVector2Parameter>
    {
        protected override Vector2 GetValue(Transform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, Transform component)
        {
        }

        public ScaleTrack()
        {
        }
    }
}
