namespace Campus.Gasha
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/Gasha3DModelMarker")]
    public class Gasha3DModelMarker : Marker, INotification
    {
        public enum ShowType
        {
            Show,
            Hide
        }

        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public ShowType showType;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return default(PropertyName);
            }
        }

        public Gasha3DModelMarker()
        {
        }
    }
}
