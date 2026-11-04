namespace VL.Animation
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL.Animation;

    public abstract class AnimationPlayerBase : MonoBehaviour, IAnimationPlayer
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass12_0
        {
            public int order;
            public _003C_003Ec__DisplayClass12_0()
            {
            }

            internal bool _003CInsertRootPlayable_003Eb__0(KeyValuePair<int, RootPlayableData> pair)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass13_0
        {
            public int order;
            public _003C_003Ec__DisplayClass13_0()
            {
            }

            internal bool _003CGetRootPlayable_003Eb__0(KeyValuePair<int, RootPlayableData> x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass14_0
        {
            public int order;
            public _003C_003Ec__DisplayClass14_0()
            {
            }

            internal bool _003CRemoveRootPlayable_003Eb__0(KeyValuePair<int, RootPlayableData> pair)
            {
                return default(bool);
            }
        }

        [SerializeField]
        private Animator _animator;
        private PlayableGraph _graph;
        private List<KeyValuePair<int, RootPlayableData>> _insertedList;
        public bool initialized
        {
            get
            {
                return _graph.IsValid();
            }
        }

        public Animator animator
        {
            get
            {
                if (_animator == null && !TryGetComponent(out _animator))
                    _animator = gameObject.AddComponent<Animator>();
                return _animator;
            }
        }

        protected PlayableGraph CreatePlayableGraph()
        {
            if (initialized)
                DestroyGraph();
            _graph = PlayableGraph.Create(name);
            return _graph;
        }

        public PlayableGraph GetPlayableGraph()
        {
            return _graph;
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
            if (_graph.IsValid())
                _graph.Destroy();
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
