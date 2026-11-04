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
        public float noiseIntensity = 0.5f;
        public int flareIndex;
        public float flareScale = 1f;
        public FloatCurve specularStrength = new FloatCurve(1f) { IsValid = true };
        public FloatCurve realLightMultiplier;
        protected override void OnUpdateParameter(LiveEquipmentLightAssetBehaviour behaviour, PlayableGraph graph)
        {
            behaviour.SpotAngle = spotAngle;
            behaviour.SideThickness = sideThickness;
            behaviour.RangeLimit = rangeLimit;
            behaviour.FlareIndex = flareIndex;
            behaviour.NoiseIntensity = noiseIntensity;
            behaviour.FlareScale = flareScale;
            behaviour.SpecularStrength = specularStrength;
            behaviour.RealLightMultiplier = realLightMultiplier;
        }

        public LiveEquipmentLightClip()
        {
        }
    }
}
