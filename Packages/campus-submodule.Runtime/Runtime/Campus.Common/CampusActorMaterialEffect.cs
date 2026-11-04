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
                return "ActorMaterial上書き";
            }
        }

        public override string trackName
        {
            get
            {
                return overrideProperty?.materialName ?? "CampusActorMaterialEffect";
            }
        }

        private void OnEnable()
        {
            if (overrideProperty == null) overrideProperty = new CampusActorMaterialProperty();
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go, bool isSubTrack, bool isTimeline)
        {
            if (!go.TryGetComponent<CampusActorController>(out var actor)) return Playable.Null;
            var behaviour = new CampusActorMaterialEffectPlayable
            {
                isSubTrack = isSubTrack,
                actorController = actor,
                overrideProperty = overrideProperty,
                isTimeline = isTimeline
            };
            return ScriptPlayable<CampusActorMaterialEffectPlayable>.Create(graph, behaviour);
        }

        public CampusActorMaterialEffect()
        {
        }
    }
}
