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
            }
        }

        [SerializeField]
        private PlayableDirector _master;
        private List<PlayableDirector> _directors;
        public PlayableDirector master
        {
            get
            {
                return null;
            }
        }

        private IReadOnlyList<PlayableDirector> Directors
        {
            get
            {
                return null;
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void Bind(Dictionary<string, BindAction> onBindTable)
        {
        }

        public void BindReference(Dictionary<string, ReferenceBindParam[]> bindData)
        {
        }

        public void RebuildGraph()
        {
        }

        protected virtual void Destroy()
        {
        }

        public void Play()
        {
        }

        public VLTimelineController()
        {
        }
    }
}
