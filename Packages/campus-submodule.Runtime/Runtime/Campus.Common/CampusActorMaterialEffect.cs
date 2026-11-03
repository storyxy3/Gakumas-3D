namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;

    [CreateAssetMenu(fileName = "CampusActorMaterialEffect.asset", menuName = "Campus/Actor Material Effect", order = 1102)]
    public class CampusActorMaterialEffect : MotionEffectBase
    {
        public CampusActorMaterialProperty overrideProperty;
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

        public CampusActorMaterialEffect()
        {
        }
    }
}
