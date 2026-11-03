namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [RequireComponent(typeof(Animator))]
    public class ActorAnimationSimpleInitializer : MonoBehaviour
    {
        [SerializeField]
        private ActorAnimationRig _rig;
        private ActorAnimationBuilder _builder;
        private Animator _animator;
        private PlayableGraph _graph;
        private readonly string PlayableGraphName;
        public void SetRig(ActorAnimationRig rig)
        {
        }

        private void Start()
        {
        }

        public void Setup()
        {
        }

        public void Update()
        {
        }

        private void OnDestroy()
        {
        }

        public void Clear()
        {
        }

        [ContextMenu("揺れものリセット")]
        private void ResetDynamic()
        {
        }

        public ActorAnimationSimpleInitializer()
        {
        }
    }
}
