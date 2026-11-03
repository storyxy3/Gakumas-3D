namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(LinearGradient))]
    [TrackClipType(typeof(LinearGradientColorClip))]
    [DisplayName("Titan/LinearGradient/Color")]
    public class LinearGradientColorTrack : ColorArrayTweenerTrackBase<LinearGradientColorClip, LinearGradient>
    {
        protected override Color[] DefaultInitialValue
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

        protected override Color GetValue(LinearGradient component, int index)
        {
            return default(Color);
        }

        protected override void SetValue(LinearGradient component, int index, Color value)
        {
        }

        protected override void OnSetElementValue(LinearGradient component)
        {
        }

        public LinearGradientColorTrack()
        {
        }
    }
}
