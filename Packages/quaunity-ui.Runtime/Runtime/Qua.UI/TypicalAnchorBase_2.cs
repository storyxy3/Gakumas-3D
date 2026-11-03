namespace Qua.UI
{
    using global::System;
    using global::Qua.UI;
    using global::UnityEngine;

    [ExecuteAlways]
    [DefaultExecutionOrder(100)]
    public abstract class TypicalAnchorBase<TAnchorType, TAnchorInfo> : TypicalAnchorBase where TAnchorInfo : TypicalAnchorBase<TAnchorType, TAnchorInfo>.AnchorInfoBase, new()
    {
        [Serializable]
        public class AnchorInfoBase
        {
            public bool enabled;
            public TAnchorType anchorType;
            public float offset;
            public AnchorInfoBase()
            {
            }
        }

        [SerializeField]
        protected TAnchorInfo _left;
        [SerializeField]
        protected TAnchorInfo _right;
        [SerializeField]
        protected TAnchorInfo _top;
        [SerializeField]
        protected TAnchorInfo _bottom;
        private RectTransform _own;
        private bool _isUpdatingRect;
        public TAnchorInfo Left
        {
            get
            {
                return null;
            }
        }

        public TAnchorInfo Right
        {
            get
            {
                return null;
            }
        }

        public TAnchorInfo Top
        {
            get
            {
                return null;
            }
        }

        public TAnchorInfo Bottom
        {
            get
            {
                return null;
            }
        }

        protected abstract ITypicalAnchorManager<TAnchorType> Manager { get; }
        protected abstract bool ExistsManager { get; }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public override void ApplyAnchors()
        {
        }

        private Vector2 GetTargetLocalPosition(TAnchorInfo info, Vector2 anchor)
        {
            return default(Vector2);
        }

        protected TypicalAnchorBase()
        {
        }
    }
}
