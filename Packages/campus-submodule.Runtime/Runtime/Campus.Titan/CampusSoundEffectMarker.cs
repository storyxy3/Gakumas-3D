namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;

    [DisplayName("Titan/Campus SE Marker")]
    public class CampusSoundEffectMarker : TweenMarkerBase
    {
        [SerializeField]
        private string _assetName;
        public string AssetName
        {
            get
            {
                return null;
            }
        }

        public override void Execute(TweenCreationContext context)
        {
        }

        public CampusSoundEffectMarker()
        {
        }
    }
}
