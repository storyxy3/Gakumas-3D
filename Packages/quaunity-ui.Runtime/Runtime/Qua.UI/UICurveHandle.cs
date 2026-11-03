namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class UICurveHandle : QuaUIBehaviour
    {
        [SerializeField]
        private RectTransform _weightEdge;
        [SerializeField]
        private float _weightEdgeSize;
        [SerializeField]
        private RectTransform _rotateBone;
        [SerializeField]
        private DragGesture _dragGesture;
        [CompilerGenerated]
        private Action<Vector2> _003COnDragCallback_003Ek__BackingField;
        public Action<Vector2> OnDragCallback
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public void Initialize()
        {
        }

        public void SetEulerAngle(float z)
        {
        }

        public void SetWeight(float weight)
        {
        }

        public UICurveHandle()
        {
        }

        [CompilerGenerated]
        private void _003CInitialize_003Eb__8_0()
        {
        }
    }
}
