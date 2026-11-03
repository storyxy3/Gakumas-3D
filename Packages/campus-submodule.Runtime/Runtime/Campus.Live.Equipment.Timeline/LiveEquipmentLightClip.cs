namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Common;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class LiveEquipmentLightClip : LiveEquipmentClipBase<LiveEquipmentLightAssetBehaviour>
    {
        [Range(1f, 90f)]
        public int spotAngle;
        [Range(0.1f, 1f)]
        public float sideThickness;
        [Min(0.1f)]
        public float rangeLimit;
        [Range(0f, 1f)]
        public float noiseIntensity;
        public int flareIndex;
        public float flareScale;
        public FloatCurve specularStrength;
        public FloatCurve realLightMultiplier;
        protected override void OnUpdateParameter(LiveEquipmentLightAssetBehaviour behaviour, PlayableGraph graph)
        {
        }

        public LiveEquipmentLightClip()
        {
        }
    }
}
