namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(GameObject))]
    [TrackClipType(typeof(ActivationClip))]
    [DisplayName("Titan/Activation")]
    public class ActivationTrack : BoolTweenerTrackBase<ActivationClip, GameObject>
    {
        protected override bool GetValue(GameObject component)
        {
            return default(bool);
        }

        protected override void SetValue(bool value, GameObject component)
        {
        }

        public ActivationTrack()
        {
        }
    }
}
