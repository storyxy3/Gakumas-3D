namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    public class CampusActorAnimationBuilder : ActorAnimationBuilder
    {
        private CampusActorAnimationRig _actorAnimationRig;
        private Animator _animator;
        private ushort _setSortingOrder;
        public override ushort setSortingOrder
        {
            get
            {
                return default(ushort);
            }
        }

        public AnimationScriptPlayable playable
        {
            get
            {
                return default(AnimationScriptPlayable);
            }
        }

        public void Build(Animator animator, PlayableGraph graph, CampusActorAnimationRig actorAnimationRig)
        {
        }

        private AnimationScriptPlayable BuildRigPlayable(PlayableGraph graph)
        {
            return default(AnimationScriptPlayable);
        }

        public override void Update()
        {
        }

        private void UpdateConstraint()
        {
        }

        public CampusActorAnimationBuilder()
        {
        }
    }
}
