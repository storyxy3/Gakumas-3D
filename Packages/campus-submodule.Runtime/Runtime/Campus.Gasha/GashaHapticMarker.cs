namespace Campus.Gasha
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::Qua.Base;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaHapticMarker")]
    public class GashaHapticMarker : Marker, INotification
    {
        [Serializable]
        private enum SerializedPower : byte
        {
            SuperLight = 100,
            Light = 0,
            Medium = 1,
            Heavy = 2
        }

        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        [SerializeField]
        private SerializedPower _power;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return _003Cid_003Ek__BackingField;
            }
        }

        public HapticFeedback.Power Power
        {
            get
            {
                return default(HapticFeedback.Power);
            }
        }

        public GashaHapticMarker()
        {
        }
    }
}
