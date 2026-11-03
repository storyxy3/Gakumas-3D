namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;

    [DisplayName("Titan/Campus Wait End Marker")]
    public class CampusWaitEndMarker : TweenMarkerBase
    {
        [SerializeField]
        private string _id;
        public override void Execute(TweenCreationContext context)
        {
        }

        public CampusWaitEndMarker()
        {
        }
    }
}
