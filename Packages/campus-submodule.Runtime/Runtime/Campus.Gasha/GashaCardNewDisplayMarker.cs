namespace Campus.Gasha
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaCardNewDisplayMarker")]
    public class GashaCardNewDisplayMarker : Marker, INotification
    {
        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return _003Cid_003Ek__BackingField;
            }
        }

        public GashaCardNewDisplayMarker()
        {
        }
    }
}
