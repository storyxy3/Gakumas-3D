namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine.Playables;

    public class CampusActorMaterialEffectPlayable : PlayableBehaviour
    {
        public bool isSubTrack;
        public CampusActorController actorController;
        public CampusActorMaterialProperty overrideProperty;
        public bool isTimeline;
        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        private void OverrideMaterialProperty(Playable playable, FrameData info)
        {
        }

        public CampusActorMaterialEffectPlayable()
        {
        }
    }
}
