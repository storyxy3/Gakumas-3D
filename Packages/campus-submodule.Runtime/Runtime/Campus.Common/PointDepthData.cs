namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;

    public class PointDepthData : MonoBehaviour
    {
        [CompilerGenerated]
        private bool _003CIsCapture_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CViewportPoint_003Ek__BackingField;
        [CompilerGenerated]
        private GraphicsBuffer _003COutputBuffer_003Ek__BackingField;
        public bool IsCapture
        {
            [CompilerGenerated]
            get
            {
                return _003CIsCapture_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsCapture_003Ek__BackingField = value;
            }
        }

        public Vector2 ViewportPoint
        {
            [CompilerGenerated]
            get
            {
                return _003CViewportPoint_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CViewportPoint_003Ek__BackingField = value;
            }
        }

        public GraphicsBuffer OutputBuffer
        {
            [CompilerGenerated]
            get
            {
                return _003COutputBuffer_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COutputBuffer_003Ek__BackingField = value;
            }
        }

        public PointDepthData()
        {
        }
    }
}
