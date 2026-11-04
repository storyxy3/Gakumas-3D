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
        public int laserLength = 10;
        [FormerlySerializedAs("beamCount")]
        [Range(1f, 16f)]
        public int laserCount = 8;
        [FormerlySerializedAs("beamRadius")]
        [Range(1f, 100f)]
        public int laserRadius = 10;
        [Range(0f, 500f)]
        public float randomSpeed;
        [SerializeField]
        public FloatCurve laserAngle;
        public float lightOnTime = 0.3f;
        public float lightOffTime = 0.3f;
        public float lightDelay = 0.1f;
        protected override void OnUpdateParameter(LiveEquipmentLaserAssetBehaviour behaviour, PlayableGraph graph)
        {
            behaviour.LaserType = laserType;
            behaviour.LightType = lightType;
            behaviour.LaserLength = laserLength;
            behaviour.LaserCount = laserCount;
            behaviour.LaserRadius = laserRadius;
            behaviour.RandomSpeed = randomSpeed;
            behaviour.LightOnTime = lightOnTime;
            behaviour.LightOffTime = lightOffTime;
            behaviour.LightDelay = lightDelay;
            behaviour.LaserAngle = laserAngle;
        }

        public LiveEquipmentLaserClip()
        {
        }
    }
}
