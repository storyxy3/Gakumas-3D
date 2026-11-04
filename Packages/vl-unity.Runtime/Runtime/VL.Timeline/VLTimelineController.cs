namespace VL.Timeline
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL.Timeline;

    [ExecuteAlways]
    [RequireComponent(typeof(PlayableDirector))]
    public class VLTimelineController : MonoBehaviour
    {
        public delegate Object BindAction(PlayableBinding binding);
        public class ReferenceBindParam
        {
            public readonly string referenceName;
            public readonly Object referenceValue;
            public ReferenceBindParam(string referenceName, Object referenceValue)
            {
                this.referenceName = referenceName;
                this.referenceValue = referenceValue;
            }
        }

        [SerializeField]
        private PlayableDirector _master;
        private List<PlayableDirector> _directors;
        public PlayableDirector master
        {
            get
            {
                return _master;
            }
        }

        private IReadOnlyList<PlayableDirector> Directors
        {
            get
            {
                if (_directors == null)
                {
                    _directors = new List<PlayableDirector>();
                    GetComponentsInChildren(true, _directors);
                }
                return _directors;
            }
        }

        private void OnEnable()
        {
            if (_master == null) _master = GetComponent<PlayableDirector>();
        }

        private void OnDisable()
        {
            Destroy();
        }

        public void Bind(Dictionary<string, BindAction> onBindTable)
        {
            if (onBindTable == null) return;
            if (_master == null)
            {
                Debug.LogError("PlayableDirectorが見つかりません");
                return;
            }
            foreach (var director in Directors)
            {
                if (director.playableAsset == null) continue;
                onBindTable.TryGetValue(director.name, out var onBind);
                foreach (var binding in director.playableAsset.outputs)
                {
                    var value = onBind?.Invoke(binding);
                    if (value != null) director.SetGenericBinding(binding.sourceObject, value);
                }
                if (director.playableGraph.IsValid()) director.RebuildGraph();
            }
        }

        public void BindReference(Dictionary<string, ReferenceBindParam[]> bindData)
        {
            if (bindData == null) return;
            if (_master == null)
            {
                Debug.LogError("PlayableDirectorが見つかりません");
                return;
            }
            foreach (var director in Directors)
            {
                if (bindData.TryGetValue(director.name, out var parameters))
                {
                    foreach (var parameter in parameters)
                        director.SetReferenceValue(parameter.referenceName, parameter.referenceValue);
                }
            }
        }

        public void RebuildGraph()
        {
            if (_directors != null)
            {
                foreach (var director in _directors) director.RebuildGraph();
            }
        }

        protected virtual void Destroy()
        {
        }

        public void Play()
        {
            if (_master == null) return;
            _master.Play();
        }

        public VLTimelineController()
        {
        }
    }
}
