namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Experimental.Animations;
    using global::UnityEngine.Animations.Rigging;

    public class CampusActorAnimationBuilder : ActorAnimationBuilder
    {
        private CampusActorAnimationRig _actorAnimationRig;
        private Animator _animator;
        private ushort _setSortingOrder = 510;
        public override ushort setSortingOrder
        {
            get
            {
                return _setSortingOrder;
            }
        }

        public AnimationScriptPlayable playable
        {
            get
            {
                return _playable;
            }
        }

        public void Build(Animator animator, PlayableGraph graph, CampusActorAnimationRig actorAnimationRig)
        {
            _animator = animator;
            _actorAnimationRig = actorAnimationRig;
            _syncLayerOutput = AnimationPlayableOutput.Create(graph, "syncSceneToStreamOutput", animator);
            _syncLayerOutput.SetAnimationStreamSource(AnimationStreamSource.PreviousInputs);
            _syncLayerOutput.SetSortingOrder(setSortingOrder);
            _actorAnimationRig.Initialize(animator);
            _output = AnimationPlayableOutput.Create(graph, "CampusActorAnimationRigOutput", animator);
            _output.SetAnimationStreamSource(AnimationStreamSource.PreviousInputs);
            _output.SetSortingOrder(setSortingOrder);
            _playable = BuildRigPlayable(graph);
            _output.SetSourcePlayable(_playable);
        }

        private AnimationScriptPlayable BuildRigPlayable(PlayableGraph graph)
        {
            if (_actorAnimationRig == null || _actorAnimationRig.job == null) return AnimationScriptPlayable.Null;
            return ((IRigConstraint)_actorAnimationRig).binder.CreatePlayable(graph, _actorAnimationRig.job);
        }

        public override void Update()
        {
            UpdateConstraint();
        }

        private void UpdateConstraint()
        {
            int count = _actorAnimationRig.data.constraintTransformBones.Count;
            for (int i = 0; i < count; i++)
            {
                if (_actorAnimationRig.data.constraintTransformBones[i].isDirty)
                    _actorAnimationRig.UpdateConstraintSource(_animator);
            }
            _actorAnimationRig.UpdateConstraints();
        }

        public CampusActorAnimationBuilder()
        {
        }
    }
}
