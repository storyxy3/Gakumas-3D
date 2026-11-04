namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    public class ActorAnimationBuilder
    {
        protected AnimationPlayableOutput _syncLayerOutput;
        protected AnimationScriptPlayable _syncLayerPlayable;
        protected AnimationPlayableOutput _output;
        protected AnimationScriptPlayable _playable;
        private Animator _animator;
        private ActorAnimationRig _actorAnimationRig;
        private ushort _setSortingOrder;
        public virtual ushort setSortingOrder
        {
            get
            {
                return default(ushort);
            }
        }

        public void Build(Animator animator, PlayableGraph graph, ActorAnimationRig actorAnimationRig)
        {
        }

        private AnimationScriptPlayable BuildRigPlayable(PlayableGraph graph)
        {
            return default(AnimationScriptPlayable);
        }

        public virtual void Update()
        {
        }

        public void Destroy(PlayableGraph graph)
        {
            if (_syncLayerPlayable.IsValid()) _syncLayerPlayable.Destroy();
            if (_playable.IsValid()) _playable.Destroy();
            if (graph.IsValid())
            {
                if (_syncLayerOutput.IsOutputValid()) graph.DestroyOutput(_syncLayerOutput);
                if (_output.IsOutputValid()) graph.DestroyOutput(_output);
            }
        }

        public ActorAnimationBuilder()
        {
        }
    }
}
