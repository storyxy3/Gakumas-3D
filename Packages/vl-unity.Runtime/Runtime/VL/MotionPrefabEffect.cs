namespace VL
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Serialization;
    using global::VL;

    [CreateAssetMenu(fileName = "MotionPrefabEffect.asset", menuName = "VL/Motion Prefab Effect", order = 70001)]
    public class MotionPrefabEffect : MotionEffectBase
    {
        [FormerlySerializedAs("_particleAsset")]
        [SerializeField]
        private GameObject _prefabAsset;
        [SerializeField]
        private uint _particleRandomSeed;
        [SerializeField]
        private string _parentTransformPath;
        [SerializeField]
        private Vector3 _offsetPosition;
        [SerializeField]
        private Vector3 _offsetRotation;
        public GameObject prefabAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public uint particleRandomSeed
        {
            get
            {
                return default(uint);
            }

            set
            {
            }
        }

        public string parentTransformPath
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Vector3 offsetPosition
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 offsetRotation
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public override string className
        {
            get
            {
                return null;
            }
        }

        public override string trackName
        {
            get
            {
                return null;
            }
        }

        private void OnEnable()
        {
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go, bool isSubTrack, bool isTimeline)
        {
            return default(Playable);
        }

        public MotionPrefabEffect()
        {
        }
    }
}
