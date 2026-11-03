namespace Campus.Gasha
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaFadeOutStartMarker")]
    public class GashaFadeOutStartMarker : Marker, INotification
    {
        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public AnimationCurve inCurve;
        public float inDuration;
        public AnimationCurve outCurve;
        public float outDuration;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return default(PropertyName);
            }
        }

        public GashaFadeOutStartMarker()
        {
        }
    }
}
