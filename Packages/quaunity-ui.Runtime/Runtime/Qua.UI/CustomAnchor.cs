namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.Serialization;

    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    [DefaultExecutionOrder(100)]
    public class CustomAnchor : QuaUIBehaviour
    {
        private enum ExecuteType
        {
            OnStart,
            OnEnable,
            OnUpdate
        }

        [Serializable]
        public class TargetInfo
        {
            public bool enabled;
            [FormerlySerializedAs("targetTransform")]
            public RectTransform target;
            public Vector2 anchor;
            public float offset;
            public TargetInfo()
            {
            }
        }

        [SerializeField]
        private ExecuteType _executeType;
        [SerializeField]
        private TargetInfo _left;
        [SerializeField]
        private TargetInfo _right;
        [SerializeField]
        private TargetInfo _bottom;
        [SerializeField]
        private TargetInfo _top;
        private RectTransform _own;
        protected override void Start()
        {
        }

        protected override void OnEnable()
        {
        }

        private void Update()
        {
        }

        public void ApplyAnchors()
        {
        }

        private Vector2 GetTargetLocalPosition(TargetInfo info)
        {
            return default(Vector2);
        }

        public CustomAnchor()
        {
        }
    }
}
