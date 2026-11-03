namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Common;
    using global::Campus.Live.Equipment.Environment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Serialization;

    public class LiveEquipmentLaserClip : LiveEquipmentClipBase<LiveEquipmentLaserAssetBehaviour>
    {
        [FormerlySerializedAs("beamType")]
        public LiveLaser.LaserType laserType;
        public LiveLaser.LightType lightType;
        [FormerlySerializedAs("beamLength")]
        public int laserLength;
        [FormerlySerializedAs("beamCount")]
        [Range(1f, 16f)]
        public int laserCount;
        [FormerlySerializedAs("beamRadius")]
        [Range(1f, 100f)]
        public int laserRadius;
        [Range(0f, 500f)]
        public float randomSpeed;
        [SerializeField]
        public FloatCurve laserAngle;
        public float lightOnTime;
        public float lightOffTime;
        public float lightDelay;
        protected override void OnUpdateParameter(LiveEquipmentLaserAssetBehaviour behaviour, PlayableGraph graph)
        {
        }

        public LiveEquipmentLaserClip()
        {
        }
    }
}
