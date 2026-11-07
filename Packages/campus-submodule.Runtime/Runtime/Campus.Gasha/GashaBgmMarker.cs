namespace Campus.Gasha
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaBgmMarker")]
    public class GashaBgmMarker : Marker, INotification
    {
        [Serializable]
        public enum BgmType
        {
            Marker,
            Environment,
            Pickup
        }

        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public string assetName;
        public double startTime;
        public BgmType bgmType;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return _003Cid_003Ek__BackingField;
            }
        }

        public GashaBgmMarker()
        {
        }
    }
}
