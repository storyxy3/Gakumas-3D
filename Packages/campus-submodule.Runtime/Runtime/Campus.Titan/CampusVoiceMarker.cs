namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;

    [DisplayName("Titan/Campus Voice Marker")]
    public class CampusVoiceMarker : TweenMarkerBase
    {
        [SerializeField]
        private string _assetName;
        public override void Execute(TweenCreationContext context)
        {
        }

        public CampusVoiceMarker()
        {
        }
    }
}
