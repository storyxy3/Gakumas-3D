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
                return pair.Key == order;
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
                return x.Key == order;
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
                return pair.Key == order;
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
            Setup();
            if (!_graph.IsValid()) return;
            if (_insertedList == null) _insertedList = new List<KeyValuePair<int, RootPlayableData>>();
            if (_insertedList.Exists(pair => pair.Key == order))
            {
                Debug.LogError("既に接続されています:" + order.ToString());
                return;
            }
            var output = _graph.GetOutput(0);
            var child = output.GetSourcePlayable();
            var parent = new RootPlayableData { baseInputIndex = -1, playable = Playable.Null };
            int index = _insertedList.Count;
            for (int i = _insertedList.Count - 1; i >= 0; i--)
            {
                if (_insertedList[i].Key <= order) break;
                parent = _insertedList[i].Value;
                child = parent.GetBaseInput();
                index = i;
            }
            if (parent.IsValid()) parent.DisconnectBaseInput();
            var data = onConnect(_graph, child);
            _insertedList.Insert(index, new KeyValuePair<int, RootPlayableData>(order, data));
            if (parent.IsValid()) parent.ConnectBaseInput(data.playable);
            else output.SetSourcePlayable(data.playable);
        }

        public Playable GetRootPlayable(int order)
        {
            if (!_graph.IsValid() || _insertedList == null) return Playable.Null;
            return _insertedList.Find(x => x.Key == order).Value.playable;
        }

        public void RemoveRootPlayable(int order, OnDisconnectRootPlayable onDisconnect)
        {
            if (!_graph.IsValid()) return;
            if (_insertedList == null) _insertedList = new List<KeyValuePair<int, RootPlayableData>>();
            if (!_insertedList.Exists(pair => pair.Key == order))
            {
                Debug.LogError("接続されていません:" + order.ToString());
                return;
            }
            var output = _graph.GetOutput(0);
            for (int i = 0; i < _insertedList.Count; i++)
            {
                if (_insertedList[i].Key != order) continue;
                var data = _insertedList[i].Value;
                var parent = data.playable.GetOutput(0);
                if (parent.IsValid())
                {
                    for (int j = 0; j < parent.GetInputCount(); j++)
                    {
                        if (parent.GetInput(j).Equals(data.playable))
                        {
                            parent.DisconnectInput(j);
                            break;
                        }
                    }
                }
                var child = onDisconnect(_graph, data);
                if (parent.IsValid()) parent.ConnectInput(0, child, 0);
                else output.SetSourcePlayable(child);
                _insertedList.RemoveAt(i);
                return;
            }
        }

        private void DestroyGraph()
        {
            if (_graph.IsValid())
                _graph.Destroy();
        }

        protected virtual void OnDisable()
        {
            DestroyGraph();
        }

        protected virtual void OnDestroy()
        {
            DestroyGraph();
        }

        protected AnimationPlayerBase()
        {
        }
    }
}
