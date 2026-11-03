namespace VL.Animation
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public abstract class AnimationPlayerBase : MonoBehaviour, IAnimationPlayer
    {
        [SerializeField]
        private Animator _animator;
        private PlayableGraph _graph;
        private List<KeyValuePair<int, RootPlayableData>> _insertedList;
        public bool initialized
        {
            get
            {
                return default(bool);
            }
        }

        public Animator animator
        {
            get
            {
                return null;
            }
        }

        protected PlayableGraph CreatePlayableGraph()
        {
            return default(PlayableGraph);
        }

        public PlayableGraph GetPlayableGraph()
        {
            return default(PlayableGraph);
        }

        public abstract void Setup();
        public virtual IAnimationController GetPlayingBaseController()
        {
            return null;
        }

        public virtual IAnimationController GetPlayingLayerController(string layerName)
        {
            return null;
        }

        public void InsertRootPlayable(int order, OnInsertRootPlayable onConnect)
        {
        }

        public Playable GetRootPlayable(int order)
        {
            return default(Playable);
        }

        public void RemoveRootPlayable(int order, OnDisconnectRootPlayable onDisconnect)
        {
        }

        private void DestroyGraph()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        protected AnimationPlayerBase()
        {
        }
    }
}
