namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(PivotClip))]
    [DisplayName("Titan/Transform/Pivot")]
    public class PivotTrack : Vector2TweenerTrackBase<PivotClip, RectTransform>
    {
        [SerializeField]
        private bool _keepPosition;
        protected override Vector2 DefaultInitialValue
        {
            get
            {
                return default(Vector2);
            }
        }

        protected override Vector2 GetValue(RectTransform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RectTransform component)
        {
        }

        private static void SetPivotKeepPosition(RectTransform rectTransform, Vector2 pivot)
        {
        }

        public PivotTrack()
        {
        }
    }
}
