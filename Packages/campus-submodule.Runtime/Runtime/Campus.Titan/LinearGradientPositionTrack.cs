namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(LinearGradient))]
    [TrackClipType(typeof(LinearGradientPositionClip))]
    [DisplayName("Titan/LinearGradient/Position")]
    public class LinearGradientPositionTrack : Vector2ArrayTweenerTrackBase<LinearGradientPositionClip, LinearGradient>
    {
        protected override Vector2[] DefaultInitialValue
        {
            get
            {
                return null;
            }
        }

        protected override int GetLength(LinearGradient component)
        {
            return default(int);
        }

        protected override Vector2 GetValue(LinearGradient component, int index)
        {
            return default(Vector2);
        }

        protected override void SetValue(LinearGradient component, int index, Vector2 value)
        {
        }

        protected override void OnSetElementValue(LinearGradient component)
        {
        }

        public LinearGradientPositionTrack()
        {
        }
    }
}
