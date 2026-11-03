namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;

    [DisplayName("Titan/Campus Tap Wait Marker")]
    public class CampusTapWaitMarker : TweenMarkerBase
    {
        [SerializeField]
        private string _id;
        public string Id
        {
            get
            {
                return null;
            }
        }

        public override void Execute(TweenCreationContext context)
        {
        }

        public CampusTapWaitMarker()
        {
        }
    }
}
