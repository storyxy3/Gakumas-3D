namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;

    [DisplayName("Titan/Campus Skip Marker")]
    public class CampusSkipMarker : TweenMarkerBase
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

        public CampusSkipMarker()
        {
        }
    }
}
